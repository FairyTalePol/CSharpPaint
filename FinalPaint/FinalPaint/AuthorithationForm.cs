using FinalPaint.Classes;
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

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            var bl = BuisnessLogic.Create();
            int validCode = bl.AuthorizationRestApi(login_textBox.Text, password_textBox.Text);
            message_lbl.Text = "Please wait...";
            switch (validCode)
            {
                case 0 :
                    {
                        DefaultBackGround();
                        _authorithationForm.Hide();
                        MainForm.CreateMainForm().Show();
                        break;
                    }
                case -1:
                    {
                        message_lbl.Text = "Incorrect input or no such user";
                        WrongInputMessage();
                        break;
                    }
                case -2:
                    {
                        message_lbl.Text = "No response from server";
                        WrongInputMessage();
                        break;
                    }
            }
          
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void WrongInputMessage()
        {
            message_lbl.Visible = false;
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
