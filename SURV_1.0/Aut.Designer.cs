
namespace SURV_1._0
{
    partial class Aut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTbox = new System.Windows.Forms.TextBox();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.Log_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.Sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // loginTbox
            // 
            this.loginTbox.Location = new System.Drawing.Point(106, 35);
            this.loginTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginTbox.Name = "loginTbox";
            this.loginTbox.Size = new System.Drawing.Size(289, 26);
            this.loginTbox.TabIndex = 2;
            // 
            // passwordTbox
            // 
            this.passwordTbox.Location = new System.Drawing.Point(106, 77);
            this.passwordTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.Size = new System.Drawing.Size(289, 26);
            this.passwordTbox.TabIndex = 2;
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(13, 202);
            this.Log_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(112, 35);
            this.Log_in.TabIndex = 3;
            this.Log_in.Text = "Войти";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Строка состояния:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(205, 155);
            this.Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(190, 26);
            this.Log.TabIndex = 2;
            // 
            // Sign_in
            // 
            this.Sign_in.Location = new System.Drawing.Point(245, 202);
            this.Sign_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(150, 35);
            this.Sign_in.TabIndex = 5;
            this.Sign_in.Text = "Регистрация";
            this.Sign_in.UseVisualStyleBackColor = true;
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // Aut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 255);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.loginTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Aut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Aut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTbox;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button Sign_in;
    }
}