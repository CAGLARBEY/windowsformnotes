namespace useruygulama
{
    public partial class Form1 : Form
    {
        public static string[] İsimler = new string[128];
        public static string[] Parolalar = new string[128];
        public static int userIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string İsim = textBox1.Text;
            string Parola = textBox2.Text;
            dataGridView1.Rows.Add(İsim, Parola, DateTime.Now);
            İsimler[userIndex] = İsim;
            Parolalar[userIndex] = Parola;
            userIndex++;

            MessageBox.Show("İsim kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            /* Form 2 göster*/
            form2.Show();

            /* form1 gizle*/
            this.Hide();

        }
    }
}
