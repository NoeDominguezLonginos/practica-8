namespace practica_8
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            volumenCirc = new TextBox();
            areaCirc = new TextBox();
            radioCirc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(-2, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Coral;
            tabPage1.Controls.Add(volumenCirc);
            tabPage1.Controls.Add(areaCirc);
            tabPage1.Controls.Add(radioCirc);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Circunferencia";
            // 
            // volumenCirc
            // 
            volumenCirc.Location = new Point(593, 192);
            volumenCirc.Name = "volumenCirc";
            volumenCirc.Size = new Size(100, 23);
            volumenCirc.TabIndex = 15;
            // 
            // areaCirc
            // 
            areaCirc.Location = new Point(205, 192);
            areaCirc.Name = "areaCirc";
            areaCirc.Size = new Size(100, 23);
            areaCirc.TabIndex = 14;
            // 
            // radioCirc
            // 
            radioCirc.Location = new Point(382, 133);
            radioCirc.Name = "radioCirc";
            radioCirc.Size = new Size(100, 23);
            radioCirc.TabIndex = 13;
            radioCirc.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 192);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Volumen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 192);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "Area";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 133);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Radio";
            // 
            // button3
            // 
            button3.Location = new Point(529, 335);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 9;
            button3.Text = "salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(343, 335);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 8;
            button2.Text = "borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(147, 335);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 7;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 23);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 0;
            label1.Text = "Circunferencia";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Khaki;
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 422);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Triangulo";
            // 
            // button6
            // 
            button6.Location = new Point(558, 250);
            button6.Name = "button6";
            button6.Size = new Size(92, 34);
            button6.TabIndex = 9;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(356, 250);
            button5.Name = "button5";
            button5.Size = new Size(92, 34);
            button5.TabIndex = 8;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(146, 250);
            button4.Name = "button4";
            button4.Size = new Size(92, 34);
            button4.TabIndex = 7;
            button4.Text = "calcular";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(206, 354);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(568, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(132, 356);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 3;
            label8.Text = "Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(469, 152);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 2;
            label7.Text = "Altura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(86, 156);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 1;
            label6.Text = "Base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(317, 24);
            label5.Name = "label5";
            label5.Size = new Size(155, 30);
            label5.TabIndex = 0;
            label5.Text = "Triangulo";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.SpringGreen;
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(797, 422);
            tabPage3.TabIndex = 7;
            tabPage3.Text = "Cubo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 155);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(354, 45);
            label9.Name = "label9";
            label9.Size = new Size(81, 30);
            label9.TabIndex = 0;
            label9.Text = "Cubo";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(797, 422);
            tabPage4.TabIndex = 8;
            tabPage4.Text = "Cilindro";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(797, 422);
            tabPage5.TabIndex = 9;
            tabPage5.Text = "Rombo";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(797, 422);
            tabPage6.TabIndex = 10;
            tabPage6.Text = "Octaedro";
            tabPage6.UseVisualStyleBackColor = true;
            tabPage6.Click += tabPage6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label5;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox volumenCirc;
        private TextBox areaCirc;
        private TextBox radioCirc;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}