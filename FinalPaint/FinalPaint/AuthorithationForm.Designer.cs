
namespace FinalPaint
{
    partial class AuthorithationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorithationForm));
            this.authorization_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.message_lbl = new System.Windows.Forms.Label();
            this.signUp_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorization_lbl
            // 
            this.authorization_lbl.AutoSize = true;
            this.authorization_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.authorization_lbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization_lbl.Location = new System.Drawing.Point(145, 113);
            this.authorization_lbl.Name = "authorization_lbl";
            this.authorization_lbl.Size = new System.Drawing.Size(305, 71);
            this.authorization_lbl.TabIndex = 0;
            this.authorization_lbl.Text = "Authorization";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_lbl.Location = new System.Drawing.Point(165, 229);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(86, 32);
            this.login_lbl.TabIndex = 1;
            this.login_lbl.Text = "Login";
            // 
            // login_textBox
            // 
            this.login_textBox.BackColor = System.Drawing.Color.LightGray;
            this.login_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.login_textBox.Location = new System.Drawing.Point(171, 264);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(259, 38);
            this.login_textBox.TabIndex = 2;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_lbl.Location = new System.Drawing.Point(165, 309);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(139, 32);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.LightGray;
            this.password_textBox.Location = new System.Drawing.Point(171, 344);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(259, 38);
            this.password_textBox.TabIndex = 4;
            // 
            // signIn_btn
            // 
            this.signIn_btn.BackColor = System.Drawing.Color.LightGray;
            this.signIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn_btn.Location = new System.Drawing.Point(230, 447);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(141, 47);
            this.signIn_btn.TabIndex = 5;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = false;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // signUp_btn
            // 
            this.signUp_btn.BackColor = System.Drawing.Color.LightGray;
            this.signUp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp_btn.Location = new System.Drawing.Point(230, 540);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(141, 47);
            this.signUp_btn.TabIndex = 6;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.UseVisualStyleBackColor = false;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // message_lbl
            // 
            this.message_lbl.AutoSize = true;
            this.message_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.message_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.message_lbl.Location = new System.Drawing.Point(166, 399);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(273, 25);
            this.message_lbl.TabIndex = 7;
            this.message_lbl.Text = "Incorrect input or no such user";
            this.message_lbl.Visible = false;
            // 
            // signUp_lbl
            // 
            this.signUp_lbl.AutoSize = true;
            this.signUp_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signUp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUp_lbl.ForeColor = System.Drawing.Color.Azure;
            this.signUp_lbl.Location = new System.Drawing.Point(161, 590);
            this.signUp_lbl.Name = "signUp_lbl";
            this.signUp_lbl.Size = new System.Drawing.Size(301, 17);
            this.signUp_lbl.TabIndex = 8;
            this.signUp_lbl.Text = "First time? Press sign up to create an account.";
            // 
            // AuthorithationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 790);
            this.Controls.Add(this.signUp_lbl);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.authorization_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorithationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorization_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.Label signUp_lbl;
    }
}