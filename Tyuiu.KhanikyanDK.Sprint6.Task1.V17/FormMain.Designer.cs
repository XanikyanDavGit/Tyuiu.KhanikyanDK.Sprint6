using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task1.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxResult;
        private Button buttonExecute;
        private Button buttonInfo;

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
            textBoxResult = new TextBox();
            buttonExecute = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KhanikyanDK.Sprint6\\img\\task1.png";
            pictureBoxFormula.Location = new Point(20, 20);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(400, 50);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResult.Location = new Point(20, 90);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(500, 250);
            textBoxResult.TabIndex = 1;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(400, 350);
            buttonExecute.Margin = new Padding(3, 4, 3, 4);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(100, 35);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(490, 350);
            buttonInfo.Margin = new Padding(3, 4, 3, 4);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(35, 35);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 403);
            Controls.Add(buttonInfo);
            Controls.Add(buttonExecute);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBoxFormula);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 1 | Ханикян Д. К. | Вариант 17";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}