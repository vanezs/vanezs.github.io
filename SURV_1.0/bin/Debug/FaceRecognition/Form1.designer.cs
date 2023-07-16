namespace SURV_1._0_FaceRecognizer
{
    partial class Form1
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
            this._picCapture = new System.Windows.Forms.PictureBox();
            this._btnCapture = new System.Windows.Forms.Button();
            this._btnDetectFaces = new System.Windows.Forms.Button();
            this._txtPersonName = new System.Windows.Forms.TextBox();
            this._btnTrain = new System.Windows.Forms.Button();
            this._picDetected = new System.Windows.Forms.PictureBox();
            this._btnAddPersone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this._txtPersonName.Location = new System.Drawing.Point(926, 386);
            this._txtPersonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtPersonName.Name = "_txtPersonName";
            this._txtPersonName.ReadOnly = true;
            this._txtPersonName.Size = new System.Drawing.Size(254, 26);
            this._txtPersonName.TabIndex = 3;
            // 
            // _btnTrain
            // 
            this._btnTrain.Cursor = System.Windows.Forms.Cursors.Default;
            this._btnTrain.Location = new System.Drawing.Point(926, 426);
            this._btnTrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnTrain.Name = "_btnTrain";
            this._btnTrain.Size = new System.Drawing.Size(256, 82);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnAddPersone);
            this.Controls.Add(this._picDetected);
            this.Controls.Add(this._btnTrain);
            this.Controls.Add(this._txtPersonName);
            this.Controls.Add(this._btnDetectFaces);
            this.Controls.Add(this._btnCapture);
            this.Controls.Add(this._picCapture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

