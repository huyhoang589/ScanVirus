using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using System.IO;
using System.Text.RegularExpressions;

namespace HoangPasoLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sInputFIlename, sFolderPath;
        List<DataBase> lDB = new List<DataBase>();

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            if (oDlgDB.ShowDialog() == DialogResult.OK)
                sInputFIlename = oDlgDB.FileName;
            txtOpenDB.Text = oDlgDB.FileName;
        }


        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            listViewDB.Items.Clear();
            
            StreamReader reader = File.OpenText(sInputFIlename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                int startLine = line.IndexOf("[");
                int endLine = line.IndexOf("]");
                int split = line.IndexOf("=");

                string name = line.Substring(startLine + 1, split - startLine - 1);
                string value = line.Substring(split + 1, endLine - split - 1);

                DataBase data = new DataBase();
                data.set_Name(name);
                data.set_Value(value);
                data.set_Mask(value);
                lDB.Add(data);

                ListViewItem item = new ListViewItem(data.get_Name());
                item.SubItems.Add(value);
                listViewDB.Items.Add(item);

            }
            int number = lDB.Count;

            labelCount.Text = "Сигнатур: " + number.ToString() + " шт.";

        }

        private void btnOpenFolderScan_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogScan.ShowDialog() == DialogResult.OK)
                sFolderPath = folderBrowserDialogScan.SelectedPath;
            txtScan.Text = folderBrowserDialogScan.SelectedPath;
        }

        private void btnDoScan_Click(object sender, EventArgs e)
        {
            listViewScan.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(sFolderPath);
            FileInfo[] fileInfo = dirInfo.GetFiles();
            
            foreach (FileInfo fi in fileInfo)
            {
                FileStream fStream = new FileStream(fi.FullName, FileMode.Open);
                BinaryReader bread = new BinaryReader(fStream);

                byte[] temp_file = bread.ReadBytes((int)fStream.Length);
                fStream.Close();
                bread.Close();
                                
                Signature s = new Signature();
                s.set_File(temp_file);
                
                int count = 0;
                for (int i = 0; i < lDB.Count; i++)
                {
                    s.set_Mask(lDB[i].get_Mask());
                    s.set_Value(lDB[i].get_Value());
                    bool checkSign = s.getCheckSign();
                    
                    if (checkSign == true)
                    {
                        ListViewItem item = new ListViewItem(fi.Name);
                        item.SubItems.Add(lDB[i].get_Name());
                        listViewScan.Items.Add(item);
                        count = count + 1;
                    }
                 }

                if (count == 0)
                {
                    ListViewItem item = new ListViewItem(fi.Name);
                    item.SubItems.Add("чистый файл");
                    listViewScan.Items.Add(item);
                }


            }
        }

    }
}

