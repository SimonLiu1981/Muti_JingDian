using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace dx177.FrameWork
{
    
    public class PictureSizeW600 : PictureSize
    {

        public override int With
        {
            get
            {
                return 600;
            }
        }
    }

    public class PictureSizeW320 : PictureSize
    {
        public override int With
        {
            get
            {
                return 320;
            }
        }
    }

    public class PictureSizeW160 : PictureSize
    {
        public override int With
        {
            get
            {
                return 160;
            }
        }
    }
    public abstract class PictureSize
    {
        public abstract int With { get; }
        public int Height
        {
            get
            {
                return (int)(With * Ratio);
            }
        }

        protected double Ratio = 0.75;

    }
    public static class DoImage
    {

        private static string GetNewPictureName(string sourcePictureName, PictureSize psize)
        {
            FileInfo fi = new FileInfo(sourcePictureName);
            return fi.DirectoryName + string.Format("{0}x{1}_{2}", psize.With, psize.Height, fi.Name);
        }


        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        /// <returns>
        /// 图片的新地址
        /// </returns>
        public static string MakeThumbnail(string originalImagePath, PictureSize psize)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = psize.With;
            int toheight = psize.Height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
            {
                oh = originalImage.Height;
                ow = originalImage.Height * towidth / toheight;
                y = 0;
                x = (originalImage.Width - ow) / 2;
            }
            else
            {
                ow = originalImage.Width;
                oh = originalImage.Width * toheight / towidth;
                x = 0;
                y = (originalImage.Height - oh) / 2;
            }

            if (oh < toheight)
            {
                toheight = oh;
                towidth = ow;
            }

            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);
            try
            {
                string thumbnailPath = GetNewPictureName(originalImagePath, psize);
                //以jpg格式保存缩略图
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return thumbnailPath;
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }


        /// <summary>
        /// 生产固定大小的图片。
        /// </summary>
        /// <param name="Width">生产后的图片宽度</param>
        /// <param name="Height">生产后的图片高度</param>
        /// <param name="originalFilename">原图片的路径</param>
        /// <param name="strNewFile">生产后的图片路径</param>
        public static void MakeSPic(int Width, int Height, string originalFilename, string strNewFile)
        {
            //生成的低质量图片名称   
            //缩小的倍数   

            //从文件取得图片对象   
            System.Drawing.Image image = System.Drawing.Image.FromFile(originalFilename);
            //image.Size.Height

            System.Double NewWidth, NewHeight;
            if (image.Width > image.Height)
            {
                if (image.Width > Width)
                {
                    NewWidth = Width;
                    NewHeight = image.Height * (NewWidth / image.Width);
                }
                else
                {
                    NewWidth = image.Width;
                    NewHeight = image.Height;
                }
            }
            else
            {
                if (image.Height > Height)
                {

                    NewHeight = Height;
                    NewWidth = (NewHeight / image.Height) * image.Width;
                }
                else
                {
                    NewWidth = image.Width;
                    NewHeight = image.Height;
                }
            }

            if (NewWidth > Width)
            {
                NewWidth = Width;
            }

            if (NewHeight > Height)
            {
                NewHeight = Height;
            }

            //取得图片大小   
            System.Drawing.Size size = new System.Drawing.Size((int)NewWidth, (int)NewHeight);
            //新建一个bmp图片   
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(size.Width, size.Height);
            //新建一个画板   
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法   
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度   
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空一下画布   
            g.Clear(System.Drawing.Color.White);
            //在指定位置画图   
            g.DrawImage(image, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height),
                new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                System.Drawing.GraphicsUnit.Pixel);

            //保存高清晰度的缩略图   
            if (originalFilename.IndexOf("jpg") > -1)
            {
                bitmap.Save(strNewFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            //else if (originalFilename.IndexOf("gif") > -1)
            //{
            //    bitmap.Save(strNewFile, System.Drawing.Imaging.ImageFormat.Gif);
            //}
            else
            {
                bitmap.Save(strNewFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            image.Dispose();
            bitmap.Dispose();
            g.Dispose();

        }
    }
}
