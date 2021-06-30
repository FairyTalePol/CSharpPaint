using FinalPaint.Classes;
using FinalPaint.Interfaces_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPaint
{
    public partial class GetPicturesList : Form
    {
        IBuisnessLogic bl;
        List<PictureData> pictures;
        public GetPicturesList()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetPicturesList_Load(object sender, EventArgs e)
        {
            bl = BuisnessLogic.Create();
            pictures = bl.GetAllPictures();
            foreach (PictureData p in pictures)
            {
                listBoxPictures.Items.Add(p.Name);
            }
            listBoxPictures.SelectedIndex = 0;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            bl.ChoosePictureLoad(pictures.ElementAt(listBoxPictures.SelectedIndex));
            this.Close();
        }
    }
}
