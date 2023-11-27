namespace XIIRPL2_18_Ticketing.MasterForm
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, -1);
            button1.Name = "button1";
            button1.Size = new Size(383, 193);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 218);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 249);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 23);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(308, 309);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 361);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 6;
            label3.Text = "Belum punya akun? \r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(198, 360);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Daftar Sekarang!";
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Formlogin";
            Text = "Formlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}