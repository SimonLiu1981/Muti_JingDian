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

namespace dx177.WebUI.admin.NewsMgnt
{
    public partial class NewsTypeTree : BasePage
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

            //NewsTypeQuery query = new NewsTypeQuery();
            //query.Licd = AppContext.LCID;
            //query.CreateBy = AppContext.CurrentAdministrator.UserName;
            DataTable dt = NewstypeBLL.GetInstance().GetNewsTypeList();
            if (dt.Rows.Count <= 0)
            {
                Newstype nt1 = new Newstype();
                nt1.Title = "新新闻类型";
                nt1.Pguid = "";
                nt1.Guid = System.Guid.NewGuid().ToString();
                nt1.Creator = AppContext.CurrentResuser.Username;
                nt1.CreateDate = DateTime.Now;
                nt1.LasteUpdateBy = AppContext.CurrentResuser.Username;
                nt1.LasteUpdateDate = DateTime.Now;
                //nt1.Jingqucode = AppContext.CurrentMgtJingQuCode;
                NewstypeBLL.GetInstance().Insert(nt1);
                dt = NewstypeBLL.GetInstance().GetNewsTypeList();
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
            Newstype nt = NewstypeBLL.GetInstance().GetNewstypeByguid(RadTree1.SelectedNode.ID);
            nt.Title = txtTitle.Text;
            nt.Shortcontent = txtShortcontent.Text;
            nt.Content = txtContent.Text;
            nt.Code = txtCode.Text;
            nt.Creator = AppContext.CurrentResuser.Username;
            nt.LasteUpdateBy = AppContext.CurrentResuser.Username;
            nt.LasteUpdateDate = DateTime.Now;
            nt.CreateDate = DateTime.Now;
            nt.Jingqucode = AppContext.CurrentMgtJingQuCode;
            NewstypeBLL.GetInstance().Update(nt);
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
                            Newstype dNewstype = NewstypeBLL.GetInstance().GetNewstypeByguid(RadTree1.SelectedNode.ID);
                            NewstypeBLL.GetInstance().Delete(dNewstype);
                            GenerateTreeView();
                        }
                    }
                    break;
                case "AddSubLevel":
                    RadTreeNode rt = new RadTreeNode("新新闻类型");
                    Newstype PNewstype = NewstypeBLL.GetInstance().GetNewstypeByguid(RadTree1.SelectedNode.ID);
                    Newstype nt = new Newstype();
                    nt.Title = "新新闻类型";
                    nt.Pguid = PNewstype.Guid ;
                    nt.Guid = System.Guid.NewGuid().ToString();
                    nt.Creator = AppContext.CurrentResuser.Username;
                    nt.CreateDate = DateTime.Now;
                    nt.LasteUpdateBy = AppContext.CurrentResuser.Username;
                    nt.Jingqucode = AppContext.CurrentMgtJingQuCode;
                    nt.LasteUpdateDate = DateTime.Now;
                    NewstypeBLL.GetInstance().Insert(nt);
                    RadTree1.SelectedNode.AddNode(rt);
                    GenerateTreeView();
                    break;
                case "AddSameLevel":
                    RadTreeNode rt1 = new RadTreeNode("新新闻类型");
                    string Guid="";
                    if (RadTree1.SelectedNode.Parent != null)
                    {
                        Newstype PNewstype1 = NewstypeBLL.GetInstance().GetNewstypeByguid(RadTree1.SelectedNode.ID);
                        Guid = PNewstype1.Guid;
                    }
                    Newstype nt1 = new Newstype();
                    nt1.Title = "新新闻类型";
                    nt1.Pguid = Guid;
                    nt1.Jingqucode = AppContext.CurrentMgtJingQuCode;
                    nt1.Guid = System.Guid.NewGuid().ToString();
                    nt1.Creator = AppContext.CurrentResuser.Username;
                    nt1.CreateDate = DateTime.Now;
                    nt1.LasteUpdateBy = AppContext.CurrentResuser.Username;
                    nt1.LasteUpdateDate = DateTime.Now;
                    NewstypeBLL.GetInstance().Insert(nt1);
                  
                    RadTree1.SelectedNode.AddNode(rt1);
                    GenerateTreeView();
                    break;
            }
            ReNewCache();
        }

        private void GenerateTreeView()
        {
            RadTree1.Nodes.Clear();
            //NewsTypeQuery query = new NewsTypeQuery();
            //query.Licd = AppContext.LCID;
            //query.CreateBy = AppContext.CurrentAdministrator.UserName;
            DataTable dt = NewstypeBLL.GetInstance().GetNewsTypeList();

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

            Newstype n = new Newstype();
            if (SerId.Value != string.Empty)
            {
                n = NewstypeBLL.GetInstance().GetNewstypeByguid(SerId.Value);
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
