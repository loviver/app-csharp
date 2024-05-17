namespace RegistroAcademico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            label4 = new Label();
            listBox2 = new ListBox();
            panel2 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(34, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 244);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 39);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 11;
            label1.Text = "Seleccione grado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 37);
            label2.Name = "label2";
            label2.Size = new Size(433, 32);
            label2.TabIndex = 3;
            label2.Text = "Centro Escolar Republica de El Salvador";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(listBox2);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(380, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 288);
            panel3.TabIndex = 5;
            panel3.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(button1);
            panel5.Location = new Point(6, 221);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 56);
            panel5.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(61, 7);
            button1.Name = "button1";
            button1.Size = new Size(148, 37);
            button1.TabIndex = 7;
            button1.Text = "Ver materia de grado";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 27);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(73, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 9;
            label4.Text = "PRIMER GRADO";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(6, 71);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(267, 154);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(6, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 39);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 32);
            label3.TabIndex = 0;
            label3.Text = "Materias";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Controls.Add(button2);
            panel6.Location = new Point(34, 382);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 56);
            panel6.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(62, 10);
            button2.Name = "button2";
            button2.Size = new Size(148, 37);
            button2.TabIndex = 7;
            button2.Text = "Ver grado";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(724, 464);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private ListBox listBox2;
        private Panel panel2;
        private Label label3;
        private Button button1;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private Button button2;
        private Label label1;
    }
}
