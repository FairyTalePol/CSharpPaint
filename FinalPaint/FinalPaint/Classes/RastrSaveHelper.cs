using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class RastrSaveHelper
    {
        private static RastrSaveHelper _saveLoad;

        private RastrSaveHelper()
        {

        }

        public static RastrSaveHelper Create()
        {
            if (_saveLoad == null)
            {
                _saveLoad = new RastrSaveHelper();
            }
            return _saveLoad;
        }

        public void Load(ref OpenFileDialog f,ref Graphics g,ref Bitmap b,ref PictureBox p)
        {

            f.ShowDialog();
            if (f.FileName != "openFileDialog1")
            {
                b = new Bitmap(f.FileName);
                p.Image = b;
                g = Graphics.FromImage(p.Image);
            }
        }

        public void Save(ref PictureBox p)
        {

            if (p.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save Us";
                save.OverwritePrompt = true;
                save.CheckPathExists = true;

                save.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                save.ShowHelp = true;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        p.Image.Save(save.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Image cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
