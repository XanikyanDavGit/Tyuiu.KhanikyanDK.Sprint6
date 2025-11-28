using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task2.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private DataGridView dataGridViewResult;
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
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KhanikyanDK.Sprint6\\img\\task2.png";
            pictureBoxFormula.Location = new Point(20, 20);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(400, 50);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.Add("ColumnX", "x");
            dataGridViewResult.Columns.Add("ColumnFx", "f(x)");
            dataGridViewResult.Location = new Point(20, 90);
            dataGridViewResult.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(500, 250);
            dataGridViewResult.TabIndex = 1;
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
            Controls.Add(dataGridViewResult);
            Controls.Add(pictureBoxFormula);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 2 | Ханикян Д. К. | Вариант 17";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }
    }
}