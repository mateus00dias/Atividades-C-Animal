namespace Animal__Projeto
{
    partial class Animal__Gato
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            inputWeight2 = new TextBox();
            inputRace2 = new TextBox();
            inputColor2 = new TextBox();
            inputName2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(inputWeight2);
            groupBox1.Controls.Add(inputRace2);
            groupBox1.Controls.Add(inputColor2);
            groupBox1.Controls.Add(inputName2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(178, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 254);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 216);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 8;
            label6.Text = "Kg";
            // 
            // inputWeight2
            // 
            inputWeight2.Location = new Point(81, 213);
            inputWeight2.Name = "inputWeight2";
            inputWeight2.Size = new Size(52, 23);
            inputWeight2.TabIndex = 7;
            // 
            // inputRace2
            // 
            inputRace2.Location = new Point(81, 157);
            inputRace2.Name = "inputRace2";
            inputRace2.Size = new Size(160, 23);
            inputRace2.TabIndex = 6;
            inputRace2.TextChanged += inputRace2_TextChanged;
            // 
            // inputColor2
            // 
            inputColor2.Location = new Point(81, 115);
            inputColor2.Name = "inputColor2";
            inputColor2.Size = new Size(160, 23);
            inputColor2.TabIndex = 5;
            // 
            // inputName2
            // 
            inputName2.Location = new Point(81, 60);
            inputName2.Name = "inputName2";
            inputName2.Size = new Size(160, 23);
            inputName2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 216);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 3;
            label5.Text = "Peso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 160);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Raça: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 1;
            label3.Text = "Cor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 51);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Criar Animal";
            // 
            // button1
            // 
            button1.Location = new Point(31, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(506, 395);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(178, 395);
            button3.Name = "button3";
            button3.Size = new Size(133, 23);
            button3.TabIndex = 6;
            button3.Text = "Exibir último Gato";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Animal__Gato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Animal__Gato";
            Text = "Animal__Gato";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private TextBox inputWeight2;
        private TextBox inputRace2;
        private TextBox inputColor2;
        private TextBox inputName2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}