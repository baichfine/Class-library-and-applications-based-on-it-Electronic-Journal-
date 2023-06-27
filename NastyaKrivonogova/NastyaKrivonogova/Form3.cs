using System;
using System.Windows.Forms;
using ClassLibraryKrivonogova;

namespace NastyaKrivonogova
{
    public partial class Form3 : Form
    {
        UserContext db = new UserContext();
        int m;
        int size;
        int week;
        public Form3(int n, string label, int week)
        {
            InitializeComponent();
            ShowDay(n, label, week);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }
        
        public void ShowDay(int n, string label, int weeks)
        {
            m = n;
            week = weeks;
            size = dataGridView1.Rows.Count;
            string number = (n).ToString();
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 50;
            switch (weeks)
            {
                case 1:
                    ChangeWeek1(n, label);
                    break;
                case 2:
                    ChangeWeek2(n, label);
                    break;
                case 3:
                    ChangeWeek3(n, label);
                    break;
                case 4:
                    ChangeWeek4(n, label);
                    break;
                case 5:
                    break;
            }
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            switch (week)
            {
                case 1:
                    AddWeek1();
                    break;
                case 2:
                    AddWeek2();
                    break;
                case 3:
                    AddWeek3();
                    break;
                case 4:
                    AddWeek4();
                    break;
                case 5:
                    break;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (week)
            {
                case 1:
                    DeleteWeek1();
                    break;
                case 2:
                    DeleteWeek2();
                    break;
                case 3:
                    DeleteWeek3();
                    break;
                case 4:
                    DeleteWeek4();
                    break;
                case 5:
                    break;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            switch (week)
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
                case 5:
                    break;
            }
            Form1 f = new Form1(false);
            f.Show();
        }

        public void SaveWeek1()
        {
            int i;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks1Days1;
                    i = 0;
                    foreach (Week1Day1 d in days1)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks1Days2;
                    i = 0;
                    foreach (Week1Day2 d in days2)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks1Days3;
                    i = 0;
                    foreach (Week1Day3 d in days3)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks1Days4;
                    i = 0;
                    foreach (Week1Day4 d in days4)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks1Days5;
                    i = 0;
                    foreach (Week1Day5 d in days5)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks1Days6;
                    i = 0;
                    foreach (Week1Day6 d in days6)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
        }
        public void SaveWeek2()
        {
            int i;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks2Days1;
                    i = 0;
                    foreach (Week2Day1 d in days1)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks2Days2;
                    i = 0;
                    foreach (Week2Day2 d in days2)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks2Days3;
                    i = 0;
                    foreach (Week2Day3 d in days3)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks2Days4;
                    i = 0;
                    foreach (Week2Day4 d in days4)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks2Days5;
                    i = 0;
                    foreach (Week2Day5 d in days5)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks2Days6;
                    i = 0;
                    foreach (Week2Day6 d in days6)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
        }
        public void SaveWeek3()
        {
            int i;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks3Days1;
                    i = 0;
                    foreach (Week3Day1 d in days1)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks3Days2;
                    i = 0;
                    foreach (Week3Day2 d in days2)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks3Days3;
                    i = 0;
                    foreach (Week3Day3 d in days3)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks3Days4;
                    i = 0;
                    foreach (Week3Day4 d in days4)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks3Days5;
                    i = 0;
                    foreach (Week3Day5 d in days5)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks3Days6;
                    i = 0;
                    foreach (Week3Day6 d in days6)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
        }
        public void SaveWeek4()
        {
            int i;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks4Days1;
                    i = 0;
                    foreach (Week4Day1 d in days1)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks4Days2;
                    i = 0;
                    foreach (Week4Day2 d in days2)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks4Days3;
                    i = 0;
                    foreach (Week4Day3 d in days3)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks4Days4;
                    i = 0;
                    foreach (Week4Day4 d in days4)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks4Days5;
                    i = 0;
                    foreach (Week4Day5 d in days5)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks4Days6;
                    i = 0;
                    foreach (Week4Day6 d in days6)
                    {
                        if (dataGridView1.Rows[i].Cells["Subject"].Value != null)
                            d.Subject = dataGridView1.Rows[i].Cells["Subject"].Value.ToString();
                        else d.Subject = "";
                        if (dataGridView1.Rows[i].Cells["HomeWork"].Value != null)
                            d.HomeWork = dataGridView1.Rows[i].Cells["HomeWork"].Value.ToString();
                        else d.HomeWork = "";
                        if (dataGridView1.Rows[i].Cells["Assessment"].Value != null)
                            d.Assessment = dataGridView1.Rows[i].Cells["Assessment"].Value.ToString();
                        else d.Assessment = "";
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
        }

        public void ChangeWeek1(int n, string label)
        {
            int i = 0;
            switch (n)
            {
                case 1:
                    label1.Text = label;
                    var days1 = db.Weeks1Days1;
                    i = 0;
                    foreach (Week1Day1 d in days1)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 2:
                    label1.Text = label;
                    var days2 = db.Weeks1Days2;
                    i = 0;
                    foreach (Week1Day2 d in days2)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 3:
                    label1.Text = label;
                    var days3 = db.Weeks1Days3;
                    i = 0;
                    foreach (Week1Day3 d in days3)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 4:
                    label1.Text = label;
                    var days4 = db.Weeks1Days4;
                    i = 0;
                    foreach (Week1Day4 d in days4)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 5:
                    label1.Text = label;
                    var days5 = db.Weeks1Days5;
                    i = 0;
                    foreach (Week1Day5 d in days5)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 6:
                    label1.Text = label;
                    var days6 = db.Weeks1Days6;
                    i = 0;
                    foreach (Week1Day6 d in days6)
                    {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                            dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                            dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
            }
        }
        public void ChangeWeek2(int n, string label)
        {
            int i = 0;
            switch (n)
            {
                case 1:
                    label1.Text = label;
                    var days1 = db.Weeks2Days1;
                    i = 0;
                    foreach (Week2Day1 d in days1)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 2:
                    label1.Text = label;
                    var days2 = db.Weeks2Days2;
                    i = 0;
                    foreach (Week2Day2 d in days2)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 3:
                    label1.Text = label;
                    var days3 = db.Weeks2Days3;
                    i = 0;
                    foreach (Week2Day3 d in days3)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 4:
                    label1.Text = label;
                    var days4 = db.Weeks2Days4;
                    i = 0;
                    foreach (Week2Day4 d in days4)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 5:
                    label1.Text = label;
                    var days5 = db.Weeks2Days5;
                    i = 0;
                    foreach (Week2Day5 d in days5)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 6:
                    label1.Text = label;
                    var days6 = db.Weeks2Days6;
                    i = 0;
                    foreach (Week2Day6 d in days6)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
            }
        }
        public void ChangeWeek3(int n, string label)
        {
            int i = 0;
            switch (n)
            {
                case 1:
                    label1.Text = label;
                    var days1 = db.Weeks3Days1;
                    i = 0;
                    foreach (Week3Day1 d in days1)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 2:
                    label1.Text = label;
                    var days2 = db.Weeks3Days2;
                    i = 0;
                    foreach (Week3Day2 d in days2)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 3:
                    label1.Text = label;
                    var days3 = db.Weeks3Days3;
                    i = 0;
                    foreach (Week3Day3 d in days3)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 4:
                    label1.Text = label;
                    var days4 = db.Weeks3Days4;
                    i = 0;
                    foreach (Week3Day4 d in days4)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 5:
                    label1.Text = label;
                    var days5 = db.Weeks3Days5;
                    i = 0;
                    foreach (Week3Day5 d in days5)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 6:
                    label1.Text = label;
                    var days6 = db.Weeks3Days6;
                    i = 0;
                    foreach (Week3Day6 d in days6)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
            }
        }
        public void ChangeWeek4(int n, string label)
        {
            int i = 0;
            switch (n)
            {
                case 1:
                    label1.Text = label;
                    var days1 = db.Weeks4Days1;
                    i = 0;
                    foreach (Week4Day1 d in days1)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 2:
                    label1.Text = label;
                    var days2 = db.Weeks4Days2;
                    i = 0;
                    foreach (Week4Day2 d in days2)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 3:
                    label1.Text = label;
                    var days3 = db.Weeks4Days3;
                    i = 0;
                    foreach (Week4Day3 d in days3)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 4:
                    label1.Text = label;
                    var days4 = db.Weeks4Days4;
                    i = 0;
                    foreach (Week4Day4 d in days4)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 5:
                    label1.Text = label;
                    var days5 = db.Weeks4Days5;
                    i = 0;
                    foreach (Week4Day5 d in days5)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
                case 6:
                    label1.Text = label;
                    var days6 = db.Weeks4Days6;
                    i = 0;
                    foreach (Week4Day6 d in days6)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["Subject"].Value = d.Subject;
                        dataGridView1.Rows[i].Cells["HomeWork"].Value = d.HomeWork;
                        dataGridView1.Rows[i].Cells["Assessment"].Value = d.Assessment;
                        i++;
                    }
                    break;
            }
        }

        public void AddWeek1()
        {
            switch (m)
            {
                case 1:
                    Week1Day1 subject1 = new Week1Day1 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days1.Add(subject1);
                    db.SaveChanges();
                    break;
                case 2:
                    Week1Day2 subject2 = new Week1Day2 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days2.Add(subject2);
                    db.SaveChanges();
                    break;
                case 3:
                    Week1Day3 subject3 = new Week1Day3 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days3.Add(subject3);
                    db.SaveChanges();
                    break;
                case 4:
                    Week1Day4 subject4 = new Week1Day4 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days4.Add(subject4);
                    db.SaveChanges();
                    break;
                case 5:
                    Week1Day5 subject5 = new Week1Day5 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days5.Add(subject5);
                    db.SaveChanges();
                    break;
                case 6:
                    Week1Day6 subject6 = new Week1Day6 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks1Days6.Add(subject6);
                    db.SaveChanges();
                    break;
            }
        }
        public void AddWeek2()
        {
            switch (m)
            {
                case 1:
                    Week2Day1 subject1 = new Week2Day1 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days1.Add(subject1);
                    db.SaveChanges();
                    break;
                case 2:
                    Week2Day2 subject2 = new Week2Day2 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days2.Add(subject2);
                    db.SaveChanges();
                    break;
                case 3:
                    Week2Day3 subject3 = new Week2Day3 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days3.Add(subject3);
                    db.SaveChanges();
                    break;
                case 4:
                    Week2Day4 subject4 = new Week2Day4 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days4.Add(subject4);
                    db.SaveChanges();
                    break;
                case 5:
                    Week2Day5 subject5 = new Week2Day5 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days5.Add(subject5);
                    db.SaveChanges();
                    break;
                case 6:
                    Week2Day6 subject6 = new Week2Day6 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks2Days6.Add(subject6);
                    db.SaveChanges();
                    break;
            }
        }
        public void AddWeek3()
        {
            switch (m)
            {
                case 1:
                    Week3Day1 subject1 = new Week3Day1 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days1.Add(subject1);
                    db.SaveChanges();
                    break;
                case 2:
                    Week3Day2 subject2 = new Week3Day2 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days2.Add(subject2);
                    db.SaveChanges();
                    break;
                case 3:
                    Week3Day3 subject3 = new Week3Day3 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days3.Add(subject3);
                    db.SaveChanges();
                    break;
                case 4:
                    Week3Day4 subject4 = new Week3Day4 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days4.Add(subject4);
                    db.SaveChanges();
                    break;
                case 5:
                    Week3Day5 subject5 = new Week3Day5 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days5.Add(subject5);
                    db.SaveChanges();
                    break;
                case 6:
                    Week3Day6 subject6 = new Week3Day6 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks3Days6.Add(subject6);
                    db.SaveChanges();
                    break;
            }
        }
        public void AddWeek4()
        {
            switch (m)
            {
                case 1:
                    Week4Day1 subject1 = new Week4Day1 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days1.Add(subject1);
                    db.SaveChanges();
                    break;
                case 2:
                    Week4Day2 subject2 = new Week4Day2 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days2.Add(subject2);
                    db.SaveChanges();
                    break;
                case 3:
                    Week4Day3 subject3 = new Week4Day3 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days3.Add(subject3);
                    db.SaveChanges();
                    break;
                case 4:
                    Week4Day4 subject4 = new Week4Day4 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days4.Add(subject4);
                    db.SaveChanges();
                    break;
                case 5:
                    Week4Day5 subject5 = new Week4Day5 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days5.Add(subject5);
                    db.SaveChanges();
                    break;
                case 6:
                    Week4Day6 subject6 = new Week4Day6 { Subject = "", HomeWork = "", Assessment = "" };
                    db.Weeks4Days6.Add(subject6);
                    db.SaveChanges();
                    break;
            }
        }

        public void DeleteWeek1()
        {
            int s = dataGridView1.CurrentRow.Index + 1;
            int i = 0;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks1Days1;
                    i = 0;
                    foreach (Week1Day1 d in days1)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days1.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks1Days2;
                    i = 0;
                    foreach (Week1Day2 d in days2)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days2.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks1Days3;
                    i = 0;
                    foreach (Week1Day3 d in days3)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days3.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks1Days4;
                    i = 0;
                    foreach (Week1Day4 d in days4)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days4.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks1Days5;
                    i = 0;
                    foreach (Week1Day5 d in days5)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days5.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks1Days6;
                    i = 0;
                    foreach (Week1Day6 d in days6)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks1Days6.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
            dataGridView1.Rows.RemoveAt(s - 1);
            dataGridView1.Refresh();
        }
        public void DeleteWeek2()
        {
            int s = dataGridView1.CurrentRow.Index + 1;
            int i = 0;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks2Days1;
                    i = 0;
                    foreach (Week2Day1 d in days1)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days1.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks2Days2;
                    i = 0;
                    foreach (Week2Day2 d in days2)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days2.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks2Days3;
                    i = 0;
                    foreach (Week2Day3 d in days3)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days3.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks2Days4;
                    i = 0;
                    foreach (Week2Day4 d in days4)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days4.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks2Days5;
                    i = 0;
                    foreach (Week2Day5 d in days5)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days5.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks2Days6;
                    i = 0;
                    foreach (Week2Day6 d in days6)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks2Days6.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
            dataGridView1.Rows.RemoveAt(s - 1);
            dataGridView1.Refresh();
        }
        public void DeleteWeek3()
        {
            int s = dataGridView1.CurrentRow.Index + 1;
            int i = 0;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks3Days1;
                    i = 0;
                    foreach (Week3Day1 d in days1)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days1.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks3Days2;
                    i = 0;
                    foreach (Week3Day2 d in days2)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days2.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks3Days3;
                    i = 0;
                    foreach (Week3Day3 d in days3)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days3.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks3Days4;
                    i = 0;
                    foreach (Week3Day4 d in days4)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days4.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks3Days5;
                    i = 0;
                    foreach (Week3Day5 d in days5)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days5.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks3Days6;
                    i = 0;
                    foreach (Week3Day6 d in days6)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks3Days6.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
            dataGridView1.Rows.RemoveAt(s - 1);
            dataGridView1.Refresh();
        }
        public void DeleteWeek4()
        {
            int s = dataGridView1.CurrentRow.Index + 1;
            int i = 0;
            switch (m)
            {
                case 1:
                    var days1 = db.Weeks4Days1;
                    i = 0;
                    foreach (Week4Day1 d in days1)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days1.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 2:
                    var days2 = db.Weeks4Days2;
                    i = 0;
                    foreach (Week4Day2 d in days2)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days2.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 3:
                    var days3 = db.Weeks4Days3;
                    i = 0;
                    foreach (Week4Day3 d in days3)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days3.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 4:
                    var days4 = db.Weeks4Days4;
                    i = 0;
                    foreach (Week4Day4 d in days4)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days4.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 5:
                    var days5 = db.Weeks4Days5;
                    i = 0;
                    foreach (Week4Day5 d in days5)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days5.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
                case 6:
                    var days6 = db.Weeks4Days6;
                    i = 0;
                    foreach (Week4Day6 d in days6)
                    {
                        if (s == i + 1)
                        {
                            db.Weeks4Days6.Remove(d);
                        }
                        i++;
                    }
                    db.SaveChanges();
                    break;
            }
            dataGridView1.Rows.RemoveAt(s - 1);
            dataGridView1.Refresh();
        }

    }
}
