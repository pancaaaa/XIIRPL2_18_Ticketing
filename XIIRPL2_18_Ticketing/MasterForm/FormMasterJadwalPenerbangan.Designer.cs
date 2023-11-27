namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class FormMasterJadwalPenerbangan
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox8 = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(423, 486);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(237, 477);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(522, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 23);
            textBox5.TabIndex = 31;
            textBox5.Text = "Friday  ,05 may 2023";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(142, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 25);
            textBox3.TabIndex = 29;
            textBox3.Text = "Abdul Rachman Sholeh";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(142, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 25);
            textBox2.TabIndex = 28;
            textBox2.Text = "Adam Air";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 27;
            textBox1.Text = "_____-____-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(367, 310);
            label8.Name = "label8";
            label8.Size = new Size(143, 17);
            label8.TabIndex = 26;
            label8.Text = "Waktu Keberangkatan";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(367, 281);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 25;
            label7.Text = "Tanggal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 372);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 24;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 346);
            label5.Name = "label5";
            label5.Size = new Size(23, 17);
            label5.TabIndex = 23;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 310);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 22;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 280);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 21;
            label3.Text = "Kode Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(524, 215);
            dataGridView1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(311, 17);
            label2.TabIndex = 19;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 18;
            label1.Text = "Master Bandara";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(142, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 25);
            textBox4.TabIndex = 34;
            textBox4.Text = "Abdul Rachman Sholeh";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(522, 335);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(195, 25);
            textBox6.TabIndex = 35;
            textBox6.Text = "__jam__menit";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(522, 307);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(195, 25);
            textBox7.TabIndex = 36;
            textBox7.Text = "00.00";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(367, 340);
            label9.Name = "label9";
            label9.Size = new Size(131, 17);
            label9.TabIndex = 37;
            label9.Text = "Durasi Penerbangan\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(367, 367);
            label10.Name = "label10";
            label10.Size = new Size(102, 17);
            label10.TabIndex = 38;
            label10.Text = "Harga Per Tiket";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(522, 364);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(195, 25);
            textBox8.TabIndex = 39;
            textBox8.Text = "1";
            textBox8.TextChanged += textBox8_TextChanged;
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
            // FormMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterJadwalPenerbangan";
            Text = "FormMasterJadwalPenerbangan";
            Load += FormMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}