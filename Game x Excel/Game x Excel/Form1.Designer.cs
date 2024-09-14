namespace Game_x_Excel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Criteria = new DataGridViewTextBoxColumn();
            game0 = new DataGridViewTextBoxColumn();
            game1 = new DataGridViewTextBoxColumn();
            game2 = new DataGridViewTextBoxColumn();
            summ = new Button();
            aaddd = new Button();
            cls = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Criteria, game0, game1, game2 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 614);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Criteria
            // 
            Criteria.HeaderText = "Критерий";
            Criteria.Name = "Criteria";
            // 
            // game0
            // 
            game0.HeaderText = "Dota 2";
            game0.Name = "game0";
            // 
            // game1
            // 
            game1.HeaderText = "LoL";
            game1.Name = "game1";
            // 
            // game2
            // 
            game2.HeaderText = "Overwatch 2";
            game2.Name = "game2";
            // 
            // summ
            // 
            summ.BackColor = SystemColors.ControlDarkDark;
            summ.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            summ.ForeColor = SystemColors.ControlLightLight;
            summ.Location = new Point(796, 125);
            summ.Name = "summ";
            summ.Size = new Size(119, 49);
            summ.TabIndex = 1;
            summ.Text = "Расчитать";
            summ.UseVisualStyleBackColor = false;
            // 
            // aaddd
            // 
            aaddd.BackColor = SystemColors.ControlDarkDark;
            aaddd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            aaddd.ForeColor = SystemColors.ControlLightLight;
            aaddd.Location = new Point(796, 24);
            aaddd.Name = "aaddd";
            aaddd.Size = new Size(119, 79);
            aaddd.TabIndex = 2;
            aaddd.Text = "Добавить критерии";
            aaddd.UseVisualStyleBackColor = false;
            aaddd.Click += button2_Click;
            // 
            // cls
            // 
            cls.BackColor = SystemColors.ControlDarkDark;
            cls.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cls.ForeColor = SystemColors.ControlLightLight;
            cls.Location = new Point(796, 590);
            cls.Name = "cls";
            cls.Size = new Size(119, 49);
            cls.TabIndex = 3;
            cls.Text = "Очистить";
            cls.UseVisualStyleBackColor = false;
            cls.Click += cls_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 651);
            Controls.Add(cls);
            Controls.Add(aaddd);
            Controls.Add(summ);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button summ;
        private Button aaddd;
        private Button cls;
        private DataGridViewTextBoxColumn Criteria;
        private DataGridViewTextBoxColumn game0;
        private DataGridViewTextBoxColumn game1;
        private DataGridViewTextBoxColumn game2;
    }
}
