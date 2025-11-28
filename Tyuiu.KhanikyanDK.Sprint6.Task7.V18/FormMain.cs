using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KhanikyanDK.Sprint6.Task7.V18.Lib;

namespace Tyuiu.KhanikyanDK.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private string loadedFilePath;
        private int[,] originalMatrix;
        private int[,] modifiedMatrix;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = openFileDialog.FileName;

                try
                {
                    // Загружаем матрицу из файла
                    originalMatrix = ds.GetMatrix(loadedFilePath);

                    // Отображаем исходную матрицу
                    DisplayMatrix(dataGridViewIn, originalMatrix);

                    buttonProcess.Enabled = true;
                    buttonSave.Enabled = false;

                    textBoxInfo.Text = $"Файл загружен: {Path.GetFileName(loadedFilePath)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (originalMatrix == null) return;

            try
            {
                // Обрабатываем матрицу (меняем значения в 9-м столбце)
                modifiedMatrix = ds.GetMatrix(loadedFilePath);

                // Отображаем обработанную матрицу
                DisplayMatrix(dataGridViewOut, modifiedMatrix);

                buttonSave.Enabled = true;
                textBoxInfo.Text = "Матрица обработана. Значения в 9-м столбце изменены на 11.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (modifiedMatrix == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "OutPutFileTask7V18.csv",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сохраняем матрицу в файл
                    SaveMatrixToFile(modifiedMatrix, saveFileDialog.FileName);
                    textBoxInfo.Text = $"Результат сохранен в: {Path.GetFileName(saveFileDialog.FileName)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayMatrix(DataGridView dataGridView, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridView.RowCount = rows;
            dataGridView.ColumnCount = cols;

            // Настраиваем заголовки столбцов
            for (int j = 0; j < cols; j++)
            {
                dataGridView.Columns[j].HeaderText = $"Col{j + 1}";
                dataGridView.Columns[j].Width = 40;
            }

            // Заполняем данными
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void SaveMatrixToFile(int[,] matrix, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(matrix[i, j]);
                        if (j < cols - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 Sprint6, вариант 18 выполнен студентом Ханикян Давит Каренович, ИИПБ-23-1\n\n" +
                "Задача: Загрузить матрицу из CSV файла, изменить в девятом столбце значения не равные 11 на 11, " +
                "вывести результат и сохранить в файл.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}