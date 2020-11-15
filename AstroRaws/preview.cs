using MetadataExtractor;
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

namespace AstroRaws
{
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        private void preview_Load(object sender, EventArgs e)
        {
            this.Text = this.Tag.ToString();

            List<string> imgformats = new List<string>();
            imgformats.Add(".jpg"); imgformats.Add(".jpeg");
            imgformats.Add(".png"); imgformats.Add(".tiff");
            imgformats.Add(".exif");

            string extension = Path.GetExtension(this.Tag.ToString());

            //if si es imagen
            if (imgformats.Contains(extension.ToLower()))
            {
                previewBox.ImageLocation = this.Tag.ToString();

                var directories = ImageMetadataReader.ReadMetadata(this.Tag.ToString());
                string meta = "";

                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        meta = meta + $"{directory.Name} - {tag.Name} = {tag.Description}" + Environment.NewLine;
                    }
                }

                metaText.Text = meta;
            }

            else
            {
                //TODO implementar visor video y archivos texto
            }
            
        }
    }
}
