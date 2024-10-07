using System;

namespace Game_x_Excel
{
    public partial class Form1 : Form
    {
        int nRow;
        public Form1()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRow("Графика и дизайн", "2", "2", "6");
            AddRow("Игровой процесс", "3", "2", "5");
            AddRow("Геймплей", "2", "6", "2");
            AddRow("Баланс", "1", "1", "6");
            AddRow("Сообщество", "2", "4", "9");
            AddRow("Обновление и поддержка", "1", "5", "1");
            AddRow("Киберспорт", "2", "2", "4");
            AddRow("Доступность", "4", "3", "5");
            AddRow("Разнообразие контента", "7", "5", "7");
            AddRow("Интерфейс", "2", "2", "5");
        }

        private void AddRow(string Criteria, string game0, string game1, string game2)
        {
            dataGridView1.Rows.Add(Criteria, game0, game1, game2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView23();
        }

        private void dataGridView23()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cls_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            // Очищаем выделение предыдущего столбца
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White; // Или другой цвет по умолчанию
            }

        }

        private void summ_Click(object sender, EventArgs e)
        {
            // Переменные для хранения текущих значений
            int game0 = 0; // Сумма для первого столбца
            int game1 = 0; // Сумма для второго столбца
            int game2 = 0; // Сумма для третьего столбца

            // Суммируем значения
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null && int.TryParse(row.Cells[1].Value.ToString(), out int value0))
                    game0 += value0;

                if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int value1))
                    game1 += value1;

                if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int value2))
                    game2 += value2;
            }

            // Найдем индекс строки "Итог"
            int totalRowIndex = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString() == "Итог")
                {
                    totalRowIndex = i;
                    break;
                }
            }

            // Если строка "Итог" уже существует, обновляем значения
            if (totalRowIndex != -1)
            {
                // Обновляем значения на основе текущих сумм
                dataGridView1.Rows[totalRowIndex].Cells[1].Value = game0.ToString();
                dataGridView1.Rows[totalRowIndex].Cells[2].Value = game1.ToString();
                dataGridView1.Rows[totalRowIndex].Cells[3].Value = game2.ToString();
            }
            else
            {
                // Добавляем строку итогов, если её нет
                AddRow("Итог", game0.ToString(), game1.ToString(), game2.ToString());
            }

            // Находим столбец с максимальным суммарным значением
            int maxColumnIndex = 1; // Начинаем с первого столбца для игр
            double maxValue = game0; // Инициализируем с первой суммой

            double[] sums = new double[] { game0, game1, game2 };

            // Нахождение максимального значения и его индекса
            for (int i = 1; i < sums.Length; i++)
            {
                if (sums[i] > maxValue)
                {
                    maxValue = sums[i];
                    maxColumnIndex = i + 1; // Плюсуем 1, так как sums соответствует индексам в ячейках
                }
            }

            // Сброс цвета для всех столбцов
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White;
            }

            // Выделяем столбец с максимальным значением
            dataGridView1.Columns[maxColumnIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
    

