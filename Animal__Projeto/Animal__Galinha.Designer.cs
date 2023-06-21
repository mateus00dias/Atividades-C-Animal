namespace Animal__Projeto
{
    partial class Animal__Galinha
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
            inputE = new TextBox();
            label5 = new Label();
            label4 = new Label();
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
            label1.Location = new Point(324, 51);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Criar Galinha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(inputWeight);
            groupBox1.Controls.Add(inputRace);
            groupBox1.Controls.Add(inputE);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(178, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 254);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Galinha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 165);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 8;
            label6.Text = "Kg";
            // 
            // inputWeight
            // 
            inputWeight.Location = new Point(81, 157);
            inputWeight.Name = "inputWeight";
            inputWeight.Size = new Size(52, 23);
            inputWeight.TabIndex = 7;
            // 
            // inputRace
            // 
            inputRace.Location = new Point(81, 109);
            inputRace.Name = "inputRace";
            inputRace.Size = new Size(160, 23);
            inputRace.TabIndex = 6;
            inputRace.TextChanged += textBox3_TextChanged;
            // 
            // inputE
            // 
            inputE.Location = new Point(81, 60);
            inputE.Name = "inputE";
            inputE.Size = new Size(160, 23);
            inputE.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 157);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 3;
            label5.Text = "Peso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 109);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Raça: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Espécie:";
            // 
            // button1
            // 
            button1.Location = new Point(45, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(547, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(179, 370);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 5;
            button3.Text = "Exibir última Galinha";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Animal__Galinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Animal__Galinha";
            Text = "Animal__Galinha";
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
        private TextBox inputE;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}