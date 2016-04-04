namespace HoangPasoLab3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.listViewDB = new System.Windows.Forms.ListView();
            this.NameDB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueDB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.txtOpenDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oDlgDB = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewScan = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDoScan = new System.Windows.Forms.Button();
            this.btnOpenFolderScan = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialogScan = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCount);
            this.groupBox1.Controls.Add(this.listViewDB);
            this.groupBox1.Controls.Add(this.btnLoadDB);
            this.groupBox1.Controls.Add(this.btnOpenDB);
            this.groupBox1.Controls.Add(this.txtOpenDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(453, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "БД сигнатур";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(9, 216);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(84, 13);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Сигнатур: 0 шт.";
            // 
            // listViewDB
            // 
            this.listViewDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameDB,
            this.ValueDB});
            this.listViewDB.GridLines = true;
            this.listViewDB.Location = new System.Drawing.Point(4, 89);
            this.listViewDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewDB.Name = "listViewDB";
            this.listViewDB.Size = new System.Drawing.Size(444, 117);
            this.listViewDB.TabIndex = 4;
            this.listViewDB.UseCompatibleStateImageBehavior = false;
            this.listViewDB.View = System.Windows.Forms.View.Details;
            // 
            // NameDB
            // 
            this.NameDB.Text = "Название сигнатур";
            this.NameDB.Width = 221;
            // 
            // ValueDB
            // 
            this.ValueDB.Text = "Сигнатура";
            this.ValueDB.Width = 369;
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(73, 54);
            this.btnLoadDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(313, 19);
            this.btnLoadDB.TabIndex = 3;
            this.btnLoadDB.Text = "Считать БД";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(362, 23);
            this.btnOpenDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(24, 19);
            this.btnOpenDB.TabIndex = 2;
            this.btnOpenDB.Text = "...";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // txtOpenDB
            // 
            this.txtOpenDB.Location = new System.Drawing.Point(73, 23);
            this.txtOpenDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpenDB.Name = "txtOpenDB";
            this.txtOpenDB.Size = new System.Drawing.Size(277, 20);
            this.txtOpenDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл БД";
            // 
            // oDlgDB
            // 
            this.oDlgDB.FileName = "oDlgDB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewScan);
            this.groupBox2.Controls.Add(this.btnDoScan);
            this.groupBox2.Controls.Add(this.btnOpenFolderScan);
            this.groupBox2.Controls.Add(this.txtScan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(453, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сканирование";
            // 
            // listViewScan
            // 
            this.listViewScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.value});
            this.listViewScan.GridLines = true;
            this.listViewScan.Location = new System.Drawing.Point(4, 92);
            this.listViewScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewScan.Name = "listViewScan";
            this.listViewScan.Size = new System.Drawing.Size(444, 117);
            this.listViewScan.TabIndex = 5;
            this.listViewScan.UseCompatibleStateImageBehavior = false;
            this.listViewScan.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Название файла";
            this.name.Width = 221;
            // 
            // value
            // 
            this.value.Text = "Результат сканирования";
            this.value.Width = 369;
            // 
            // btnDoScan
            // 
            this.btnDoScan.Location = new System.Drawing.Point(73, 56);
            this.btnDoScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoScan.Name = "btnDoScan";
            this.btnDoScan.Size = new System.Drawing.Size(313, 19);
            this.btnDoScan.TabIndex = 4;
            this.btnDoScan.Text = "Сканировать";
            this.btnDoScan.UseVisualStyleBackColor = true;
            this.btnDoScan.Click += new System.EventHandler(this.btnDoScan_Click);
            // 
            // btnOpenFolderScan
            // 
            this.btnOpenFolderScan.Location = new System.Drawing.Point(362, 23);
            this.btnOpenFolderScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFolderScan.Name = "btnOpenFolderScan";
            this.btnOpenFolderScan.Size = new System.Drawing.Size(24, 19);
            this.btnOpenFolderScan.TabIndex = 3;
            this.btnOpenFolderScan.Text = "...";
            this.btnOpenFolderScan.UseVisualStyleBackColor = true;
            this.btnOpenFolderScan.Click += new System.EventHandler(this.btnOpenFolderScan_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(97, 23);
            this.txtScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(253, 20);
            this.txtScan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Каталог поиска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ПАСО Лаб №3. Выполнил Нгуен X.X";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.TextBox txtOpenDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDB;
        private System.Windows.Forms.ColumnHeader NameDB;
        private System.Windows.Forms.ColumnHeader ValueDB;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.OpenFileDialog oDlgDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewScan;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.Button btnDoScan;
        private System.Windows.Forms.Button btnOpenFolderScan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogScan;
    }
}

