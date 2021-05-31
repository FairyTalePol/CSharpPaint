﻿using FinalPaint.Interfaces_;
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

        string filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
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

        public Image Load()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.FileName = "";
            f.ShowDialog();
            Bitmap res;

            if (f.FileName != "")
            {
                res = new Bitmap(f.FileName);

       

            }
            else
            {
                throw new ArgumentNullException();
            }
            return res;
        }

        public void Save(Image img)
        {

            if (img != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save Us";
                save.OverwritePrompt = true;
                save.CheckPathExists = true;

                save.Filter = filter;
                save.ShowHelp = true;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        img.Save(save.FileName);
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
