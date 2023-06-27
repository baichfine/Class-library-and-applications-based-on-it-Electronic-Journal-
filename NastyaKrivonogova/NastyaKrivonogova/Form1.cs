using System;
using System.Windows.Forms;
using ClassLibraryKrivonogova;

namespace NastyaKrivonogova
{
    public partial class Form1 : Form
    {
        UserContext db = new UserContext();
        int week = 1;
        int weeks = 0;
        public Form1(bool numberForm)
        {
            InitializeComponent();
            userName(numberForm);
            SizeColumns();   
            if (week == 1) button5.Enabled = false;
        }
        public void BdDataArray()
        {
            using (UserContext db = new UserContext())
            {
                Week4Day1[] days1 = new Week4Day1[6];
                Week4Day2[] days2 = new Week4Day2[6];
                Week4Day3[] days3 = new Week4Day3[6];
                Week4Day4[] days4 = new Week4Day4[6];
                Week4Day5[] days5 = new Week4Day5[6];
                Week4Day6[] days6 = new Week4Day6[6];

                days1[0] = new Week4Day1 { Subject = "Литература", HomeWork = "выучить стихотворение Есенина", Assessment = "5" };
                days1[1] = new Week4Day1 { Subject = "Русский язык", HomeWork = "упр. 365, подготовиться к диктанту", Assessment = "4" };
                days1[2] = new Week4Day1 { Subject = "География", HomeWork = "п.6, пересказ ", Assessment = "3" };
                days1[3] = new Week4Day1 { Subject = "Математика", HomeWork = "№ 17, 19, 25, Ларин 15 вариант", Assessment = "4" };
                days1[4] = new Week4Day1 { Subject = "Математика", HomeWork = "№ 17, 19, 25, Ларин 15 вариант", Assessment = "5" };
                days1[5] = new Week4Day1 { Subject = "История", HomeWork = "п. 11 пересказ, составить таблицу", Assessment = "5" };

                days2[0] = new Week4Day2 { Subject = "Физика", HomeWork = "задание 7, 8", Assessment = "5" };
                days2[1] = new Week4Day2 { Subject = "Русский язык", HomeWork = "упр. 375, выучить правило на стр. 98", Assessment = "" };
                days2[2] = new Week4Day2 { Subject = "Биология", HomeWork = "п.9, пересказ ", Assessment = "" };
                days2[3] = new Week4Day2 { Subject = "Физ-ра", HomeWork = "домашняя тренировка", Assessment = "" };
                days2[4] = new Week4Day2 { Subject = "История", HomeWork = "п. 11 пересказ, составить таблицу", Assessment = "5" };
                days2[5] = new Week4Day2 { Subject = "Обществознание", HomeWork = "п. 11 пересказ, составить таблицу", Assessment = "" };

                days3[0] = new Week4Day3 { Subject = "ИЗО", HomeWork = "изучить технику художника", Assessment = "5" };
                days3[1] = new Week4Day3 { Subject = "История", HomeWork = "столетняя война, доклад", Assessment = "" };
                days3[2] = new Week4Day3 { Subject = "Английский язык", HomeWork = "перевести стр 78, пересказ стр. 89", Assessment = "3" };
                days3[3] = new Week4Day3 { Subject = "Литература", HomeWork = "Война и мир читать", Assessment = "" };
                days3[4] = new Week4Day3 { Subject = "Обществознание", HomeWork = "написать тезис по п. 17", Assessment = "5" };
                days3[5] = new Week4Day3 { Subject = "Биология", HomeWork = "п. 13 пересказ", Assessment = "" };

                days4[0] = new Week4Day4 { Subject = "География", HomeWork = "п. 13 пересказ, заполнить контурную карту", Assessment = "5" };
                days4[1] = new Week4Day4 { Subject = "Биология", HomeWork = "п. 14 пересказ", Assessment = "" };
                days4[2] = new Week4Day4 { Subject = "Математика", HomeWork = "№ 25, 27, 31, Ларин 16 вариант", Assessment = "" };
                days4[3] = new Week4Day4 { Subject = "Русский язык", HomeWork = "упр. 21, написать сочинение", Assessment = "" };
                days4[4] = new Week4Day4 { Subject = "Физика", HomeWork = "задание № 35", Assessment = "" };
                days4[5] = new Week4Day4 { Subject = "Литература", HomeWork = "Война и мир читать", Assessment = "" };


                days5[0] = new Week4Day5 { Subject = "Информатика", HomeWork = "закодировать текст", Assessment = "4" };
                days5[1] = new Week4Day5 { Subject = "Русский язык", HomeWork = "упр. 369, выучить правило на стр 79", Assessment = "5" };
                days5[2] = new Week4Day5 { Subject = "Физика", HomeWork = "задание № 29 ", Assessment = "3" };
                days5[3] = new Week4Day5 { Subject = "Математика", HomeWork = "№ 45, 46, Ларин 17 вариант", Assessment = "" };
                days5[4] = new Week4Day5 { Subject = "Литература", HomeWork = "Война и мир, написать сочинение", Assessment = "" };
                days5[5] = new Week4Day5 { Subject = "Музыка", HomeWork = "выучить песню", Assessment = "" };

                days6[0] = new Week4Day6 { Subject = "Технология", HomeWork = "спецодежда, чертеж в тетрадь", Assessment = "" };
                days6[1] = new Week4Day6 { Subject = "Технология", HomeWork = "спецодежда, чертеж в тетрадь", Assessment = "" };
                days6[2] = new Week4Day6 { Subject = "Русский язык", HomeWork = "упр. 67", Assessment = "" };
                days6[3] = new Week4Day6 { Subject = "Физ-ра", HomeWork = "принести форму", Assessment = "4" };
                days6[4] = new Week4Day6 { Subject = "Математика", HomeWork = "№ 67, 68, Ларин 21 вариант", Assessment = "5" };
                days6[5] = new Week4Day6 { Subject = "Литература", HomeWork = "Война и мир читать", Assessment = "" };

                for (int i = 0; i < 6; i++)
                {
                    db.Weeks4Days1.Add(days1[i]);
                    db.Weeks4Days2.Add(days2[i]);
                    db.Weeks4Days3.Add(days3[i]);
                    db.Weeks4Days4.Add(days4[i]);
                    db.Weeks4Days5.Add(days5[i]);
                    db.Weeks4Days6.Add(days6[i]);
                }
                db.SaveChanges();
            }
        }
        public void delete()
        {
            using (UserContext db = new UserContext())
            {
                var films = db.Weeks2Days5;
                int i = 0;
                foreach (Week2Day5 d in films)
                {
                    db.Weeks2Days5.Remove(d);
                    i++;
                }
                db.SaveChanges();
            }
        }
        public void userName(bool numberForm)
        {
            if (numberForm == true)
            {
                comboBox1.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView2.Columns[1].ReadOnly = true;
                dataGridView3.Columns[1].ReadOnly = true;
                dataGridView4.Columns[1].ReadOnly = true;
                dataGridView5.Columns[1].ReadOnly = true;
                dataGridView6.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView2.Columns[2].ReadOnly = true;
                dataGridView3.Columns[2].ReadOnly = true;
                dataGridView4.Columns[2].ReadOnly = true;
                dataGridView5.Columns[2].ReadOnly = true;
                dataGridView6.Columns[2].ReadOnly = true;
            }
            else
            {
                comboBox1.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
                dataGridView1.Columns[1].ReadOnly = false;
                dataGridView2.Columns[1].ReadOnly = false;
                dataGridView3.Columns[1].ReadOnly = false;
                dataGridView4.Columns[1].ReadOnly = false;
                dataGridView5.Columns[1].ReadOnly = false;
                dataGridView6.Columns[1].ReadOnly = false;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView2.Columns[2].ReadOnly = false;
                dataGridView3.Columns[2].ReadOnly = false;
                dataGridView4.Columns[2].ReadOnly = false;
                dataGridView5.Columns[2].ReadOnly = false;
                dataGridView6.Columns[2].ReadOnly = false;
            }
        }
        public void SizeColumns()
        {
            dataGridView1.Columns[1].Width = 200;
            dataGridView2.Columns[1].Width = 200;
            dataGridView3.Columns[1].Width = 200;
            dataGridView4.Columns[1].Width = 200;
            dataGridView5.Columns[1].Width = 200;
            dataGridView6.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 50;
            dataGridView2.Columns[2].Width = 50;
            dataGridView3.Columns[2].Width = 50;
            dataGridView4.Columns[2].Width = 50;
            dataGridView5.Columns[2].Width = 50;
            dataGridView6.Columns[2].Width = 50;
        }
        public void clearSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet25.Week2Day5". При необходимости она может быть перемещена или удалена.
            this.week2Day5TableAdapter1.Fill(this.bdNastyaDataSet25.Week2Day5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet24.Week4Day6". При необходимости она может быть перемещена или удалена.
            this.week4Day6TableAdapter.Fill(this.bdNastyaDataSet24.Week4Day6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet23.Week3Day6". При необходимости она может быть перемещена или удалена.
            this.week3Day6TableAdapter.Fill(this.bdNastyaDataSet23.Week3Day6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet22.Week2Day6". При необходимости она может быть перемещена или удалена.
            this.week2Day6TableAdapter.Fill(this.bdNastyaDataSet22.Week2Day6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet21.Week4Day5". При необходимости она может быть перемещена или удалена.
            this.week4Day5TableAdapter.Fill(this.bdNastyaDataSet21.Week4Day5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet20.Week3Day5". При необходимости она может быть перемещена или удалена.
            this.week3Day5TableAdapter.Fill(this.bdNastyaDataSet20.Week3Day5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet19.Week2Day5". При необходимости она может быть перемещена или удалена.
            this.week2Day5TableAdapter.Fill(this.bdNastyaDataSet19.Week2Day5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet18.Week4Day4". При необходимости она может быть перемещена или удалена.
            this.week4Day4TableAdapter.Fill(this.bdNastyaDataSet18.Week4Day4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet17.Week3Day4". При необходимости она может быть перемещена или удалена.
            this.week3Day4TableAdapter.Fill(this.bdNastyaDataSet17.Week3Day4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet16.Week2Day4". При необходимости она может быть перемещена или удалена.
            this.week2Day4TableAdapter.Fill(this.bdNastyaDataSet16.Week2Day4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet15.Week4Day3". При необходимости она может быть перемещена или удалена.
            this.week4Day3TableAdapter.Fill(this.bdNastyaDataSet15.Week4Day3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet14.Week3Day3". При необходимости она может быть перемещена или удалена.
            this.week3Day3TableAdapter.Fill(this.bdNastyaDataSet14.Week3Day3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet13.Week2Day3". При необходимости она может быть перемещена или удалена.
            this.week2Day3TableAdapter.Fill(this.bdNastyaDataSet13.Week2Day3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet12.Week4Day2". При необходимости она может быть перемещена или удалена.
            this.week4Day2TableAdapter.Fill(this.bdNastyaDataSet12.Week4Day2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet11.Week3Day2". При необходимости она может быть перемещена или удалена.
            this.week3Day2TableAdapter.Fill(this.bdNastyaDataSet11.Week3Day2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet10.Week2Day2". При необходимости она может быть перемещена или удалена.
            this.week2Day2TableAdapter.Fill(this.bdNastyaDataSet10.Week2Day2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet9.Week1Day2". При необходимости она может быть перемещена или удалена.
            this.week1Day2TableAdapter1.Fill(this.bdNastyaDataSet9.Week1Day2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet8.Week4Day1". При необходимости она может быть перемещена или удалена.
            this.week4Day1TableAdapter.Fill(this.bdNastyaDataSet8.Week4Day1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet7.Week3Day1". При необходимости она может быть перемещена или удалена.
            this.week3Day1TableAdapter.Fill(this.bdNastyaDataSet7.Week3Day1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet6.Week2Day1". При необходимости она может быть перемещена или удалена.
            this.week2Day1TableAdapter.Fill(this.bdNastyaDataSet6.Week2Day1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet5.Week1Day6". При необходимости она может быть перемещена или удалена.
            this.week1Day6TableAdapter.Fill(this.bdNastyaDataSet5.Week1Day6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet4.Week1Day5". При необходимости она может быть перемещена или удалена.
            this.week1Day5TableAdapter.Fill(this.bdNastyaDataSet4.Week1Day5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet3.Week1Day4". При необходимости она может быть перемещена или удалена.
            this.week1Day4TableAdapter.Fill(this.bdNastyaDataSet3.Week1Day4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet2.Week1Day3". При необходимости она может быть перемещена или удалена.
            this.week1Day3TableAdapter.Fill(this.bdNastyaDataSet2.Week1Day3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet1.Week1Day2". При необходимости она может быть перемещена или удалена.
            this.week1Day2TableAdapter.Fill(this.bdNastyaDataSet1.Week1Day2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdNastyaDataSet.Week1Day1". При необходимости она может быть перемещена или удалена.
            this.week1Day1TableAdapter.Fill(this.bdNastyaDataSet.Week1Day1);
            clearSelect();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch(week)
            {
                case 1:
                    SaveWeek1();
                    break;
                case 2:
                    SaveWeek2();
                    break;
                case 3:
                    SaveWeek3();
                    break;
                case 4:
                    SaveWeek4();
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int s;
            string day = "";
            if (comboBox1.SelectedIndex == -1) s = 1;
            else s = comboBox1.SelectedIndex + 1;
            switch (s)
            {
                case 1:
                    day = label1.Text;
                    break;
                case 2:
                    day = label2.Text;
                    break;
                case 3:
                    day = label3.Text;
                    break;
                case 4:
                    day = label4.Text;
                    break;
                case 5:
                    day = label5.Text;
                    break;
                case 6:
                    day = label6.Text;
                    break;
            }
            Form3 newForm = new Form3(s, day, week);
            newForm.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f = new Form2();
            f.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            week = week + 1;
            if (week == 3) label7.Text = week + "-тья неделя";
            else label7.Text = week + "-ая неделя";
            weeks = weeks + 7;
            button5.Enabled = true;
            switch (week)
            {
                case 1:
                    Week1();
                    break;
                case 2:
                    Week2();
                    break;
                case 3:
                    Week3();
                    break;
                case 4:
                    Week4();
                    break;
                case 5:
                    Week5();
                    break;
            }
            if (week == 5) button4.Enabled = false;
            clearSelect();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            week = week - 1;
            weeks = weeks - 7;
            if (week == 3) label7.Text = week + "-тья неделя";
            else label7.Text = week + "-ая неделя";
            button4.Enabled = true;
            switch (week)
            {
                case 1:
                    Week1();
                    break;
                case 2:
                    Week2();
                    break;
                case 3:
                    Week3();
                    break;
                case 4:
                    Week4();
                    break;
                case 5:
                    Week5();
                    break;
            }
            clearSelect();
            if (week == 1) button5.Enabled = false;
        }
        public void Week1()
        {
            var days1 = db.Weeks1Days1;
            var days2 = db.Weeks1Days2;
            var days3 = db.Weeks1Days3;
            var days4 = db.Weeks1Days4;
            var days5 = db.Weeks1Days5;
            var days6 = db.Weeks1Days6;
            label1.Text = "Понедельник " + (weeks + 1) + ".09.19";
            label2.Text = "Вторник " + (weeks + 2) + ".09.19";
            label3.Text = "Среда " + (weeks + 3) + ".09.19";
            label4.Text = "Четверг " + (weeks + 4) + ".09.19";
            label5.Text = "Пятница " + (weeks + 5) + ".09.19";
            label6.Text = "Суббота " + (weeks + 6) + ".09.19";
            dataGridView1.DataSource = week1Day1BindingSource;
            dataGridView2.DataSource = week1Day2BindingSource;
            dataGridView3.DataSource = week1Day3BindingSource;
            dataGridView4.DataSource = week1Day4BindingSource;
            dataGridView5.DataSource = week1Day5BindingSource;
            dataGridView6.DataSource = week1Day6BindingSource;
            
        }
        public void Week2()
        {
            var days1 = db.Weeks2Days1;
            var days2 = db.Weeks2Days2;
            var days3 = db.Weeks2Days3;
            var days4 = db.Weeks2Days4;
            var days5 = db.Weeks2Days5;
            var days6 = db.Weeks2Days6;
            label1.Text = "Понедельник " + (weeks + 1) + ".09.19";
            label2.Text = "Вторник " + (weeks + 2) + ".09.19";
            label3.Text = "Среда " + (weeks + 3) + ".09.19";
            label4.Text = "Четверг " + (weeks + 4) + ".09.19";
            label5.Text = "Пятница " + (weeks + 5) + ".09.19";
            label6.Text = "Суббота " + (weeks + 6) + ".09.19";

            dataGridView1.DataSource = week2Day1BindingSource;
            dataGridView2.DataSource = week2Day2BindingSource;
            dataGridView3.DataSource = week2Day3BindingSource;
            dataGridView4.DataSource = week2Day4BindingSource;
            dataGridView5.DataSource = week2Day5BindingSource;
            dataGridView6.DataSource = week2Day6BindingSource;
        }
        public void Week3()
        {
            var days1 = db.Weeks3Days1;
            var days2 = db.Weeks3Days2;
            var days3 = db.Weeks3Days3;
            var days4 = db.Weeks3Days4;
            var days5 = db.Weeks3Days5;
            var days6 = db.Weeks3Days6;;
            label1.Text = "Понедельник " + (weeks + 1) + ".09.19";
            label2.Text = "Вторник " + (weeks + 2) + ".09.19";
            label3.Text = "Среда " + (weeks + 3) + ".09.19";
            label4.Text = "Четверг " + (weeks + 4) + ".09.19";
            label5.Text = "Пятница " + (weeks + 5) + ".09.19";
            label6.Text = "Суббота " + (weeks + 6) + ".09.19";

            dataGridView1.DataSource = week3Day1BindingSource;
            dataGridView2.DataSource = week3Day2BindingSource;
            dataGridView3.DataSource = week3Day3BindingSource;
            dataGridView4.DataSource = week3Day4BindingSource;
            dataGridView5.DataSource = week3Day5BindingSource;
            dataGridView6.DataSource = week3Day6BindingSource;
        }
        public void Week4()
        {
            var days1 = db.Weeks4Days1;
            var days2 = db.Weeks4Days2;
            var days3 = db.Weeks4Days3;
            var days4 = db.Weeks4Days4;
            var days5 = db.Weeks4Days5;
            var days6 = db.Weeks4Days6;
            label1.Text = "Понедельник " + (weeks + 1) + ".09.19";
            label2.Text = "Вторник " + (weeks + 2) + ".09.19";
            label3.Text = "Среда " + (weeks + 3) + ".09.19";
            label4.Text = "Четверг " + (weeks + 4) + ".09.19";
            label5.Text = "Пятница " + (weeks + 5) + ".09.19";
            label6.Text = "Суббота " + (weeks + 6) + ".09.19";

            dataGridView1.DataSource = week4Day1BindingSource;
            dataGridView2.DataSource = week4Day2BindingSource;
            dataGridView3.DataSource = week4Day3BindingSource;
            dataGridView4.DataSource = week4Day4BindingSource;
            dataGridView5.DataSource = week4Day5BindingSource;
            dataGridView6.DataSource = week4Day6BindingSource;
        }
        public void Week5()
        {
            label1.Text = "Понедельник " + (weeks + 1) + ".09.19";
            label2.Text = "Вторник " + (weeks + 2) + ".09.19";
            label3.Text = "Среда " + (weeks + 3) + ".09.19";
            label4.Text = "Четверг " + 1 + ".10.19";
            label5.Text = "Пятница " + 2 + ".10.19";
            label6.Text = "Суббота " + 3 + ".10.19";

            dataGridView1.DataSource = new object();
            dataGridView2.DataSource = new object();
            dataGridView3.DataSource = new object();
            dataGridView4.DataSource = new object();
            dataGridView5.DataSource = new object();
            dataGridView6.DataSource = new object();
            
                   
        }
        public void SaveWeek1()
        {
            var days1 = db.Weeks1Days1;
            var days2 = db.Weeks1Days2;
            var days3 = db.Weeks1Days3;
            var days4 = db.Weeks1Days4;
            var days5 = db.Weeks1Days5;
            var days6 = db.Weeks1Days6;
            int i = 0;
            foreach (Week1Day1 d in days1)
            {
                    d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork1"].Value.ToString();
                    d.Assessment = dataGridView1.Rows[i].Cells["Assessment1"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week1Day2 d in days2)
            {
                    d.HomeWork = dataGridView2.Rows[i].Cells["HomeWork2"].Value.ToString();
                    d.Assessment = dataGridView2.Rows[i].Cells["Assessment2"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week1Day3 d in days3)
            {
                    d.HomeWork = dataGridView3.Rows[i].Cells["HomeWork3"].Value.ToString();
                    d.Assessment = dataGridView3.Rows[i].Cells["Assessment3"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week1Day4 d in days4)
            {
                    d.HomeWork = dataGridView4.Rows[i].Cells["HomeWork4"].Value.ToString();
                    d.Assessment = dataGridView4.Rows[i].Cells["Assessment4"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week1Day5 d in days5)
            {
                    d.HomeWork = dataGridView5.Rows[i].Cells["HomeWork5"].Value.ToString();
                    d.Assessment = dataGridView5.Rows[i].Cells["Assessment5"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week1Day6 d in days6)
            {
                    d.HomeWork = dataGridView6.Rows[i].Cells["HomeWork6"].Value.ToString();
                    d.Assessment = dataGridView6.Rows[i].Cells["Assessment6"].Value.ToString();
                i++;
            }
            db.SaveChanges();
            MessageBox.Show("Сохранение изменений прошло успешно");
        }
        public void SaveWeek2()
        {
            var days1 = db.Weeks2Days1;
            var days2 = db.Weeks2Days2;
            var days3 = db.Weeks2Days3;
            var days4 = db.Weeks2Days4;
            var days5 = db.Weeks2Days5;
            var days6 = db.Weeks2Days6;
            int i = 0;
            foreach (Week2Day1 d in days1)
            {
                    d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork1"].Value.ToString();
                    d.Assessment = dataGridView1.Rows[i].Cells["Assessment1"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week2Day2 d in days2)
            {
                    d.HomeWork = dataGridView2.Rows[i].Cells["HomeWork2"].Value.ToString();
                    d.Assessment = dataGridView2.Rows[i].Cells["Assessment2"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week2Day3 d in days3)
            {
                    d.HomeWork = dataGridView3.Rows[i].Cells["HomeWork3"].Value.ToString();
                    d.Assessment = dataGridView3.Rows[i].Cells["Assessment3"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week2Day4 d in days4)
            {

                    d.HomeWork = dataGridView4.Rows[i].Cells["HomeWork4"].Value.ToString();
                    d.Assessment = dataGridView4.Rows[i].Cells["Assessment4"].Value.ToString();

                i++;
            }
            i = 0;
            foreach (Week2Day5 d in days5)
            {
                    d.HomeWork = dataGridView5.Rows[i].Cells["HomeWork5"].Value.ToString();
                    d.Assessment = dataGridView5.Rows[i].Cells["Assessment5"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week2Day6 d in days6)
            {
                    d.HomeWork = dataGridView6.Rows[i].Cells["HomeWork6"].Value.ToString();
                    d.Assessment = dataGridView6.Rows[i].Cells["Assessment6"].Value.ToString();
                i++;
            }
            db.SaveChanges();
            MessageBox.Show("Сохранение изменений прошло успешно");
        }
        public void SaveWeek3()
        {
            var days1 = db.Weeks3Days1;
            var days2 = db.Weeks3Days2;
            var days3 = db.Weeks3Days3;
            var days4 = db.Weeks3Days4;
            var days5 = db.Weeks3Days5;
            var days6 = db.Weeks3Days6;
            int i = 0;
            foreach (Week3Day1 d in days1)
            {
                    d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork1"].Value.ToString();
                    d.Assessment = dataGridView1.Rows[i].Cells["Assessment1"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week3Day2 d in days2)
            {
                    d.HomeWork = dataGridView2.Rows[i].Cells["HomeWork2"].Value.ToString();
                    d.Assessment = dataGridView2.Rows[i].Cells["Assessment2"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week3Day3 d in days3)
            {
                    d.HomeWork = dataGridView3.Rows[i].Cells["HomeWork3"].Value.ToString();
                    d.Assessment = dataGridView3.Rows[i].Cells["Assessment3"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week3Day4 d in days4)
            {
                    d.HomeWork = dataGridView4.Rows[i].Cells["HomeWork4"].Value.ToString();
                    d.Assessment = dataGridView4.Rows[i].Cells["Assessment4"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week3Day5 d in days5)
            {
                    d.HomeWork = dataGridView5.Rows[i].Cells["HomeWork5"].Value.ToString();
                    d.Assessment = dataGridView5.Rows[i].Cells["Assessment5"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week3Day6 d in days6)
            {
                    d.HomeWork = dataGridView6.Rows[i].Cells["HomeWork6"].Value.ToString();
                    d.Assessment = dataGridView6.Rows[i].Cells["Assessment6"].Value.ToString();
                i++;
            }
            db.SaveChanges();
            MessageBox.Show("Сохранение изменений прошло успешно");
        }
        public void SaveWeek4()
        {
            var days1 = db.Weeks4Days1;
            var days2 = db.Weeks4Days2;
            var days3 = db.Weeks4Days3;
            var days4 = db.Weeks4Days4;
            var days5 = db.Weeks4Days5;
            var days6 = db.Weeks4Days6;
            int i = 0;
            foreach (Week4Day1 d in days1)
            {
                    d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork1"].Value.ToString();
                    d.Assessment = dataGridView1.Rows[i].Cells["Assessment1"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week4Day2 d in days2)
            {
                    d.HomeWork = dataGridView2.Rows[i].Cells["HomeWork2"].Value.ToString();
                    d.Assessment = dataGridView2.Rows[i].Cells["Assessment2"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week4Day3 d in days3)
            {
                    d.HomeWork = dataGridView3.Rows[i].Cells["HomeWork3"].Value.ToString();
                    d.Assessment = dataGridView3.Rows[i].Cells["Assessment3"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week4Day4 d in days4)
            {
                    d.HomeWork = dataGridView4.Rows[i].Cells["HomeWork4"].Value.ToString();
                    d.Assessment = dataGridView4.Rows[i].Cells["Assessment4"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week4Day5 d in days5)
            {
                    d.HomeWork = dataGridView5.Rows[i].Cells["HomeWork5"].Value.ToString();
                    d.Assessment = dataGridView5.Rows[i].Cells["Assessment5"].Value.ToString();
                i++;
            }
            i = 0;
            foreach (Week4Day6 d in days6)
            {
                    d.HomeWork = dataGridView6.Rows[i].Cells["HomeWork6"].Value.ToString();
                    d.Assessment = dataGridView6.Rows[i].Cells["Assessment6"].Value.ToString();
                i++;
            }
            db.SaveChanges();
            MessageBox.Show("Сохранение изменений прошло успешно");
        }

    }
}
