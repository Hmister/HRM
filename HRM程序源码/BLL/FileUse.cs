using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace BLL
{
    /// <summary>
    /// 文件操作
    /// </summary>
    public class FileUse
    {
        /// <summary>
        /// 自定义图片本地化操作
        /// </summary>
        /// <param name="fromPath"></param>
        /// <returns></returns>
        public static string LocalLogo(string fromPath)
        {
            //目标路径
            string toPath =  @"Source\User\";
            //统计目录下文件总数
            int count=0;
            count = Directory.GetFiles(toPath, "*.*", SearchOption.AllDirectories).Length;

            //规范文件名
            string newName = (count + 1).ToString() + ".png";
            //为系统内文件重命名
            //复制图片
            File.Copy(fromPath, toPath+newName);
            return (count+1).ToString();
        }

        /// <summary>
        /// 自定义照片本地化操作
        /// </summary>
        /// <param name="fromPath"></param>
        /// <returns></returns>
        public static string LocalPic(string fromPath)
        {
            //目标路径
            string toPath = Directory.GetCurrentDirectory() + @"\Person\";
            //统计目录下文件总数
            int count = 0;
            count = Directory.GetFiles(toPath, "*.*", SearchOption.AllDirectories).Length;

            //规范文件名
            string newName = (count + 11000).ToString() + ".jpg";
            //为系统内文件重命名
            //复制图片
            File.Copy(fromPath, toPath + newName);
            return (count + 11000).ToString();
        }


        /// <summary>
        /// 保存邮件主配置
        /// </summary>
        /// <returns></returns>
        public static void SaveMailSet(Entity.Mail mail,string name)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory()+@"\Config\" +name+".XML", FileMode.OpenOrCreate,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, mail);
            fs.Close();
        }


        /// <summary>
        /// 读取本地邮件配置
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Entity.Mail OpenMailSet(string name)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory()+@"\Config\" + name + ".XML",FileMode.OpenOrCreate,FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Entity.Mail mail=(Entity.Mail)bf.Deserialize(fs);
            fs.Close();
            return mail;
        }



    }


}
