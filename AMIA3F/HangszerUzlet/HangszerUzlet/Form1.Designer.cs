﻿
namespace HangszerUzlet
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
            this.components = new System.ComponentModel.Container();
            this.hangszerDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangszerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.saveToXML = new System.Windows.Forms.Button();
            this.dataGridViewAkcios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hangszerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangszerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcios)).BeginInit();
            this.SuspendLayout();
            // 
            // hangszerDataGridView
            // 
            this.hangszerDataGridView.AutoGenerateColumns = false;
            this.hangszerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangszerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.arDataGridViewTextBoxColumn});
            this.hangszerDataGridView.DataSource = this.hangszerBindingSource;
            this.hangszerDataGridView.Location = new System.Drawing.Point(356, 52);
            this.hangszerDataGridView.Name = "hangszerDataGridView";
            this.hangszerDataGridView.Size = new System.Drawing.Size(432, 176);
            this.hangszerDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "Tipus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            this.arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            this.arDataGridViewTextBoxColumn.HeaderText = "Ar";
            this.arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            // 
            // hangszerBindingSource
            // 
            this.hangszerBindingSource.DataSource = typeof(HangszerUzlet.Hangszer);
            this.hangszerBindingSource.CurrentChanged += new System.EventHandler(this.hangszerBindingSource_CurrentChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(356, 246);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(106, 40);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Adatok betöltése";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(131, 205);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Beszúrás";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(90, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(90, 170);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(169, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(27, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Név";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(15, 119);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Típus";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(15, 173);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Ár (Nettó)";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(658, 25);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(130, 13);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Áraink bruttóban értendők";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(90, 237);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(169, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(15, 240);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(55, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "Azonosító";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(184, 263);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "Módosítás";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(275, 120);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Keresés";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(90, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Törlés";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(90, 119);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(169, 21);
            this.typeComboBox.TabIndex = 15;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveToXML
            // 
            this.saveToXML.Location = new System.Drawing.Point(680, 246);
            this.saveToXML.Name = "saveToXML";
            this.saveToXML.Size = new System.Drawing.Size(108, 40);
            this.saveToXML.TabIndex = 16;
            this.saveToXML.Text = "Mentés (XML)";
            this.saveToXML.UseVisualStyleBackColor = true;
            this.saveToXML.Click += new System.EventHandler(this.saveToXML_Click);
            // 
            // dataGridViewAkcios
            // 
            this.dataGridViewAkcios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkcios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnType,
            this.ColumnOldPrice,
            this.ColumnAr});
            this.dataGridViewAkcios.Location = new System.Drawing.Point(356, 329);
            this.dataGridViewAkcios.Name = "dataGridViewAkcios";
            this.dataGridViewAkcios.Size = new System.Drawing.Size(432, 99);
            this.dataGridViewAkcios.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Heti akciós termékünk:";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Név";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Típus";
            this.ColumnType.Name = "ColumnType";
            // 
            // ColumnOldPrice
            // 
            this.ColumnOldPrice.HeaderText = "Régi ár";
            this.ColumnOldPrice.Name = "ColumnOldPrice";
            // 
            // ColumnAr
            // 
            this.ColumnAr.HeaderText = "Új ár";
            this.ColumnAr.Name = "ColumnAr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAkcios);
            this.Controls.Add(this.saveToXML);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.hangszerDataGridView);
            this.Name = "Form1";
            this.Text = "HangszerShop";
            ((System.ComponentModel.ISupportInitialize)(this.hangszerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangszerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hangszerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hangszerBindingSource;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button saveToXML;
        private System.Windows.Forms.DataGridView dataGridViewAkcios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAr;
    }
}

