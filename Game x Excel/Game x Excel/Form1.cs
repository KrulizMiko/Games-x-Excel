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
            AddRow("������� � ������", "2", "2", "6");
            AddRow("������� �������", "3", "2", "5");
            AddRow("��������", "2", "6", "2");
            AddRow("������", "1", "1", "6");
            AddRow("����������", "2", "4", "9");
            AddRow("���������� � ���������", "1", "5", "1");
            AddRow("����������", "2", "2", "4");
            AddRow("�����������", "4", "3", "5");
            AddRow("������������ ��������", "7", "5", "7");
            AddRow("���������", "2", "2", "5");
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
            // ������� ��������� ����������� �������
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White; // ��� ������ ���� �� ���������
            }

        }

        private void summ_Click(object sender, EventArgs e)
        {
            // ���������� ��� �������� ������� ��������
            int game0 = 0; // ����� ��� ������� �������
            int game1 = 0; // ����� ��� ������� �������
            int game2 = 0; // ����� ��� �������� �������

            // ��������� ��������
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null && int.TryParse(row.Cells[1].Value.ToString(), out int value0))
                    game0 += value0;

                if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int value1))
                    game1 += value1;

                if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int value2))
                    game2 += value2;
            }

            // ������ ������ ������ "����"
            int totalRowIndex = -1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString() == "����")
                {
                    totalRowIndex = i;
                    break;
                }
            }

            // ���� ������ "����" ��� ����������, ��������� ��������
            if (totalRowIndex != -1)
            {
                // ��������� �������� �� ������ ������� ����
                dataGridView1.Rows[totalRowIndex].Cells[1].Value = game0.ToString();
                dataGridView1.Rows[totalRowIndex].Cells[2].Value = game1.ToString();
                dataGridView1.Rows[totalRowIndex].Cells[3].Value = game2.ToString();
            }
            else
            {
                // ��������� ������ ������, ���� � ���
                AddRow("����", game0.ToString(), game1.ToString(), game2.ToString());
            }

            // ������� ������� � ������������ ��������� ���������
            int maxColumnIndex = 1; // �������� � ������� ������� ��� ���
            double maxValue = game0; // �������������� � ������ ������

            double[] sums = new double[] { game0, game1, game2 };

            // ���������� ������������� �������� � ��� �������
            for (int i = 1; i < sums.Length; i++)
            {
                if (sums[i] > maxValue)
                {
                    maxValue = sums[i];
                    maxColumnIndex = i + 1; // ������� 1, ��� ��� sums ������������� �������� � �������
                }
            }

            // ����� ����� ��� ���� ��������
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White;
            }

            // �������� ������� � ������������ ���������
            dataGridView1.Columns[maxColumnIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
    

