using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task6.V25
{
    partial class FormMain
    {
        private Button buttonLoad;
        private Button buttonProcess;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Label labelIn;
        private Label labelOut;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.buttonProcess = new Button();
            this.textBoxIn = new TextBox();
            this.textBoxOut = new TextBox();
            this.labelIn = new Label();
            this.labelOut = new Label();
            this.buttonInfo = new Button();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить файл";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(120, 30);
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);

            // buttonProcess
            this.buttonProcess.Text = "Обработать текст";
            this.buttonProcess.Location = new Point(160, 20);
            this.buttonProcess.Size = new Size(140, 30);
            this.buttonProcess.Click += new EventHandler(this.buttonProcess_Click);

            // buttonInfo
            this.buttonInfo.Text = "?";
            this.buttonInfo.Location = new Point(320, 20);
            this.buttonInfo.Size = new Size(35, 30);
            this.buttonInfo.Click += new EventHandler(this.buttonInfo_Click);

            // textBoxIn
            this.textBoxIn.Location = new Point(20, 80);
            this.textBoxIn.Size = new Size(400, 120);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.ScrollBars = ScrollBars.Vertical;

            // textBoxOut
            this.textBoxOut.Location = new Point(20, 230);
            this.textBoxOut.Size = new Size(400, 120);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.ScrollBars = ScrollBars.Vertical;
            this.textBoxOut.ReadOnly = true;

            // labelIn
            this.labelIn.Text = "Содержимое файла";
            this.labelIn.Location = new Point(20, 60);
            this.labelIn.AutoSize = true;

            // labelOut
            this.labelOut.Text = "Слова с буквой 'E'";
            this.labelOut.Location = new Point(20, 210);
            this.labelOut.AutoSize = true;

            // FormMain
            this.ClientSize = new Size(460, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.buttonInfo);
            this.Text = "Спринт 6 | Таск 6 | Вариант 25 | Ханикян Д. К.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}