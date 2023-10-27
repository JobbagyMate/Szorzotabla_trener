namespace Szorzotabla_trener
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
            buttonStart = new Button();
            checkBoxIdoK = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            labelKerdes = new Label();
            buttonKilep = new Button();
            panel1 = new Panel();
            label2 = new Label();
            labelOsszPerJo = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // checkBoxIdoK
            // 
            checkBoxIdoK.AutoSize = true;
            checkBoxIdoK.Location = new Point(93, 16);
            checkBoxIdoK.Name = "checkBoxIdoK";
            checkBoxIdoK.Size = new Size(73, 19);
            checkBoxIdoK.TabIndex = 1;
            checkBoxIdoK.Text = "Időkorlát";
            checkBoxIdoK.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(172, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(32, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 14);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 3;
            label1.Text = "mp";
            // 
            // labelKerdes
            // 
            labelKerdes.Location = new Point(12, 56);
            labelKerdes.Name = "labelKerdes";
            labelKerdes.Size = new Size(192, 29);
            labelKerdes.TabIndex = 4;
            // 
            // buttonKilep
            // 
            buttonKilep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonKilep.Location = new Point(438, 12);
            buttonKilep.Name = "buttonKilep";
            buttonKilep.Size = new Size(75, 23);
            buttonKilep.TabIndex = 5;
            buttonKilep.Text = "Kilépés";
            buttonKilep.UseVisualStyleBackColor = true;
            buttonKilep.Click += buttonKilep_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(340, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 263);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(388, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Válaszok";
            // 
            // labelOsszPerJo
            // 
            labelOsszPerJo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOsszPerJo.AutoSize = true;
            labelOsszPerJo.Location = new Point(398, 354);
            labelOsszPerJo.Name = "labelOsszPerJo";
            labelOsszPerJo.Size = new Size(38, 15);
            labelOsszPerJo.TabIndex = 8;
            labelOsszPerJo.Text = "label3";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(12, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(525, 450);
            Controls.Add(panel2);
            Controls.Add(labelOsszPerJo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonKilep);
            Controls.Add(labelKerdes);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBoxIdoK);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Szorzótábla tréner";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private CheckBox checkBoxIdoK;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label labelKerdes;
        private Button buttonKilep;
        private Panel panel1;
        private Label label2;
        private Label labelOsszPerJo;
        private Panel panel2;
    }
}