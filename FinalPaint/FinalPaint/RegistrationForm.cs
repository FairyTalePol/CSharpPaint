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
    public partial class RegistrationForm : Form
    {
        bool IsFirstNameValid;
        bool IsLastNameValid;
        bool IsEmailValid ;
        bool IsPasswordValid;
        bool IsConfirmed;
        private static RegistrationForm _registrationForm;
        


        private RegistrationForm()
        {
            InitializeComponent();
            
        }
        public static RegistrationForm CreateRegistrationForm()
        {
            if (_registrationForm == null)
            {
                _registrationForm = new RegistrationForm();
            }
            return _registrationForm;
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            _registrationForm.Close();
            _registrationForm = null;
            AuthorithationForm.CreateAuthorithationForm().Show();
            
           
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            if(IsAllDataCorrect())
            {
                _registrationForm.Close();
                _registrationForm = null;
                MainForm.CreateMainForm().Show();
            }
            
           
        }
        private void AddData()
        {
            UserData.AddUser(firstName_textBox.Text, lastName_textbox.Text, email_textbox.Text, password_textBox.Text);
        }

        private void FirstName_textBox_Leave(object sender, EventArgs e)
        {
            IsFirstNameValid = Validator.CheckFirst_or_LastName(firstName_textBox.Text);
            if (IsFirstNameValid)
            {
                CorrectInputColored(firstName_textBox);
            }
            else
            {
                WrongInputColored(firstName_textBox);
            }
        }

        private void LastName_textbox_Leave(object sender, EventArgs e)
        {
            IsLastNameValid = Validator.CheckFirst_or_LastName(lastName_textbox.Text);
            if (IsLastNameValid)
            {
                CorrectInputColored(lastName_textbox);
            }
            else
            {
                WrongInputColored(lastName_textbox);
            }
        }

        private void Email_textbox_Leave(object sender, EventArgs e)
        {
            IsEmailValid = Validator.CheckEmail(email_textbox.Text);
            if (IsEmailValid)
            {
                CorrectInputColored(email_textbox);
            }
            else
            {
                WrongInputColored(email_textbox);
            }
        }

        private void Password_textbox_Leave(object sender, EventArgs e)
        {
            IsPasswordValid = Validator.CheckPassword(password_textBox.Text);
            ConfirmPassword_textBox_Leave(sender, e);
            if(IsPasswordValid)
            {
                CorrectInputColored(password_textBox);
            }
            else
            {
                WrongInputColored(password_textBox);
            }
        }

        private void ConfirmPassword_textBox_Leave(object sender, EventArgs e)
        {
            if(IsPasswordValid && IsPasswordConfirmed())
            {
                IsConfirmed = true;
                CorrectInputColored(confirmPassword_textBox);
            }
            else
            {
                WrongInputColored(confirmPassword_textBox);
            }
        }
        private bool IsPasswordConfirmed()
        {
            if (password_textBox.Text == confirmPassword_textBox.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsAllDataCorrect()
        {
            if (IsFirstNameValid && IsLastNameValid && IsEmailValid && IsPasswordValid && IsConfirmed)
            {
                message_lbl.Visible = false;
                return true;
            }
            else
            {
                message_lbl.Visible = true;
                return false;
            }
        }
        private void WrongInputColored(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }
        private void CorrectInputColored(TextBox textBox)
        {
            textBox.BackColor = Color.LightGray;
        }
    }
}
