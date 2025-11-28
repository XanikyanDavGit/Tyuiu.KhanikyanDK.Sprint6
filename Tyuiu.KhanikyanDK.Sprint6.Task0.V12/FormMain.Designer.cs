using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task0.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private Label labelX;
        private TextBox textBoxX;
        private Label labelResult;
        private TextBox textBoxResult;
        private Button buttonExecute;
        private Button buttonInfo;

        public object Properties { get; private set; }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxFormula = new PictureBox();
            labelX = new Label();
            textBoxX = new TextBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonExecute = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ErrorImage = (Image)resources.GetObject("pictureBoxFormula.ErrorImage");
            pictureBoxFormula.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KhanikyanDK.Sprint6\\img";
            pictureBoxFormula.Location = new Point(23, 27);
            pictureBoxFormula.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(457, 67);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(23, 120);
            labelX.Name = "labelX";
            labelX.Size = new Size(79, 20);
            labelX.TabIndex = 1;
            labelX.Text = "Введите x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(114, 116);
            textBoxX.Margin = new Padding(3, 4, 3, 4);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(137, 27);
            textBoxX.TabIndex = 2;
            textBoxX.Text = "3";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(23, 160);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(114, 156);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(137, 27);
            textBoxResult.TabIndex = 4;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(274, 155);
            buttonExecute.Margin = new Padding(3, 4, 3, 4);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(137, 33);
            buttonExecute.TabIndex = 5;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(434, 155);
            buttonInfo.Margin = new Padding(3, 4, 3, 4);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(34, 33);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 213);
            Controls.Add(buttonInfo);
            Controls.Add(buttonExecute);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Controls.Add(pictureBoxFormula);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 0 | Ханикян Д. К. | Вариант 12";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}