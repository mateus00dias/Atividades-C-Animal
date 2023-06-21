namespace Animal__Projeto
{
    partial class Animal__Cachorro
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            inputWeight = new TextBox();
            inputRace = new TextBox();
            inputColor = new TextBox();
            inputName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 62);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Criar Cachorro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(inputWeight);
            groupBox1.Controls.Add(inputRace);
            groupBox1.Controls.Add(inputColor);
            groupBox1.Controls.Add(inputName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(167, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 254);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cachorro";
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
            // inputWeight
            // 
            inputWeight.Location = new Point(81, 213);
            inputWeight.Name = "inputWeight";
            inputWeight.Size = new Size(52, 23);
            inputWeight.TabIndex = 7;
            // 
            // inputRace
            // 
            inputRace.Location = new Point(81, 157);
            inputRace.Name = "inputRace";
            inputRace.Size = new Size(160, 23);
            inputRace.TabIndex = 6;
            // 
            // inputColor
            // 
            inputColor.Location = new Point(81, 115);
            inputColor.Name = "inputColor";
            inputColor.Size = new Size(160, 23);
            inputColor.TabIndex = 5;
            // 
            // inputName
            // 
            inputName.Location = new Point(81, 60);
            inputName.Name = "inputName";
            inputName.Size = new Size(160, 23);
            inputName.TabIndex = 4;
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
            // button1
            // 
            button1.Location = new Point(26, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(536, 386);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(167, 386);
            button3.Name = "button3";
            button3.Size = new Size(160, 23);
            button3.TabIndex = 4;
            button3.Text = "Exibir último Cachorro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Animal__Cachorro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Animal__Cachorro";
            Text = "Animal__Cachorro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox inputWeight;
        private TextBox inputRace;
        private TextBox inputColor;
        private TextBox inputName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}