using Microsoft.VisualBasic.Logging;
using System.Data;

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
            AddRow("������� � ������", "23", "14", "16");
            AddRow("������� �������", "90", "33", "59");
            AddRow("��������", "33", "24", "91");
            AddRow("������", "14", "1", "6");
            AddRow("����������", "34", "45", "9");
            AddRow("���������� � ���������", "77", "4", "1");
            AddRow("����������", "34", "2", "4");
            AddRow("�����������", "27", "3", "5");
            AddRow("������������ ��������", "73", "5", "78");
            AddRow("���������", "24", "2", "5");
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

        }

        private void cls_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
