namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class FormListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPenerbangan));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(801, 133);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 2;
            label1.Text = "List Penerbangan";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(5, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "00.00 - 06.00";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 19);
            button1.Name = "button1";
            button1.Size = new Size(42, 30);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 82);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 5;
            label2.Text = "Waktu Keberangkatan";
            label2.Click += label2_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(347, 109);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "18.00 - 24.00";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(228, 109);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "12.00 - 18.00";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(114, 109);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "06.00 - 12.00";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 142);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 9;
            label3.Text = "Urutkan Berdasarkan";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(426, 171);
            button3.Name = "button3";
            button3.Size = new Size(153, 23);
            button3.TabIndex = 12;
            button3.Text = "Terapkan Filter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 226);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(801, 226);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // FormListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormListPenerbangan";
            Text = "FormListPenerbangan";
            Load += FormListPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label3;
        private ComboBox comboBox1;
        private Button button3;
        private DataGridView dataGridView2;
    }
}