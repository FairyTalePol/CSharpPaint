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
    public partial class ChangePasswordForm : Form
    {
        private string _userPassword = null;
        private bool _isOldPasswordValid;
        private bool _isNewPasswordValid;
        private bool _isPasswordConfirmed;
        public ChangePasswordForm(string userPassword)
        {
            InitializeComponent();
            _userPassword = userPassword;
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Close();
        }
        private void ClearFields()
        {
            oldPassword_textBox.Text = "";
            newPassword_textBox.Text = "";
            confirmPassword_textBox.Text = "";
            message_lbl.Visible = false;
        }

        private void OldPassword_textBox_Leave(object sender, EventArgs e)
        {
            if(oldPassword_textBox.Text == _userPassword)
            {
                _isOldPasswordValid = true;
                CorrectInputColored(oldPassword_textBox);
            }
            else
            {
                _isOldPasswordValid = false;
                WrongInputColored(oldPassword_textBox);
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

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (IsAllDataCorrect(sender, e))
            {
                if(ChangePassword())
                {
                    MessageBox.Show("Password was changed.");
                    this.Close();
                }
            }
        }

        private void NewPassword_textBox_Leave(object sender, EventArgs e)
        {
            _isNewPasswordValid = Validator.CheckPassword(newPassword_textBox.Text);
            if (_isNewPasswordValid)
            {
               
                CorrectInputColored(newPassword_textBox);
            }
            else
            {
                
                WrongInputColored(newPassword_textBox);
            }
        }

        private void ConfirmPassword_textBox_Leave(object sender, EventArgs e)
        {
            if (newPassword_textBox.Text == confirmPassword_textBox.Text)
            {
                _isPasswordConfirmed = true;
                CorrectInputColored(confirmPassword_textBox);
            }
            else
            {
                _isPasswordConfirmed = false;
                WrongInputColored(confirmPassword_textBox);
            }
        }
        private bool IsAllDataCorrect(object sender, EventArgs e)
        {
            var answer = false;
            OldPassword_textBox_Leave(sender, e);
            NewPassword_textBox_Leave(sender, e);
            ConfirmPassword_textBox_Leave(sender, e);
            if (_isOldPasswordValid && _isNewPasswordValid && _isPasswordConfirmed )
            {
                message_lbl.Visible = false;
                answer = true;
            }
            else
            {
                message_lbl.Visible = true;
                message_lbl.Text = "Incorrect input";
                answer = false;
            }
            return answer;
        }
        public bool ChangePassword()
        {
            var bl = BuisnessLogic.Create();
            bool status = bl.ChangePassword(newPassword_textBox.Text);
            bool res = true;

            if (status == false)
            {
                message_lbl.Visible = true;
                message_lbl.Text = "No Database connection";
                res = false;

            }
            else
            {
                message_lbl.Visible = false;
            }
            return res;

        }
    }
}
