namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class FormMaskapai
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
            textPerusahaan = new TextBox();
            textJumlahKru = new TextBox();
            textNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            textDeskripsi = new TextBox();
            text = new Label();
            button2 = new Button();
            button1 = new Button();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 35);
            label2.Name = "label2";
            label2.Size = new Size(311, 17);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // textPerusahaan
            // 
            textPerusahaan.Location = new Point(94, 377);
            textPerusahaan.Name = "textPerusahaan";
            textPerusahaan.Size = new Size(195, 23);
            textPerusahaan.TabIndex = 21;
            // 
            // textJumlahKru
            // 
            textJumlahKru.Location = new Point(94, 411);
            textJumlahKru.Name = "textJumlahKru";
            textJumlahKru.Size = new Size(195, 23);
            textJumlahKru.TabIndex = 20;
            textJumlahKru.TextChanged += textJumlahKru_TextChanged;
            // 
            // textNama
            // 
            textNama.Location = new Point(94, 348);
            textNama.Name = "textNama";
            textNama.Size = new Size(195, 23);
            textNama.TabIndex = 18;
            textNama.TextChanged += textNama_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 412);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 16;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 383);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 15;
            label4.Text = "Perusahaan";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 14;
            label3.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(571, 272);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textDeskripsi
            // 
            textDeskripsi.Location = new Point(384, 359);
            textDeskripsi.Multiline = true;
            textDeskripsi.Name = "textDeskripsi";
            textDeskripsi.Size = new Size(195, 89);
            textDeskripsi.TabIndex = 23;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            text.Location = new Point(316, 359);
            text.Name = "text";
            text.Size = new Size(62, 17);
            text.TabIndex = 22;
            text.Text = "Deskripsi";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(484, 491);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(364, 491);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // FormMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textDeskripsi);
            Controls.Add(text);
            Controls.Add(textPerusahaan);
            Controls.Add(textJumlahKru);
            Controls.Add(textNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMaskapai";
            Text = "v";
            Load += FormMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textPerusahaan;
        private TextBox textJumlahKru;
        private TextBox textNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textAlamat;
        private Label label8;
        private Button button2;
        private Button button1;
        private TextBox textDeskripsi;
        private Label text;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}