using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPaint.Classes
{
    class RastrSaveHelper 
    {
        private static RastrSaveHelper _saveLoad;
        private Storage _storage;

        string filter = "Image Files(*.JSON)|*.JSON|Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
        private RastrSaveHelper()
        {
            _storage = Storage.Create();
        }

        public static RastrSaveHelper Create()
        {
            if (_saveLoad == null)
            {
                _saveLoad = new RastrSaveHelper();
            }
            return _saveLoad;
        }

        public object Load()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.FileName = "";
            f.ShowDialog();
            object res;

            if (f.FileName != "")
            {
                if (f.FileName.Split('.')[f.FileName.Split('.').Length-1]=="JSON"|| f.FileName.Split('.')[f.FileName.Split('.').Length - 1] == "json")
                {
                    res =  f.FileName;
                }   
                else
                {
                    throw new ArgumentNullException();
                }
              
            }
            else
            {
                
                throw new ArgumentNullException();
            }
            return res;
        }

    
        public void Save(Image img)
        {
           

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Us";
            save.OverwritePrompt = true;
            save.CheckPathExists = true;

            save.Filter = filter;
            save.ShowHelp = true;
            var result = save.ShowDialog();
            if (result == DialogResult.OK  && save.FilterIndex!=1)
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
            else if (result == DialogResult.OK && save.FilterIndex == 1)
            {
                try
                {
                    MyJsonSerializer.Serialize_(_storage.GetCurrentList(), save.FileName);
                    
                }
                catch
                {
                    MessageBox.Show("Image cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        
           
        }
    }
}
