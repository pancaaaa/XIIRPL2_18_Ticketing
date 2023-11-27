namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            textBox6 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(492, 418);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 106);
            textBox6.TabIndex = 32;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(612, 530);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(492, 530);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 443);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 472);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 507);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 27;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(421, 415);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 25;
            label8.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 507);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 24;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 476);
            label5.Name = "label5";
            label5.Size = new Size(119, 17);
            label5.TabIndex = 23;
            label5.Text = "Presentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 444);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 22;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 415);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 21;
            label3.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 352);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(337, 17);
            label2.TabIndex = 19;
            label2.Text = "Semua Kode Promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 18;
            label1.Text = "Master Kode Promo";
            // 
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 565);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            Load += FormMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}