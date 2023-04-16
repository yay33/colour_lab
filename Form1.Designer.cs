namespace lab1_task1
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
            panel1 = new Panel();
            labelerror = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textboxRed = new TextBox();
            textBoxGreen = new TextBox();
            textBoxBlue = new TextBox();
            radioButtonHex = new RadioButton();
            radioButtonDec = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelerror);
            panel1.Location = new Point(185, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 155);
            panel1.TabIndex = 0;
            // 
            // labelerror
            // 
            labelerror.AutoSize = true;
            labelerror.Location = new Point(11, 65);
            labelerror.Name = "labelerror";
            labelerror.Size = new Size(182, 15);
            labelerror.TabIndex = 11;
            labelerror.Text = "Ошибка при вычислении цвета";
            labelerror.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Красный";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Зеленый";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 106);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Синий";
            // 
            // textboxRed
            // 
            textboxRed.Location = new Point(78, 19);
            textboxRed.Name = "textboxRed";
            textboxRed.Size = new Size(100, 23);
            textboxRed.TabIndex = 6;
            textboxRed.Text = "0";
            textboxRed.TextChanged += textboxRed_TextChanged;
            textboxRed.KeyPress += textboxRed_KeyPress;
            // 
            // textBoxGreen
            // 
            textBoxGreen.Location = new Point(78, 59);
            textBoxGreen.Name = "textBoxGreen";
            textBoxGreen.Size = new Size(100, 23);
            textBoxGreen.TabIndex = 7;
            textBoxGreen.Text = "0";
            textBoxGreen.TextChanged += textBoxGreen_TextChanged;
            textBoxGreen.KeyPress += textBoxGreen_KeyPress;
            // 
            // textBoxBlue
            // 
            textBoxBlue.Location = new Point(78, 103);
            textBoxBlue.Name = "textBoxBlue";
            textBoxBlue.Size = new Size(100, 23);
            textBoxBlue.TabIndex = 8;
            textBoxBlue.Text = "0";
            textBoxBlue.TextChanged += textBoxBlue_TextChanged;
            textBoxBlue.KeyPress += textBoxBlue_KeyPress;
            // 
            // radioButtonHex
            // 
            radioButtonHex.AutoSize = true;
            radioButtonHex.Location = new Point(93, 148);
            radioButtonHex.Name = "radioButtonHex";
            radioButtonHex.Size = new Size(46, 19);
            radioButtonHex.TabIndex = 9;
            radioButtonHex.Text = "Hex";
            radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDec
            // 
            radioButtonDec.AutoSize = true;
            radioButtonDec.Checked = true;
            radioButtonDec.Location = new Point(27, 148);
            radioButtonDec.Name = "radioButtonDec";
            radioButtonDec.Size = new Size(45, 19);
            radioButtonDec.TabIndex = 10;
            radioButtonDec.TabStop = true;
            radioButtonDec.Text = "Dec";
            radioButtonDec.UseVisualStyleBackColor = true;
            radioButtonDec.CheckedChanged += radioButtonDec_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 193);
            Controls.Add(radioButtonDec);
            Controls.Add(radioButtonHex);
            Controls.Add(textBoxBlue);
            Controls.Add(textBoxGreen);
            Controls.Add(textboxRed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "ColourGayShit";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxRed;
        private TextBox textBoxGreen;
        private TextBox textBoxBlue;
        private RadioButton radioButtonHex;
        private RadioButton radioButtonDec;
        private Label labelerror;
    }
}