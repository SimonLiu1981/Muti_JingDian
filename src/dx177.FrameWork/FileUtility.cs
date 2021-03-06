﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace dx177.FrameWork
{
    public class FileUtility
    {
        /// <summary>
        /// 遍历创建文件夹
        /// </summary>
        /// <param name="folderPath"></param>
        public static void CreateFolder(string folderPath)
        {
            DirectoryInfo d = new DirectoryInfo(folderPath);
            
            if (!d.Exists)
            {
                d.Create();
            }     
        }
        /// <summary>
        /// 复制文件夹中的所有文件到指定文件夹
        /// </summary>
        /// <param name="DirectoryPath">源文件夹路径</param>
        /// <param name="DirAddress">保存路径</param>
        /// <param name="DirFirst">true保留第一个文件夹目录，false不保留第一个文件夹目录</param>
        public static void CopyDirectory(string DirectoryPath, string DirAddress, bool DirFirst)//复制文件夹，
        {
            CreateFolder(DirectoryPath);
            string s = DirectoryPath.Substring(DirectoryName(DirectoryPath));//获取文件夹名
            DirectoryInfo DirectoryArray = new DirectoryInfo(DirectoryPath);
            FileInfo[] Files = DirectoryArray.GetFiles();//获取该文件夹下的文件列表     
            DirectoryInfo[] Directorys = DirectoryArray.GetDirectories();//获取该文件夹下的文件夹列表 

            if (!DirFirst)
            {
                if (Directory.Exists(DirAddress))
                {
                    //Directory.Delete(DirAddress, true);//若文件夹存在，不管目录是否为空，删除 
                    //Directory.CreateDirectory(DirAddress);//删除后，重新创建文件夹    
                }
                else
                {
                    Directory.CreateDirectory(DirAddress);//文件夹不存在，创建     
                }
                foreach (FileInfo inf in Files)//逐个复制文件     
                {                    
                    File.Copy(DirectoryPath + "\\" + inf.Name, DirAddress + "\\" + inf.Name,true);
                }
                foreach (DirectoryInfo Dir in Directorys)//逐个获取文件夹名称，并递归调用方法本身     
                {
                    CopyDirectory(DirectoryPath + "\\" + Dir.Name, DirAddress, true);
                }
            }
            else
            {
                if (Directory.Exists(DirAddress + "\\" + s))
                {
                    //Directory.Delete(DirAddress + "\\" + s, true);//若文件夹存在，不管目录是否为空，删除 
                    Directory.CreateDirectory(DirAddress + "\\" + s);//删除后，重新创建文件夹    
                }
                else
                {
                    Directory.CreateDirectory(DirAddress + "\\" + s);//文件夹不存在，创建     
                }
                foreach (FileInfo inf in Files)//逐个复制文件     
                {   
                    File.Copy(DirectoryPath + "\\" + inf.Name, DirAddress + "\\" + s + "\\" + inf.Name,true);
                }
                foreach (DirectoryInfo Dir in Directorys)//逐个获取文件夹名称，并递归调用方法本身     
                {
                    CopyDirectory(DirectoryPath + "\\" + Dir.Name, DirAddress + "\\" + s, true);
                }
            }
        }

        /// <summary>
        /// 获取文件夹名称
        /// </summary>
        /// <param name="DirectoryPath">文件夹路径</param>
        /// <returns></returns>
        public static int DirectoryName(string DirectoryPath)//获取文件夹名，截取“\” 
        {
            string path = DirectoryPath;// Globals.GetFilePath(DirectoryPath);
            int j = 0;
            j = DirectoryPath.LastIndexOf("\\");
            return j + 1;
        }

    }
}
