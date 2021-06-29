using FinalPaint.Classes;
using FinalPaint.DependencyInversion;
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
    public partial class RemoteSaveForm : Form
    {

        MyGraphics _myGraphics;
        BuisnessLogic bl;
        public RemoteSaveForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            PictureType type = (PictureType) Enum.Parse(typeof(PictureType),comboBoxFormat.SelectedItem.ToString());
            bl = BuisnessLogic.Create();
            bl.SaveServer(name, type);
            MessageBox.Show("Картинка успешно сохранена");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
