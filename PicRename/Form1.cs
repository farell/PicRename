using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicRename
{
    public partial class Form1 : Form
    {
        public string rootPath;
        public FileInfo[] dirInfo;
        public int index;
        public int count;
        public int[] index_array;
        public Form1()
        {
            InitializeComponent();
            index = 0;
        }

        private void buttonOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                labelPath.Text = foldPath;
                rootPath = foldPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                dirInfo = theFolder.GetFiles();
                string filepath = rootPath + "\\" + dirInfo[index].ToString();
                System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);
                System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
                pictureBox1.Image = bmp;
                img.Dispose();
                labelPic.Text = dirInfo[0].ToString();
                count = dirInfo.Length;
                index = 0;
                index_array = new int[6] { 0,0,0,0,0,0};
                /*遍历文件夹
                foreach (FileInfo file in dirInfo)
                {
                    MessageBox.Show(file.ToString());
                }*/
            }

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (dirInfo.Length < 1)
            {
                return;
            }
            if (index > 0)
            {
                index--;
                string filepath = rootPath + "\\" + dirInfo[index].ToString();
                System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);
                System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
                pictureBox1.Image = bmp;
                //pictureBox1.Load(rootPath + "\\" + dirInfo[index].ToString());
                img.Dispose();
                labelPic.Text = dirInfo[index].ToString();
            }
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (dirInfo.Length < 1)
            {
                return;
            }
            if (index <count)
            {
                if (index < count - 1)
                {
                    index++;
                    string filepath = rootPath + "\\" + dirInfo[index].ToString();
                    System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);
                    System.Drawing.Image bmp = new System.Drawing.Bitmap(img);
                    pictureBox1.Image = bmp;
                    img.Dispose();
                    labelPic.Text = dirInfo[index].ToString();
                }
                
            }
        }

        private void button711_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[0]++;
            string newFileName = rootPath + "\\" + "便利店"+index_array[0]+".jpg";
            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[1]++;
            string newFileName = rootPath + "\\" + "餐饮店" + index_array[1] + ".jpg";
            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }

        private void buttonSuper_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[2]++;
            string newFileName = rootPath + "\\" + "超市" + index_array[2] + ".jpg";
            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[3]++;
            string newFileName = rootPath + "\\" + "加油站" + index_array[3] + ".jpg";

            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }

        private void buttonPark_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[4]++;
            string newFileName = rootPath + "\\" + "停车区" + index_array[4] + ".jpg";
            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }

        private void buttonRestroom_Click(object sender, EventArgs e)
        {
            string oldFileName = rootPath + "\\" + dirInfo[index].ToString();
            index_array[5]++;
            string newFileName = rootPath + "\\" + "卫生间" + index_array[5] + ".jpg";
            if (Directory.Exists(newFileName))
            {
                MessageBox.Show(newFileName + " 已经存在！");
                return;
            }
            labelPic.Text = newFileName;
            File.Move(oldFileName, newFileName);
            File.Delete(oldFileName);
            dirInfo[index] = new FileInfo(newFileName);
        }
    }
}
