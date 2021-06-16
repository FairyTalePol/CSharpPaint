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
    public partial class AuthorithationForm : Form
    {
        string password = "0";
        string login = "0";
        public AuthorithationForm()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            if (password_textBox.Text == password && login_textBox.Text == login)
            {
                this.Hide();
                new MainForm().ShowDialog();
                DefaultBackGround();
                this.Show();
            }
            else
            {
                WrongInputMessage();
            }
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void WrongInputMessage()
        {
            message_lbl.Visible = true;
            password_textBox.BackColor = Color.Red;
            login_textBox.BackColor = Color.Red;
        }
        private void DefaultBackGround()
        {
            message_lbl.Visible = false;
            password_textBox.BackColor = Color.LightSteelBlue;
            login_textBox.BackColor = Color.LightSteelBlue;
            password_textBox.Text = null;
            login_textBox.Text = null;
        }
    }
}
