using System;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task6.V25.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.KhanikyanDK.Sprint6.Task6.V25
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIn.Text))
            {
                MessageBox.Show("Сначала загрузите файл", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string tempPath = System.IO.Path.GetTempFileName();
                System.IO.File.WriteAllText(tempPath, textBoxIn.Text);

                string result = ds.CollectTextFromFile(tempPath);
                textBoxOut.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 Sprint6, вариант 25 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}