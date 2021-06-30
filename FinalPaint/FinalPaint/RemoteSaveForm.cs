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
            try
            {
                bl.SaveServer(name, type);
                MessageBox.Show("Picture saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Picture save failed with "+ex.Message);
            }
            
          
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoteSaveForm_Load(object sender, EventArgs e)
        {
            comboBoxFormat.SelectedIndex = 0;
        }
    }
}
