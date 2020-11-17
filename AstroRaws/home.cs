using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;


namespace AstroRaws
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            check_install();
            splitContainer1.Size = new Size(200, 200);
            get_files();
        }

        private void get_files()
        {
            listView2.Items.Clear();

            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            DirectoryInfo nodeDirInfo = new DirectoryInfo(@"C:\Users\deept\source\repos\AstroRaws\AstroRaws\bin\Debug");

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                if (file.Extension == ".arpack")
                {
                    item = new ListViewItem(file.Name, 1);

                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                    new ListViewItem.ListViewSubItem(item, file.FullName.ToString())

                    };

                    item.SubItems.AddRange(subItems);

                    item.Tag = file.FullName.ToString();
                    item.ImageIndex = 0;

                    listView2.Items.Add(item);
                }
            }

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void check_install()
        {
            string path = Directory.GetCurrentDirectory();

            //temp dir
            if (!Directory.Exists(path + @"\tmp"))
            {
                DirectoryInfo tmppack = Directory.CreateDirectory(path + @"\tmp");
            }

            //db dir
            if (!Directory.Exists(path + @"\db"))
            {
                DirectoryInfo tmppack = Directory.CreateDirectory(path + @"\db");
            }

            //db file
            if (!File.Exists(path + @"\db\ardb.sqlite"))
            {
                SQLiteConnection.CreateFile(path + @"\db\ardb.sqlite");
                install_db();
            }
            

            //descargar dependencias 7z
        }

        private void install_db()
        {
            string dbpath = Directory.GetCurrentDirectory() + @"\db\ardb.sqlite";

            SQLiteConnection dbcon = new SQLiteConnection("Data Source="+dbpath+";Version=3;");

            dbcon.Open();
            string sql = "create table profiles (name varchar(20), score int)";


        }

        private void packBtn_Click(object sender, EventArgs e)
        {

        }

        private void makeBtn_Click(object sender, EventArgs e)
        {
            packcomp pc = new packcomp();
            pc.Show();
        }


        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView2.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void getfilesMenuItem2_Click(object sender, EventArgs e)
        {
            get_files();
        }
    }
}
