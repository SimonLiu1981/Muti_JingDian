using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Telerik.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Model;

namespace dx177.WebUI.admin.QuestionMgnt
{
    public partial class QsttypeTree : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitData();
            }
            
        }
        private void InitData()
        {
            RadTree1.Nodes.Clear();

            //QsttypeQuery query = new QsttypeQuery();
            //query.Licd = AppContext.LCID;
            //query.CreateBy = AppContext.CurrentAdministrator.UserName;
            DataTable dt = QsttypeBLL.GetInstance().GetQsttypeList(AppContext.CurrentMgtJingQuCode);
            if (dt.Rows.Count <= 0)
            {
                Qsttype nt1 = new Qsttype();
                nt1.Title = "新问题类型";
                nt1.Pguid = "";
                nt1.Guid = System.Guid.NewGuid().ToString();
                nt1.Creator = AppContext.CurrentResuser.Username;
                nt1.CreateDate = DateTime.Now;
                nt1.LasteUpdateBy = AppContext.CurrentResuser.Username;
                nt1.LasteUpdateDate = DateTime.Now;
                nt1.Jingqucode = AppContext.CurrentMgtJingQuCode;
                QsttypeBLL.GetInstance().Insert(nt1);
                dt = QsttypeBLL.GetInstance().GetQsttypeList(AppContext.CurrentMgtJingQuCode);
            }

            dt.DataSet.Relations.Add("NodeRelation", dt.DataSet.Tables[0].Columns["GUID"], dt.DataSet.Tables[0].Columns["PGUID"], false);

            foreach (DataRow dbRow in dt.DataSet.Tables[0].Rows)
            {

                if (dbRow["PGUID"].ToString() == "")//这个就是第一层。
                {
                    RadTreeNode node = CreateNode(dbRow["title"].ToString(), false, dbRow["GUID"].ToString());
                    node.Category = "Folder";
                    RadTree1.AddNode(node);
                    RecursivelyPopulate(dbRow, node);
                }
            }

            dt.DataSet.Relations.Remove("NodeRelation");
        }

        private void RecursivelyPopulate(DataRow dbRow, RadTreeNode node)
        {
            foreach (DataRow childRow in dbRow.GetChildRows("NodeRelation"))
            {
                RadTreeNode childNode = CreateNode(childRow["title"].ToString(), true, childRow["GUID"].ToString());
                node.AddNode(childNode);
                RecursivelyPopulate(childRow, childNode);
            }
        }


        private RadTreeNode CreateNode(string text, bool expanded, string id)
        {
            RadTreeNode node = new RadTreeNode(text);
            node.Expanded = expanded;
            node.ID = id;
            return node;
        }

        private void Update()
        {
            Qsttype nt = QsttypeBLL.GetInstance().GetQsttypeByguid(RadTree1.SelectedNode.ID);
            nt.Title = txtTitle.Text;
            nt.Shortcontent = txtShortcontent.Text;
            nt.Content = txtContent.Text;
            nt.Code = txtCode.Text;
            nt.Creator = AppContext.CurrentResuser.Username;
            nt.LasteUpdateBy = AppContext.CurrentResuser.Username;
            nt.LasteUpdateDate = DateTime.Now;
            nt.CreateDate = DateTime.Now;
            nt.Jingqucode = AppContext.CurrentMgtJingQuCode;
            QsttypeBLL.GetInstance().Update(nt);
            QsttypeBLL.GetInstance().CreateJs(AppContext.CurrentMgtJingQuCode);
        }

        protected void RadTree1_NodeEdit1(object o, RadTreeNodeEventArgs e)
        {
            RadTreeNode nodeEdited = e.NodeEdited;
            string newText = e.NewText;
            if (newText == null || newText == string.Empty)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "RadTree1_NodeEdit1", "<script>alert('命名不能为空！');</script>");
            }
            else
            {
                Update();
                GenerateTreeView();
            }
        }

        protected void RadMenu1_ItemClick1(object sender, RadMenuEventArgs e)
        {
            HandleItemClicked(e);
        }

        private void HandleItemClicked(RadMenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Delete":
                    if (RadTree1.SelectedNode.Nodes.Count > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Delete", "<script>alert('还存在有子节点，请先删除子节点！');</script>");
                    }
                    else
                    {
                        if (RadTree1.SelectedNode == RadTree1.Nodes[0]
                            && RadTree1.Nodes.Count == 1)
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Delete1", "<script>alert('类型树必须要有一个以上节点，请不要删除！');</script>");
                        }
                        else
                        {
                            Qsttype dQsttype = QsttypeBLL.GetInstance().GetQsttypeByguid(RadTree1.SelectedNode.ID);
                            QsttypeBLL.GetInstance().Delete(dQsttype);
                            GenerateTreeView();
                        }
                    }
                    break;
                case "AddSubLevel":
                    RadTreeNode rt = new RadTreeNode("新问题类型");
                    Qsttype PQsttype = QsttypeBLL.GetInstance().GetQsttypeByguid(RadTree1.SelectedNode.ID);
                    Qsttype nt = new Qsttype();
                    nt.Title = "新问题类型";
                    nt.Pguid = PQsttype.Guid ;
                    nt.Guid = System.Guid.NewGuid().ToString();
                    nt.Creator = AppContext.CurrentResuser.Username;
                    nt.CreateDate = DateTime.Now;
                    nt.LasteUpdateBy = AppContext.CurrentResuser.Username;
                    nt.LasteUpdateDate = DateTime.Now;
                    nt.Jingqucode = AppContext.CurrentMgtJingQuCode;
                    QsttypeBLL.GetInstance().Insert(nt);
                    RadTree1.SelectedNode.AddNode(rt);
                    GenerateTreeView();
                    break;
                case "AddSameLevel":
                    RadTreeNode rt1 = new RadTreeNode("新问题类型");
                    string Guid="";
                    if (RadTree1.SelectedNode.Parent != null)
                    {
                        Qsttype PQsttype1 = QsttypeBLL.GetInstance().GetQsttypeByguid(RadTree1.SelectedNode.ID);
                        Guid = PQsttype1.Guid;
                    }
                    Qsttype nt1 = new Qsttype();
                    nt1.Title = "新问题类型";
                    nt1.Pguid = Guid;
                    nt1.Guid = System.Guid.NewGuid().ToString();
                    nt1.Creator = AppContext.CurrentResuser.Username;
                    nt1.CreateDate = DateTime.Now;
                    nt1.LasteUpdateBy = AppContext.CurrentResuser.Username;
                    nt1.LasteUpdateDate = DateTime.Now;
                    nt1.Jingqucode = AppContext.CurrentMgtJingQuCode;
                    QsttypeBLL.GetInstance().Insert(nt1);
                  
                    RadTree1.SelectedNode.AddNode(rt1);
                    GenerateTreeView();
                    break;
            }
            ReNewCache();
        }

        private void GenerateTreeView()
        {
            RadTree1.Nodes.Clear();
            //QsttypeQuery query = new QsttypeQuery();
            //query.Licd = AppContext.LCID;
            //query.CreateBy = AppContext.CurrentAdministrator.UserName;
            DataTable dt = QsttypeBLL.GetInstance().GetQsttypeList(AppContext.CurrentMgtJingQuCode);

            dt.DataSet.Relations.Add("NodeRelation", dt.DataSet.Tables[0].Columns["GUID"], dt.DataSet.Tables[0].Columns["PGUID"], false);

            foreach (DataRow dbRow in dt.DataSet.Tables[0].Rows)
            {

                if (dbRow["PGUID"].ToString() == "")//这个就是第一层。
                {
                    RadTreeNode node = CreateNode(dbRow["title"].ToString(), false, dbRow["GUID"].ToString());
                    node.Category = "Folder";
                    RadTree1.AddNode(node);
                    RecursivelyPopulate(dbRow, node);
                }
            }
            dt.DataSet.Relations.Remove("NodeRelation");
        }

        private void ReNewCache()
        {

            // Dict.CacheData.ClearLocalCache(CacheName.AreaType.ToString());
        }




        protected void RadMenu2_ItemClick1(object sender, RadMenuEventArgs e)
        {
            HandleItemClicked(e);

        }

        protected void RadTree1_NodeClick(object o, RadTreeNodeEventArgs e)
        {
            SerId.Value = RadTree1.SelectedNode.ID;
            SetValue();

        }

        private void SetValue()
        {

            Qsttype n = new Qsttype();
            if (SerId.Value != string.Empty)
            {
                n = QsttypeBLL.GetInstance().GetQsttypeByguid(SerId.Value);
            }
            txtTitle.Text = n.Title;
            txtShortcontent.Text = n.Shortcontent ;
            txtContent.Text = n.Content;
            txtCode.Text = n.Code;
            this.btnSave.Enabled = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Update();
            GenerateTreeView();
        }
    }
}
