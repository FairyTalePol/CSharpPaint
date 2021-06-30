
namespace FinalPaint
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.oldPassword_lbl = new System.Windows.Forms.Label();
            this.oldPassword_textBox = new System.Windows.Forms.TextBox();
            this.newPassword_lbl = new System.Windows.Forms.Label();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.confirmPassword_lbl = new System.Windows.Forms.Label();
            this.confirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.goBack_btn = new System.Windows.Forms.Button();
            this.password_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.message_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_lbl.Location = new System.Drawing.Point(228, 108);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(414, 55);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Change password";
            // 
            // oldPassword_lbl
            // 
            this.oldPassword_lbl.AutoSize = true;
            this.oldPassword_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oldPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.oldPassword_lbl.Location = new System.Drawing.Point(231, 230);
            this.oldPassword_lbl.Name = "oldPassword_lbl";
            this.oldPassword_lbl.Size = new System.Drawing.Size(225, 39);
            this.oldPassword_lbl.TabIndex = 1;
            this.oldPassword_lbl.Text = "Old password";
            // 
            // oldPassword_textBox
            // 
            this.oldPassword_textBox.BackColor = System.Drawing.Color.LightGray;
            this.oldPassword_textBox.Location = new System.Drawing.Point(238, 290);
            this.oldPassword_textBox.Name = "oldPassword_textBox";
            this.oldPassword_textBox.PasswordChar = '*';
            this.oldPassword_textBox.Size = new System.Drawing.Size(403, 38);
            this.oldPassword_textBox.TabIndex = 2;
            this.password_toolTip.SetToolTip(this.oldPassword_textBox, "Lenght 6 - 30\r\n(A-z), (0-9), special symbols");
            this.oldPassword_textBox.Leave += new System.EventHandler(this.OldPassword_textBox_Leave);
            // 
            // newPassword_lbl
            // 
            this.newPassword_lbl.AutoSize = true;
            this.newPassword_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.newPassword_lbl.Location = new System.Drawing.Point(231, 378);
            this.newPassword_lbl.Name = "newPassword_lbl";
            this.newPassword_lbl.Size = new System.Drawing.Size(241, 39);
            this.newPassword_lbl.TabIndex = 1;
            this.newPassword_lbl.Text = "New password";
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.BackColor = System.Drawing.Color.LightGray;
            this.newPassword_textBox.Location = new System.Drawing.Point(238, 438);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.PasswordChar = '*';
            this.newPassword_textBox.Size = new System.Drawing.Size(403, 38);
            this.newPassword_textBox.TabIndex = 2;
            this.password_toolTip.SetToolTip(this.newPassword_textBox, "Lenght 6 - 30\r\n(A-z), (0-9), special symbols");
            this.newPassword_textBox.Leave += new System.EventHandler(this.NewPassword_textBox_Leave);
            // 
            // confirmPassword_lbl
            // 
            this.confirmPassword_lbl.AutoSize = true;
            this.confirmPassword_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmPassword_lbl.Location = new System.Drawing.Point(232, 516);
            this.confirmPassword_lbl.Name = "confirmPassword_lbl";
            this.confirmPassword_lbl.Size = new System.Drawing.Size(291, 39);
            this.confirmPassword_lbl.TabIndex = 1;
            this.confirmPassword_lbl.Text = "Confirm password";
            // 
            // confirmPassword_textBox
            // 
            this.confirmPassword_textBox.BackColor = System.Drawing.Color.LightGray;
            this.confirmPassword_textBox.Location = new System.Drawing.Point(239, 576);
            this.confirmPassword_textBox.Name = "confirmPassword_textBox";
            this.confirmPassword_textBox.PasswordChar = '*';
            this.confirmPassword_textBox.Size = new System.Drawing.Size(403, 38);
            this.confirmPassword_textBox.TabIndex = 2;
            this.password_toolTip.SetToolTip(this.confirmPassword_textBox, "Lenght 6 - 30\r\n(A-z), (0-9), special symbols");
            this.confirmPassword_textBox.Leave += new System.EventHandler(this.ConfirmPassword_textBox_Leave);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.LightGray;
            this.confirm_btn.Location = new System.Drawing.Point(344, 730);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(153, 65);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // goBack_btn
            // 
            this.goBack_btn.BackColor = System.Drawing.Color.LightGray;
            this.goBack_btn.Location = new System.Drawing.Point(344, 817);
            this.goBack_btn.Name = "goBack_btn";
            this.goBack_btn.Size = new System.Drawing.Size(153, 65);
            this.goBack_btn.TabIndex = 3;
            this.goBack_btn.Text = "Go Back";
            this.goBack_btn.UseVisualStyleBackColor = false;
            this.goBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // message_lbl
            // 
            this.message_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.message_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.message_lbl.Location = new System.Drawing.Point(2, 644);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(843, 47);
            this.message_lbl.TabIndex = 4;
            this.message_lbl.Text = "Incorrect input ";
            this.message_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message_lbl.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 926);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.goBack_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.confirmPassword_textBox);
            this.Controls.Add(this.confirmPassword_lbl);
            this.Controls.Add(this.newPassword_textBox);
            this.Controls.Add(this.newPassword_lbl);
            this.Controls.Add(this.oldPassword_textBox);
            this.Controls.Add(this.oldPassword_lbl);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label oldPassword_lbl;
        private System.Windows.Forms.TextBox oldPassword_textBox;
        private System.Windows.Forms.Label newPassword_lbl;
        private System.Windows.Forms.TextBox newPassword_textBox;
        private System.Windows.Forms.Label confirmPassword_lbl;
        private System.Windows.Forms.TextBox confirmPassword_textBox;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button goBack_btn;
        private System.Windows.Forms.ToolTip password_toolTip;
        private System.Windows.Forms.Label message_lbl;
    }
}