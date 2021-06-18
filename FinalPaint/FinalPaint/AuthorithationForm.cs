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
        private static AuthorithationForm _authorithationForm;
        private AuthorithationForm()
        {
            InitializeComponent();
           
        }
        public static AuthorithationForm CreateAuthorithationForm()
        {
            if (_authorithationForm == null)
            {
                _authorithationForm = new AuthorithationForm();
            }
            return _authorithationForm;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            if (password_textBox.Text == password && login_textBox.Text == login)
            {
                DefaultBackGround();
                _authorithationForm.Hide();
                MainForm.CreateMainForm().Show();

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
            password_textBox.BackColor = Color.LightGray;
            login_textBox.BackColor = Color.LightGray;
            password_textBox.Text = null;
            login_textBox.Text = null;
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm.CreateRegistrationForm().Show();
            DefaultBackGround();
            
        }
    }
}
