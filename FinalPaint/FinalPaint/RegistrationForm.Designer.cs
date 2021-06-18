
namespace FinalPaint
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.registration_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.lastName_textbox = new System.Windows.Forms.TextBox();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.confirmPassword_lbl = new System.Windows.Forms.Label();
            this.confirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.goBack_btn = new System.Windows.Forms.Button();
            this.message_lbl = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // registration_lbl
            // 
            this.registration_lbl.AutoSize = true;
            this.registration_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registration_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.registration_lbl.Location = new System.Drawing.Point(261, 109);
            this.registration_lbl.Name = "registration_lbl";
            this.registration_lbl.Size = new System.Drawing.Size(272, 71);
            this.registration_lbl.TabIndex = 0;
            this.registration_lbl.Text = "Registration";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastName_lbl.Location = new System.Drawing.Point(182, 295);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(151, 32);
            this.lastName_lbl.TabIndex = 1;
            this.lastName_lbl.Text = "Last Name";
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.BackColor = System.Drawing.Color.LightGray;
            this.lastName_textbox.Location = new System.Drawing.Point(186, 341);
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(396, 38);
            this.lastName_textbox.TabIndex = 2;
            this.toolTip.SetToolTip(this.lastName_textbox, "Only Latin letters 1 - 30");
            this.lastName_textbox.Leave += new System.EventHandler(this.LastName_textbox_Leave);
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.AutoSize = true;
            this.firstName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstName_lbl.Location = new System.Drawing.Point(182, 195);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(152, 32);
            this.firstName_lbl.TabIndex = 1;
            this.firstName_lbl.Text = "First Name";
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.BackColor = System.Drawing.Color.LightGray;
            this.firstName_textBox.Location = new System.Drawing.Point(188, 241);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(396, 38);
            this.firstName_textBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.firstName_textBox, "Only Latin letters 1 - 30");
            this.firstName_textBox.Leave += new System.EventHandler(this.FirstName_textBox_Leave);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_lbl.Location = new System.Drawing.Point(182, 392);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(96, 32);
            this.email_lbl.TabIndex = 1;
            this.email_lbl.Text = "E-mail";
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.LightGray;
            this.email_textbox.Location = new System.Drawing.Point(188, 438);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(396, 38);
            this.email_textbox.TabIndex = 2;
            this.toolTip.SetToolTip(this.email_textbox, "format: smt@smt.smt");
            this.email_textbox.Leave += new System.EventHandler(this.Email_textbox_Leave);
            // 
            // confirmPassword_lbl
            // 
            this.confirmPassword_lbl.AutoSize = true;
            this.confirmPassword_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmPassword_lbl.Location = new System.Drawing.Point(182, 590);
            this.confirmPassword_lbl.Name = "confirmPassword_lbl";
            this.confirmPassword_lbl.Size = new System.Drawing.Size(245, 32);
            this.confirmPassword_lbl.TabIndex = 1;
            this.confirmPassword_lbl.Text = "Confirm Password";
            // 
            // confirmPassword_textBox
            // 
            this.confirmPassword_textBox.BackColor = System.Drawing.Color.LightGray;
            this.confirmPassword_textBox.Location = new System.Drawing.Point(188, 637);
            this.confirmPassword_textBox.Name = "confirmPassword_textBox";
            this.confirmPassword_textBox.PasswordChar = '*';
            this.confirmPassword_textBox.Size = new System.Drawing.Size(396, 38);
            this.confirmPassword_textBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.confirmPassword_textBox, "Lenght 6 - 30\r\n(A-z), (0-9), special symbols");
            this.confirmPassword_textBox.Leave += new System.EventHandler(this.ConfirmPassword_textBox_Leave);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_lbl.Location = new System.Drawing.Point(182, 489);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(139, 32);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.LightGray;
            this.password_textBox.Location = new System.Drawing.Point(188, 535);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(396, 38);
            this.password_textBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.password_textBox, "Lenght 6 - 30\r\n(A-z), (0-9), special symbols\r\n");
            this.password_textBox.Leave += new System.EventHandler(this.Password_textbox_Leave);
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(302, 767);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(157, 58);
            this.signUp_btn.TabIndex = 3;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // goBack_btn
            // 
            this.goBack_btn.Location = new System.Drawing.Point(302, 850);
            this.goBack_btn.Name = "goBack_btn";
            this.goBack_btn.Size = new System.Drawing.Size(157, 58);
            this.goBack_btn.TabIndex = 3;
            this.goBack_btn.Text = "Go Back";
            this.goBack_btn.UseVisualStyleBackColor = true;
            this.goBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // message_lbl
            // 
            this.message_lbl.AutoSize = true;
            this.message_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.message_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.message_lbl.Location = new System.Drawing.Point(313, 699);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(134, 25);
            this.message_lbl.TabIndex = 4;
            this.message_lbl.Text = "Incorrect input";
            this.message_lbl.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 1011);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.goBack_btn);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.confirmPassword_textBox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.lastName_textbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.confirmPassword_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.firstName_lbl);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.registration_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "PaintiK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registration_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox lastName_textbox;
        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label confirmPassword_lbl;
        private System.Windows.Forms.TextBox confirmPassword_textBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Button goBack_btn;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.ToolTip toolTip;
    }
}