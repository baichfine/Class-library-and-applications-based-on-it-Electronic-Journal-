using System;
using System.Windows.Forms;

namespace NastyaKrivonogova
{
        public partial class Form2 : Form
        {
        public static Form1 Form1;
        public Form2()
            {
                InitializeComponent();
            }

       private void Form2_Load(object sender, EventArgs e)
       { 
       }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(false);
            newForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(true);
            newForm.Show();
            this.Hide();
        }
    }
}
