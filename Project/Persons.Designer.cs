namespace Project
{
    partial class Persons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RefreshP = new System.Windows.Forms.Button();
            this.btn_NewP = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1P = new System.Windows.Forms.TextBox();
            this.textBox2P = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3P = new System.Windows.Forms.TextBox();
            this.textBox4P = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5P = new System.Windows.Forms.TextBox();
            this.btn_UpdateP = new System.Windows.Forms.Button();
            this.btn_DeleteP = new System.Windows.Forms.Button();
            this.tbIdP = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bérlő nyilvántartó";
            // 
            // btn_RefreshP
            // 
            this.btn_RefreshP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_RefreshP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RefreshP.Location = new System.Drawing.Point(386, 6);
            this.btn_RefreshP.Name = "btn_RefreshP";
            this.btn_RefreshP.Size = new System.Drawing.Size(142, 35);
            this.btn_RefreshP.TabIndex = 1;
            this.btn_RefreshP.Text = "Frissítés";
            this.btn_RefreshP.UseVisualStyleBackColor = false;
            this.btn_RefreshP.Click += new System.EventHandler(this.btn_RefreshP_Click);
            // 
            // btn_NewP
            // 
            this.btn_NewP.BackColor = System.Drawing.Color.Snow;
            this.btn_NewP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NewP.Location = new System.Drawing.Point(724, 6);
            this.btn_NewP.Name = "btn_NewP";
            this.btn_NewP.Size = new System.Drawing.Size(186, 37);
            this.btn_NewP.TabIndex = 2;
            this.btn_NewP.Text = "Új bérlő hozzáadása";
            this.btn_NewP.UseVisualStyleBackColor = false;
            this.btn_NewP.Click += new System.EventHandler(this.btn_NewP_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPersons.Location = new System.Drawing.Point(12, 49);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.RowTemplate.Height = 25;
            this.dgvPersons.Size = new System.Drawing.Size(898, 330);
            this.dgvPersons.TabIndex = 3;
            this.dgvPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiválasztott bérlő módosítása / törlése";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Személyi szám:";
            // 
            // textBox1P
            // 
            this.textBox1P.Location = new System.Drawing.Point(104, 421);
            this.textBox1P.Name = "textBox1P";
            this.textBox1P.Size = new System.Drawing.Size(125, 23);
            this.textBox1P.TabIndex = 6;
            // 
            // textBox2P
            // 
            this.textBox2P.Location = new System.Drawing.Point(104, 468);
            this.textBox2P.Name = "textBox2P";
            this.textBox2P.Size = new System.Drawing.Size(125, 23);
            this.textBox2P.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Település:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Irányítószám:";
            // 
            // textBox3P
            // 
            this.textBox3P.Location = new System.Drawing.Point(346, 421);
            this.textBox3P.Name = "textBox3P";
            this.textBox3P.Size = new System.Drawing.Size(129, 23);
            this.textBox3P.TabIndex = 6;
            // 
            // textBox4P
            // 
            this.textBox4P.Location = new System.Drawing.Point(346, 468);
            this.textBox4P.Name = "textBox4P";
            this.textBox4P.Size = new System.Drawing.Size(129, 23);
            this.textBox4P.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hozzáadás dátuma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cím:";
            // 
            // textBox5P
            // 
            this.textBox5P.Location = new System.Drawing.Point(626, 421);
            this.textBox5P.Name = "textBox5P";
            this.textBox5P.Size = new System.Drawing.Size(140, 23);
            this.textBox5P.TabIndex = 6;
            // 
            // btn_UpdateP
            // 
            this.btn_UpdateP.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_UpdateP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateP.Location = new System.Drawing.Point(808, 396);
            this.btn_UpdateP.Name = "btn_UpdateP";
            this.btn_UpdateP.Size = new System.Drawing.Size(102, 43);
            this.btn_UpdateP.TabIndex = 7;
            this.btn_UpdateP.Text = "Módosítás";
            this.btn_UpdateP.UseVisualStyleBackColor = false;
            this.btn_UpdateP.Click += new System.EventHandler(this.btn_UpdateP_Click);
            // 
            // btn_DeleteP
            // 
            this.btn_DeleteP.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteP.Location = new System.Drawing.Point(808, 455);
            this.btn_DeleteP.Name = "btn_DeleteP";
            this.btn_DeleteP.Size = new System.Drawing.Size(102, 42);
            this.btn_DeleteP.TabIndex = 8;
            this.btn_DeleteP.Text = "Törlés";
            this.btn_DeleteP.UseVisualStyleBackColor = false;
            this.btn_DeleteP.Click += new System.EventHandler(this.btn_DeleteP_Click);
            // 
            // tbIdP
            // 
            this.tbIdP.Location = new System.Drawing.Point(354, 386);
            this.tbIdP.Name = "tbIdP";
            this.tbIdP.Size = new System.Drawing.Size(31, 23);
            this.tbIdP.TabIndex = 9;
            this.tbIdP.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(626, 468);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Column1
            // 
            this.Column1.DividerWidth = 2;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 75F;
            this.Column2.HeaderText = "Személyi szám";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Név";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 75F;
            this.Column4.HeaderText = "Irányítószám";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 75F;
            this.Column5.HeaderText = "Település";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cím";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hozzáadás dátuma";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 503);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbIdP);
            this.Controls.Add(this.btn_DeleteP);
            this.Controls.Add(this.btn_UpdateP);
            this.Controls.Add(this.textBox4P);
            this.Controls.Add(this.textBox2P);
            this.Controls.Add(this.textBox5P);
            this.Controls.Add(this.textBox3P);
            this.Controls.Add(this.textBox1P);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.btn_NewP);
            this.Controls.Add(this.btn_RefreshP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Persons";
            this.Text = "Persons";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_RefreshP;
        private Button btn_NewP;
        private DataGridView dgvPersons;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1P;
        private TextBox textBox2P;
        private Label label5;
        private Label label6;
        private TextBox textBox3P;
        private TextBox textBox4P;
        private Label label7;
        private Label label8;
        private TextBox textBox5P;
        private Button btn_UpdateP;
        private Button btn_DeleteP;
        private TextBox tbIdP;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}