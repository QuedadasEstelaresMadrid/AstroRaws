
namespace AstroRaws
{
    partial class preview
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.metaText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.metaText);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previewBox);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(584, 361);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.Black;
            this.previewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewBox.Location = new System.Drawing.Point(0, 0);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(280, 361);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // metaText
            // 
            this.metaText.BackColor = System.Drawing.Color.White;
            this.metaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metaText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metaText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metaText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.metaText.Location = new System.Drawing.Point(0, 0);
            this.metaText.Multiline = true;
            this.metaText.Name = "metaText";
            this.metaText.ReadOnly = true;
            this.metaText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.metaText.Size = new System.Drawing.Size(300, 361);
            this.metaText.TabIndex = 0;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preview";
            this.Load += new System.EventHandler(this.preview_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.TextBox metaText;
    }
}