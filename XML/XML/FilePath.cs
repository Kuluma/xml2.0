using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML.XML
{
    class FilePath
    {
        public static List<string> File_Path = new List<string>();
        int FilesCount = 0;
        public static string filePath;


        public DirectoryInfo DirPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               filePath = dialog.SelectedPath;
            }
                
                //MessageBox.Show("已选择文件夹:" + PublicValue.FilePath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DirectoryInfo SelectedPath = new DirectoryInfo(dialog.SelectedPath);
                return SelectedPath;
            
            
        }
        



    public int GetFilePath(DirectoryInfo dirInfo)
        {
            int totalFile = 0;
            
            totalFile += dirInfo.GetDirectories().Length;
            FileInfo[] listdir =  dirInfo.GetFiles();//获取文件夹名称
            foreach (var item in listdir)
            {
                File_Path.Add(item.ToString());
            }

            //FileInfo[] listfile = dirInfo.GetFiles();
            //foreach (DirectoryInfo subdir in dirInfo.GetDirectories())
            //{
            //    totalFile += GetFilesCount(subdir);
            //}
            FilesCount = totalFile;
            return totalFile;
        }
    }
}
