namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class TiketSaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSaya));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(4, 9);
            button1.Name = "button1";
            button1.Size = new Size(42, 30);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 17;
            label1.Text = "Tiket Saya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 49);
            label2.Name = "label2";
            label2.Size = new Size(262, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua ticket anda yang aktif akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(4, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(598, 361);
            dataGridView1.TabIndex = 21;
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
            // TiketSaya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TiketSaya";
            Text = "TiketSaya";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}