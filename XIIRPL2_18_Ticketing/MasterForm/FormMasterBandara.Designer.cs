namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class FormMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textnama = new TextBox();
            textNegara = new TextBox();
            textkota = new TextBox();
            textIata = new TextBox();
            textTerminal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textAlamat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(311, 17);
            label2.TabIndex = 1;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(-1, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 290);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit ";
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-1, 352);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-1, 389);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 4;
            label4.Text = "Kode iata";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(-1, 418);
            label5.Name = "label5";
            label5.Size = new Size(36, 17);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-1, 447);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(318, 351);
            label7.Name = "label7";
            label7.Size = new Size(106, 17);
            label7.TabIndex = 7;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(373, 380);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 8;
            label8.Text = "Alamat";
            // 
            // textnama
            // 
            textnama.Location = new Point(85, 351);
            textnama.Name = "textnama";
            textnama.Size = new Size(195, 23);
            textnama.TabIndex = 9;
            // 
            // textNegara
            // 
            textNegara.Location = new Point(84, 447);
            textNegara.Name = "textNegara";
            textNegara.Size = new Size(195, 23);
            textNegara.TabIndex = 10;
            // 
            // textkota
            // 
            textkota.Location = new Point(84, 417);
            textkota.Name = "textkota";
            textkota.Size = new Size(195, 23);
            textkota.TabIndex = 11;
            // 
            // textIata
            // 
            textIata.Location = new Point(85, 383);
            textIata.Name = "textIata";
            textIata.Size = new Size(195, 23);
            textIata.TabIndex = 12;
            // 
            // textTerminal
            // 
            textTerminal.Location = new Point(430, 351);
            textTerminal.Name = "textTerminal";
            textTerminal.Size = new Size(195, 23);
            textTerminal.TabIndex = 13;
            textTerminal.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(430, 502);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(550, 502);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textAlamat
            // 
            textAlamat.Location = new Point(430, 380);
            textAlamat.Multiline = true;
            textAlamat.Name = "textAlamat";
            textAlamat.Size = new Size(195, 89);
            textAlamat.TabIndex = 17;
            // 
            // FormMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 557);
            Controls.Add(textAlamat);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textTerminal);
            Controls.Add(textIata);
            Controls.Add(textkota);
            Controls.Add(textNegara);
            Controls.Add(textnama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBandara";
            Load += FormMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textnama;
        private TextBox textNegara;
        private TextBox textkota;
        private TextBox textIata;
        private TextBox textTerminal;
        private Button button1;
        private Button button2;
        private TextBox textAlamat;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}