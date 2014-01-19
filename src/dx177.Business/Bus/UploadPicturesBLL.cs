using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MutiPictureUpload.Interface;
using dx177.Model.Bus;
using System.IO;
using dx177.Model;
using dx177.FrameWork;

namespace dx177.Business.Bus
{
    public class UploadPicturesBLL : IMultiPictures
    {
        #region IMultiPictures Members

        public PictureEntity DeleteByPictureId(int PictureId)
        {
            Picturelist p = PicturelistBLL.GetInstance().Get(new Picturelist.Key(PictureId));

            if (p != null)
            {
                if (p.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(p.Bigimgfile)))
                {
                    File.Delete(System.Web.HttpContext.Current.Server.MapPath(p.Bigimgfile));
                }

                if (p.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(Get100pxPath(p.Bigimgfile))))
                {
                    File.Delete(System.Web.HttpContext.Current.Server.MapPath(Get100pxPath(p.Bigimgfile)));
                }

                if (p.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(Get300pxPath(p.Bigimgfile))))
                {
                    File.Delete(System.Web.HttpContext.Current.Server.MapPath(Get300pxPath(p.Bigimgfile)));
                }

                if (p.Bigimgfile != string.Empty && File.Exists(System.Web.HttpContext.Current.Server.MapPath(Get600pxPath(p.Bigimgfile))))
                {
                    File.Delete(System.Web.HttpContext.Current.Server.MapPath(Get600pxPath(p.Bigimgfile)));
                } 

                PicturelistBLL.GetInstance().Delete(PictureId);
            }

            PictureEntity pe = new PictureEntity();
            pe.Description = p.Descprition;
            pe.Title = p.Title;
            pe.TableIdentityId = p.Pguid;
            pe.ShowSmaillPath = p.Smallimgfile;
            pe.ShowBigPath = p.Smallimgfile;
            pe.ShowIndex = p.Showidx;
            pe.Title = p.Title;

            return pe;
        }

        public List<PictureEntity> GetListBy(string module, string tableIdentityId)
        {
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(tableIdentityId);

            List<PictureEntity> res = new List<PictureEntity>();
           
            foreach (Picturelist tmp in dd)
            {
                PictureEntity pe = new PictureEntity();
                pe.Module = module;
                pe.TableIdentityId = tableIdentityId;
                pe.ShowSmaillPath = tmp.Smallimgfile;
                pe.ShowBigPath = tmp.Bigimgfile;
                pe.ShowIndex = tmp.Showidx;
                pe.Title = tmp.Title;
                pe.PictureId = tmp.Seqno;
                pe.Description = tmp.Descprition;                
                res.Add(pe);
            }
            return res;
             
        }
 
        public bool UpdateSort(List<int> listPictureIds)
        {
            int idx = 0;
            foreach (int id in listPictureIds)
            {
                Picturelist p = PicturelistBLL.GetInstance().Get(new Picturelist.Key(id));
                
                string creator = string.Empty;
                if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()] != null)
                {
                    creator = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()].Value;
                }

                p.Creator = string.IsNullOrEmpty(p.Creator) ? creator : p.Creator;
                string jingQuCode = string.Empty;

                if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()] != null)
                {
                    jingQuCode = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()].Value;
                }
                p.Jingqucode = jingQuCode;
                p.Showidx = idx;
                idx++;
                PicturelistBLL.GetInstance().Submit(p);
            }
            return true;
        }

        #endregion

        #region IMultiPictures Members


        public PictureEntity GetByPictureId(int PictureId)
        {
            Picturelist p = PicturelistBLL.GetInstance().Get(new Picturelist.Key(PictureId));

            PictureEntity pe = new PictureEntity();
            pe.Description = p.Descprition;
            pe.Title = p.Title;
            pe.PictureId = PictureId;
            pe.TableIdentityId = p.Pguid;
            pe.ShowSmaillPath = p.Smallimgfile;
            pe.ShowBigPath = p.Smallimgfile;
            pe.ShowIndex = p.Showidx;
            pe.Title = p.Title;

            return pe;
        }

        #endregion

        #region IMultiPictures Members


        public PictureEntity Insert(PictureEntity pic, System.Web.HttpPostedFile file, string uploadFoder)
        {

            string saveComputerFolder = string.Empty;
            uploadFoder = Path.Combine(uploadFoder, pic.Module);
            uploadFoder = Path.Combine(uploadFoder, pic.TableIdentityId).Replace("\\", "/");
            saveComputerFolder = System.Web.HttpContext.Current.Server.MapPath(uploadFoder);
            
            //创建文件夹
            if (!Directory.Exists(saveComputerFolder))
                Directory.CreateDirectory(saveComputerFolder);


            // new file name
            string filename = GetFileName(saveComputerFolder, file.FileName, 0);

            string SaveComputerPath = Path.Combine(saveComputerFolder, filename);
            
            //保存文件
            file.SaveAs(SaveComputerPath);

            // save 100px imgage            
            string small300px = Get300pxPath(filename);
            DoImage.MakeSPic(300, 300, SaveComputerPath, Path.Combine(saveComputerFolder, small300px));
            string small600px = Get600pxPath(filename);
            DoImage.MakeSPic(600, 600, SaveComputerPath, Path.Combine(saveComputerFolder, small600px));

            //图片页面访问路径            
            pic.SaveComputerPath = SaveComputerPath;
            pic.ShowBigPath = Path.Combine(uploadFoder, small600px).Replace("\\", "/");
            pic.ShowSmaillPath = Path.Combine(uploadFoder, small300px).Replace("\\", "/"); 


            Picturelist plis = new Picturelist();
            FileInfo fi = new FileInfo(filename);
            pic.Title = fi.Name.Replace(fi.Extension, "");
            pic.Description = string.Empty;
            IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(pic.TableIdentityId);
            pic.ShowIndex = dd.Count;

            string creator = string.Empty;
            if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()] != null)
            {
                creator = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()].Value;
            }
            plis.Creator = string.IsNullOrEmpty(plis.Creator) ? creator : plis.Creator;
            string jingQuCode = string.Empty;

            if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()] != null)
            {
                jingQuCode = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()].Value;
            }

            plis.Pguid = pic.TableIdentityId;
            plis.Showidx = pic.ShowIndex;
            plis.Smallimgfile = Path.Combine(uploadFoder, small300px).Replace("\\", "/");
            plis.Bigimgfile = Path.Combine(uploadFoder, filename).Replace("\\", "/");
            plis.Title = pic.Title;
            plis.Seqno = pic.PictureId;
            plis.Descprition = pic.Description;
            plis.Jingqucode = jingQuCode;
            PicturelistBLL.GetInstance().Submit(plis);
            pic.PictureId = plis.Seqno;

            return pic;
        }

        public PictureEntity UpdateDesc(PictureEntity pic)
        {
            Picturelist plis = null;
            if (pic.PictureId == 0)
            {
                plis = new Picturelist();
                FileInfo fi = new FileInfo(pic.ShowSmaillPath);
                pic.Title = fi.Name;
                pic.Description = string.Empty;
                IList<Picturelist> dd = PicturelistBLL.GetInstance().GetPicsByGuid(pic.TableIdentityId);
                pic.ShowIndex = dd.Count;

            }
            else
            {
                plis = PicturelistBLL.GetInstance().Get(new Picturelist.Key(pic.PictureId));
            }

            string creator = string.Empty;
            if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()] != null)
            {
                creator = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminUserName.ToString()].Value;
            }
            plis.Creator = string.IsNullOrEmpty(plis.Creator) ? creator : plis.Creator;
            string jingQuCode = string.Empty;

            if (System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()] != null)
            {
                jingQuCode = System.Web.HttpContext.Current.Request.Cookies[CookieName.CurrentAdminJingQuCode.ToString()].Value;
            }

            plis.Pguid = pic.TableIdentityId;
            plis.Showidx = pic.ShowIndex;
            plis.Smallimgfile = pic.ShowSmaillPath;
            plis.Title = pic.Title;
            plis.Seqno = pic.PictureId;
            plis.Descprition = pic.Description;
            plis.Jingqucode = jingQuCode;
            PicturelistBLL.GetInstance().Submit(plis);
            pic.PictureId = plis.Seqno;
            return pic;
        }

        public static string Get100pxPath(string originalName)
        {
            if (string.IsNullOrEmpty(originalName))
                return originalName;
            FileInfo fi = new FileInfo(originalName);
            return originalName.Replace(fi.Name, fi.Name.Replace(fi.Extension, "") + "_100px" + fi.Extension);
        }

        public static string Get300pxPath(string originalName)
        {

            if (string.IsNullOrEmpty(originalName))
                return originalName;
            FileInfo fi = new FileInfo(originalName);
            return originalName.Replace(fi.Name, fi.Name.Replace(fi.Extension, "") + "_300px" + fi.Extension);
        }

        public static string Get600pxPath(string originalName)
        {
            if (string.IsNullOrEmpty(originalName))
                return originalName;
            FileInfo fi = new FileInfo(originalName);
            return originalName.Replace(fi.Name, fi.Name.Replace(fi.Extension, "") + "_600px" + fi.Extension);
        }

        /// <summary>
        /// 存在的情况下，名字加1
        /// </summary>
        /// <param name="pathfolder"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string GetFileName(string pathfolder, string filename, int iname)
        {
            string filefullname = string.Empty;
            string wondername = filename;
            if (iname == 0)
            {
                filefullname = Path.Combine(pathfolder, filename);

            }
            else
            {
                FileInfo fi = new FileInfo(filename);
                string name = fi.Name.Replace(fi.Extension, "");
                wondername = name + "_" + iname.ToString() + fi.Extension;
                filefullname = Path.Combine(pathfolder, wondername);
            }


            if (File.Exists(filefullname))
            {
                iname++;
                return GetFileName(pathfolder, filename, iname);
            }
            else
            {
                return wondername;
            }
        }

        #endregion
    }
}
