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
            // ���������� ��������� ���� ��������
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.White; // ���� �� ���������
            }

        }

        private void summ_Click(object sender, EventArgs e)
        { 
            int game0 = 0;
            int game1 = 0;
            int game2 = 0;   
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
             //���� ��� ��������� ������ ����������� ������� 
             game0 += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
             game1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
             game2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                
            }   
            AddRow("����", $"{game0}", $"{game1}", $"{game2}");

            // ������� ������� � ������������ ��������� ���������
            int maxColumnIndex = 0;
            double maxValue = 0;
            //���� ������� ������� � ������
            for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; columnIndex++)
            {
                // ��������� �������� � �������
                double sum = 0;
                //���� ������� ������ � ������
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
                {
                    var cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value;

                    // ����������� �������� � ������ � �����
                    if (cellValue != null && double.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out double value))
                    {
                        sum += value;
                    }
                }

                // ���� ����� ������ �������� ������������� ��������, ��������� ��������
                if (sum > maxValue)
                {
                    maxValue = sum;
                    maxColumnIndex = columnIndex;
                }
            }

            // �������� ������� � ������������ ���������
            dataGridView1.Columns[maxColumnIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
    

