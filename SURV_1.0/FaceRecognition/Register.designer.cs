namespace SURV_1._0_FaceRecognizer
{
    partial class Register
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this._picCapture = new System.Windows.Forms.PictureBox();
            this._btnCapture = new System.Windows.Forms.Button();
            this._btnDetectFaces = new System.Windows.Forms.Button();
            this._txtPersonName = new System.Windows.Forms.TextBox();
            this._btnTrain = new System.Windows.Forms.Button();
            this._picDetected = new System.Windows.Forms.PictureBox();
            this._btnAddPersone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _picCapture
            // 
            this._picCapture.Location = new System.Drawing.Point(18, 18);
            this._picCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picCapture.Name = "_picCapture";
            this._picCapture.Size = new System.Drawing.Size(897, 655);
            this._picCapture.TabIndex = 0;
            this._picCapture.TabStop = false;
            // 
            // _btnCapture
            // 
            this._btnCapture.Location = new System.Drawing.Point(926, 20);
            this._btnCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCapture.Name = "_btnCapture";
            this._btnCapture.Size = new System.Drawing.Size(256, 35);
            this._btnCapture.TabIndex = 1;
            this._btnCapture.Text = "Открыть камеру";
            this._btnCapture.UseVisualStyleBackColor = true;
            this._btnCapture.Click += new System.EventHandler(this._btnCapture_Click);
            // 
            // _btnDetectFaces
            // 
            this._btnDetectFaces.Location = new System.Drawing.Point(926, 66);
            this._btnDetectFaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnDetectFaces.Name = "_btnDetectFaces";
            this._btnDetectFaces.Size = new System.Drawing.Size(256, 35);
            this._btnDetectFaces.TabIndex = 2;
            this._btnDetectFaces.Text = "Найти лицо";
            this._btnDetectFaces.UseVisualStyleBackColor = true;
            this._btnDetectFaces.Click += new System.EventHandler(this._btnDetectFaces_Click);
            // 
            // _txtPersonName
            // 
            this._txtPersonName.Location = new System.Drawing.Point(923, 414);
            this._txtPersonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtPersonName.Name = "_txtPersonName";
            this._txtPersonName.ReadOnly = true;
            this._txtPersonName.Size = new System.Drawing.Size(121, 26);
            this._txtPersonName.TabIndex = 3;
            // 
            // _btnTrain
            // 
            this._btnTrain.Cursor = System.Windows.Forms.Cursors.Default;
            this._btnTrain.Location = new System.Drawing.Point(926, 450);
            this._btnTrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnTrain.Name = "_btnTrain";
            this._btnTrain.Size = new System.Drawing.Size(256, 58);
            this._btnTrain.TabIndex = 5;
            this._btnTrain.Text = "Распознать";
            this._btnTrain.UseVisualStyleBackColor = true;
            this._btnTrain.Click += new System.EventHandler(this._btnTrain_Click);
            // 
            // _picDetected
            // 
            this._picDetected.Location = new System.Drawing.Point(926, 155);
            this._picDetected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picDetected.Name = "_picDetected";
            this._picDetected.Size = new System.Drawing.Size(256, 209);
            this._picDetected.TabIndex = 7;
            this._picDetected.TabStop = false;
            // 
            // _btnAddPersone
            // 
            this._btnAddPersone.Location = new System.Drawing.Point(926, 111);
            this._btnAddPersone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnAddPersone.Name = "_btnAddPersone";
            this._btnAddPersone.Size = new System.Drawing.Size(256, 35);
            this._btnAddPersone.TabIndex = 8;
            this._btnAddPersone.Text = "Зарегистрировать лицо";
            this._btnAddPersone.UseVisualStyleBackColor = true;
            this._btnAddPersone.Click += new System.EventHandler(this._btnAddPersone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(926, 517);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 157);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1059, 517);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 157);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1050, 414);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(923, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Искомое лицо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1047, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Найденное лицо:";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(18, 682);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(1164, 67);
            this.status.TabIndex = 12;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 754);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnAddPersone);
            this.Controls.Add(this._picDetected);
            this.Controls.Add(this._btnTrain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._txtPersonName);
            this.Controls.Add(this._btnDetectFaces);
            this.Controls.Add(this._btnCapture);
            this.Controls.Add(this._picCapture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BioSURV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picCapture;
        private System.Windows.Forms.Button _btnCapture;
        private System.Windows.Forms.Button _btnDetectFaces;
        private System.Windows.Forms.TextBox _txtPersonName;
        private System.Windows.Forms.Button _btnTrain;
        private System.Windows.Forms.PictureBox _picDetected;
        private System.Windows.Forms.Button _btnAddPersone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox status;
    }
}

