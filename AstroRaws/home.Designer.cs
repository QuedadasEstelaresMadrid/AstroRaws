
namespace AstroRaws
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.footLbl = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.makeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.localBtn = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.footLbl);
            this.splitContainer1.Panel1.Controls.Add(this.helpBtn);
            this.splitContainer1.Panel1.Controls.Add(this.confBtn);
            this.splitContainer1.Panel1.Controls.Add(this.makeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.localBtn);
            this.splitContainer1.Panel1.Controls.Add(this.logoBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(684, 408);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // footLbl
            // 
            this.footLbl.AutoSize = true;
            this.footLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footLbl.ForeColor = System.Drawing.Color.White;
            this.footLbl.Location = new System.Drawing.Point(0, 395);
            this.footLbl.Name = "footLbl";
            this.footLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.footLbl.Size = new System.Drawing.Size(60, 13);
            this.footLbl.TabIndex = 6;
            this.footLbl.Text = "Version 1";
            this.footLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.White;
            this.helpBtn.Location = new System.Drawing.Point(0, 339);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(228, 48);
            this.helpBtn.TabIndex = 5;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.confBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.White;
            this.confBtn.Location = new System.Drawing.Point(0, 291);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(228, 48);
            this.confBtn.TabIndex = 4;
            this.confBtn.Text = "Config";
            this.confBtn.UseVisualStyleBackColor = false;
            // 
            // makeBtn
            // 
            this.makeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.makeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.makeBtn.FlatAppearance.BorderSize = 0;
            this.makeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBtn.ForeColor = System.Drawing.Color.White;
            this.makeBtn.Location = new System.Drawing.Point(0, 243);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(228, 48);
            this.makeBtn.TabIndex = 3;
            this.makeBtn.Text = "Create package";
            this.makeBtn.UseVisualStyleBackColor = false;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Community";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // localBtn
            // 
            this.localBtn.BackColor = System.Drawing.Color.White;
            this.localBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.localBtn.FlatAppearance.BorderSize = 0;
            this.localBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.localBtn.Location = new System.Drawing.Point(0, 147);
            this.localBtn.Name = "localBtn";
            this.localBtn.Size = new System.Drawing.Size(228, 48);
            this.localBtn.TabIndex = 0;
            this.localBtn.Text = "My library";
            this.localBtn.UseVisualStyleBackColor = false;
            this.localBtn.Click += new System.EventHandler(this.packBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(228, 147);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 408);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 408);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(600, 447);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstroRaws";
            this.Load += new System.EventHandler(this.home_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button localBtn;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Label footLbl;
        private System.Windows.Forms.ListView listView1;
    }
}