﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace AstroRaws
{
    public partial class packcomp : Form
    {
        List<string> lights_list = new List<string>();
        List<string> darks_list  = new List<string>();
        List<string> bias_list   = new List<string>();
        List<string> flats_list  = new List<string>();
        List<string> tiffs_list  = new List<string>();
        List<string> final_list  = new List<string>();


        public packcomp()
        {
            InitializeComponent();
            string path = @"C:\Users\deept\Pictures"; //TODO esto fuera, obtener usuario
            PopulateTreeView(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateTreeView(string path)
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(path);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                };

                item.SubItems.AddRange(subItems);

                item.Tag = dir.FullName.ToString();

                listView1.Items.Add(item);
            }

   

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);

                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                    new ListViewItem.ListViewSubItem(item, BytesToString(file.Length).ToString()),
                    new ListViewItem.ListViewSubItem(item, file.FullName.ToString())
                    
                };

                item.SubItems.AddRange(subItems);

                item.Tag = file.FullName.ToString();

                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void viewlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string ee in this.lights_list)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                treeView1.Nodes.Clear();
                PopulateTreeView(folderBrowserDialog1.SelectedPath);
            }
        }

        private void lightsBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lightfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in lightfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.lights_list.Contains(fileName))
                        {
                            this.lights_list.Add(fileName);
                        }
                    }
                }
                
                else
                {
                    if (!this.lights_list.Contains(item.Tag.ToString()))
                    {
                        this.lights_list.Add(item.Tag.ToString());
                    }
                }

            }

            lightscounterStatusLabel2.Text = this.lights_list.Count.ToString();
        }

        private void darksBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection darkfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in darkfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.darks_list.Contains(fileName))
                        {
                            this.darks_list.Add(fileName);
                        }
                    }
                }

                else
                {
                    if (!this.darks_list.Contains(item.Tag.ToString()))
                    {
                        this.darks_list.Add(item.Tag.ToString());
                    }
                }

            }

            darkscounterStatusLabel4.Text = this.darks_list.Count.ToString();
        }

        private void biasBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection biasfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in biasfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.bias_list.Contains(fileName))
                        {
                            this.bias_list.Add(fileName);
                        }
                    }
                }

                else
                {
                    if (!this.bias_list.Contains(item.Tag.ToString()))
                    {
                        this.bias_list.Add(item.Tag.ToString());
                    }
                }

            }

            biascounterStatusLabel6.Text = this.bias_list.Count.ToString();
        }

        private void flatsBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection flatsfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in flatsfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.flats_list.Contains(fileName))
                        {
                            this.flats_list.Add(fileName);
                        }
                    }
                }

                else
                {
                    if (!this.flats_list.Contains(item.Tag.ToString()))
                    {
                        this.flats_list.Add(item.Tag.ToString());
                    }
                }

            }

            flatscounterStatusLabel8.Text = this.flats_list.Count.ToString();
        }

        private void tiffBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection tiffsfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in tiffsfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.tiffs_list.Contains(fileName))
                        {
                            this.tiffs_list.Add(fileName);
                        }
                    }
                }

                else
                {
                    if (!this.tiffs_list.Contains(item.Tag.ToString()))
                    {
                        this.tiffs_list.Add(item.Tag.ToString());
                    }
                }

            }

            extracounterStatusLabel10.Text = (this.tiffs_list.Count + this.final_list.Count).ToString();
        }

        private void finalBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection finalfiles = this.listView1.SelectedItems;

            foreach (ListViewItem item in finalfiles)
            {
                FileAttributes attr = File.GetAttributes(item.Tag.ToString());

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string[] fileEntries = Directory.GetFiles(item.Tag.ToString());
                    foreach (string fileName in fileEntries)
                    {
                        if (!this.final_list.Contains(fileName))
                        {
                            this.final_list.Add(fileName);
                        }
                    }
                }

                else
                {
                    if (!this.final_list.Contains(item.Tag.ToString()))
                    {
                        this.final_list.Add(item.Tag.ToString());
                    }
                }

            }

            extracounterStatusLabel10.Text = (this.tiffs_list.Count + this.final_list.Count).ToString();
        }


        //métodos auxiliares
        private static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };

            if (byteCount == 0) return "0" + suf[0];

            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);

            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }
    }
}
