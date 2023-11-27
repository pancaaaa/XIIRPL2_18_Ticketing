namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class Formadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formadmin));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button6);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 61);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(4, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 373);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, 2);
            button1.Name = "button1";
            button1.Size = new Size(250, 69);
            button1.TabIndex = 0;
            button1.Text = "Master Bandara";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(-2, 77);
            button2.Name = "button2";
            button2.Size = new Size(250, 69);
            button2.TabIndex = 1;
            button2.Text = "Master Maskapai";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 152);
            button3.Name = "button3";
            button3.Size = new Size(248, 69);
            button3.TabIndex = 2;
            button3.Text = "Master Jadwal Penerbangan";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 227);
            button4.Name = "button4";
            button4.Size = new Size(248, 69);
            button4.TabIndex = 3;
            button4.Text = "Master Kode Promo";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 302);
            button5.Name = "button5";
            button5.Size = new Size(248, 69);
            button5.TabIndex = 4;
            button5.Text = "Ubah Status Penerbangan";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(10, 13);
            button6.Name = "button6";
            button6.Size = new Size(50, 42);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Formadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formadmin";
            Text = "Formadmin";
            Load += Formadmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}