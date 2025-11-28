using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KhanikyanDK.Sprint6.Task7.V18
{
    partial class FormMain
    {
        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Label labelIn;
        private Label labelOut;
        private TextBox textBoxInfo;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.buttonProcess = new Button();
            this.buttonSave = new Button();
            this.buttonInfo = new Button();
            this.dataGridViewIn = new DataGridView();
            this.dataGridViewOut = new DataGridView();
            this.labelIn = new Label();
            this.labelOut = new Label();
            this.textBoxInfo = new TextBox();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить файл";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(120, 30);
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);

            // buttonProcess
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.Location = new Point(150, 20);
            this.buttonProcess.Size = new Size(100, 30);
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Click += new EventHandler(this.buttonProcess_Click);

            // buttonSave
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Location = new Point(260, 20);
            this.buttonSave.Size = new Size(100, 30);
            this.buttonSave.Enabled = false;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            // buttonInfo
            this.buttonInfo.Text = "?";
            this.buttonInfo.Location = new Point(370, 20);
            this.buttonInfo.Size = new Size(35, 30);
            this.buttonInfo.Click += new EventHandler(this.buttonInfo_Click);

            // dataGridViewIn
            this.dataGridViewIn.Location = new Point(20, 80);
            this.dataGridViewIn.Size = new Size(385, 200);
            this.dataGridViewIn.ReadOnly = true;
            this.dataGridViewIn.RowHeadersVisible = false;
            this.dataGridViewIn.ScrollBars = ScrollBars.Both;

            // dataGridViewOut
            this.dataGridViewOut.Location = new Point(415, 80);
            this.dataGridViewOut.Size = new Size(385, 200);
            this.dataGridViewOut.ReadOnly = true;
            this.dataGridViewOut.RowHeadersVisible = false;
            this.dataGridViewOut.ScrollBars = ScrollBars.Both;

            // labelIn
            this.labelIn.Text = "Исходная матрица";
            this.labelIn.Location = new Point(20, 60);
            this.labelIn.AutoSize = true;

            // labelOut
            this.labelOut.Text = "Обработанная матрица";
            this.labelOut.Location = new Point(415, 60);
            this.labelOut.AutoSize = true;

            // textBoxInfo
            this.textBoxInfo.Location = new Point(20, 290);
            this.textBoxInfo.Size = new Size(780, 25);
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Text = "Загрузите CSV файл для начала работы";

            // FormMain
            this.ClientSize = new Size(820, 330);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Ханикян Д. К.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}