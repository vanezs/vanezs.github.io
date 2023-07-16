
namespace SURV_1._0
{
    partial class MainFormA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormA));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Update_Login = new System.Windows.Forms.Button();
            this.Update_Person = new System.Windows.Forms.Button();
            this.Delete_Person = new System.Windows.Forms.Button();
            this.Add_Person = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateBioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSurvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SurvDataSet = new SURV_1._0.BD_SurvDataSet();
            this.dateBioTableAdapter = new SURV_1._0.BD_SurvDataSetTableAdapters.dateBioTableAdapter();
            this.Show_Person = new System.Windows.Forms.Button();
            this.CreateTable = new System.Windows.Forms.Button();
            this._nameTable = new System.Windows.Forms.TextBox();
            this._mounth = new System.Windows.Forms.TextBox();
            this._year = new System.Windows.Forms.TextBox();
            this.dateBioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSurvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SurvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox40
            // 
            this.groupBox40.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox40.Controls.Add(this.label20);
            this.groupBox40.Controls.Add(this.label19);
            this.groupBox40.Controls.Add(this.label21);
            this.groupBox40.Controls.Add(this.label18);
            this.groupBox40.Controls.Add(this.label17);
            this.groupBox40.Controls.Add(this.label16);
            this.groupBox40.Controls.Add(this.Update_Login);
            this.groupBox40.Controls.Add(this.Update_Person);
            this.groupBox40.Controls.Add(this.Delete_Person);
            this.groupBox40.Controls.Add(this.Add_Person);
            this.groupBox40.Controls.Add(this.textBox8);
            this.groupBox40.Controls.Add(this.textBox6);
            this.groupBox40.Controls.Add(this.textBox7);
            this.groupBox40.Controls.Add(this.textBox5);
            this.groupBox40.Controls.Add(this.textBox4);
            this.groupBox40.Controls.Add(this.textBox3);
            this.groupBox40.Location = new System.Drawing.Point(897, 57);
            this.groupBox40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox40.Size = new System.Drawing.Size(478, 428);
            this.groupBox40.TabIndex = 5;
            this.groupBox40.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(252, 237);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(197, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Новый логин (Фамилия):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 237);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Новый пароль:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(252, 312);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Подтверждение:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 312);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Подтверждение:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 94);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Пароль:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Логин:";
            // 
            // Update_Login
            // 
            this.Update_Login.Location = new System.Drawing.Point(256, 182);
            this.Update_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Login.Name = "Update_Login";
            this.Update_Login.Size = new System.Drawing.Size(193, 35);
            this.Update_Login.TabIndex = 2;
            this.Update_Login.Text = "Изменить логин\r\n";
            this.Update_Login.UseVisualStyleBackColor = true;
            this.Update_Login.Click += new System.EventHandler(this.Update_Login_Click);
            // 
            // Update_Person
            // 
            this.Update_Person.Location = new System.Drawing.Point(8, 182);
            this.Update_Person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Person.Name = "Update_Person";
            this.Update_Person.Size = new System.Drawing.Size(190, 35);
            this.Update_Person.TabIndex = 2;
            this.Update_Person.Text = "Изменить пароль";
            this.Update_Person.UseVisualStyleBackColor = true;
            this.Update_Person.Click += new System.EventHandler(this.Update_Person_Click);
            // 
            // Delete_Person
            // 
            this.Delete_Person.Location = new System.Drawing.Point(334, 85);
            this.Delete_Person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Person.Name = "Delete_Person";
            this.Delete_Person.Size = new System.Drawing.Size(112, 35);
            this.Delete_Person.TabIndex = 2;
            this.Delete_Person.Text = "Удалить";
            this.Delete_Person.UseVisualStyleBackColor = true;
            this.Delete_Person.Click += new System.EventHandler(this.Delete_Person_Click);
            // 
            // Add_Person
            // 
            this.Add_Person.Location = new System.Drawing.Point(334, 31);
            this.Add_Person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Person.Name = "Add_Person";
            this.Add_Person.Size = new System.Drawing.Size(112, 35);
            this.Add_Person.TabIndex = 2;
            this.Add_Person.Text = "Добавить";
            this.Add_Person.UseVisualStyleBackColor = true;
            this.Add_Person.Click += new System.EventHandler(this.Add_Person_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(256, 340);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(193, 26);
            this.textBox8.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(8, 340);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 26);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(256, 268);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 26);
            this.textBox7.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 268);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 26);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 88);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 528);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 394);
            this.dataGridView1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dateBioBindingSource, "Login", true));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 57);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 424);
            this.listBox1.TabIndex = 7;
            // 
            // dateBioBindingSource
            // 
            this.dateBioBindingSource.DataMember = "dateBio";
            this.dateBioBindingSource.DataSource = this.bDSurvDataSetBindingSource;
            // 
            // bDSurvDataSetBindingSource
            // 
            this.bDSurvDataSetBindingSource.DataSource = this.bD_SurvDataSet;
            this.bDSurvDataSetBindingSource.Position = 0;
            // 
            // bD_SurvDataSet
            // 
            this.bD_SurvDataSet.DataSetName = "BD_SurvDataSet";
            this.bD_SurvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateBioTableAdapter
            // 
            this.dateBioTableAdapter.ClearBeforeFill = true;
            // 
            // Show_Person
            // 
            this.Show_Person.Location = new System.Drawing.Point(732, 57);
            this.Show_Person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Show_Person.Name = "Show_Person";
            this.Show_Person.Size = new System.Drawing.Size(156, 66);
            this.Show_Person.TabIndex = 8;
            this.Show_Person.Text = "Отобразить выбранное";
            this.Show_Person.UseVisualStyleBackColor = true;
            this.Show_Person.Click += new System.EventHandler(this.Show_Person_Click);
            // 
            // CreateTable
            // 
            this.CreateTable.Location = new System.Drawing.Point(732, 151);
            this.CreateTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(156, 66);
            this.CreateTable.TabIndex = 8;
            this.CreateTable.Text = "Сформировать табель";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.createTable);
            // 
            // _nameTable
            // 
            this._nameTable.Location = new System.Drawing.Point(732, 243);
            this._nameTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._nameTable.Name = "_nameTable";
            this._nameTable.Size = new System.Drawing.Size(156, 26);
            this._nameTable.TabIndex = 1;
            this._nameTable.Text = "Введите логин";
            // 
            // _mounth
            // 
            this._mounth.Location = new System.Drawing.Point(733, 294);
            this._mounth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._mounth.Name = "_mounth";
            this._mounth.Size = new System.Drawing.Size(156, 26);
            this._mounth.TabIndex = 1;
            this._mounth.Text = "Введите месяц";
            // 
            // _year
            // 
            this._year.Location = new System.Drawing.Point(732, 343);
            this._year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._year.Name = "_year";
            this._year.Size = new System.Drawing.Size(156, 26);
            this._year.TabIndex = 1;
            this._year.Text = "Введите год";
            // 
            // dateBioBindingSource1
            // 
            this.dateBioBindingSource1.DataMember = "dateBio";
            this.dateBioBindingSource1.DataSource = this.bD_SurvDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(610, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainFormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 940);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateTable);
            this.Controls.Add(this.Show_Person);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox40);
            this.Controls.Add(this._year);
            this.Controls.Add(this._mounth);
            this.Controls.Add(this._nameTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFormA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУРВ: Предприятие 1.0 Администратор";
            this.Load += new System.EventHandler(this.MainFormA_Load);
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSurvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SurvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Update_Login;
        private System.Windows.Forms.Button Update_Person;
        private System.Windows.Forms.Button Delete_Person;
        private System.Windows.Forms.Button Add_Person;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bDSurvDataSetBindingSource;
        private BD_SurvDataSet bD_SurvDataSet;
        private System.Windows.Forms.BindingSource dateBioBindingSource;
        private BD_SurvDataSetTableAdapters.dateBioTableAdapter dateBioTableAdapter;
        private System.Windows.Forms.Button Show_Person;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.TextBox _nameTable;
        private System.Windows.Forms.TextBox _mounth;
        private System.Windows.Forms.TextBox _year;
        private System.Windows.Forms.BindingSource dateBioBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}