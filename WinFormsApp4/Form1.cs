namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int vize, final,p;
            string tc, dogumtarihi, numara;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            p=Convert.ToInt32(textBox5.Text);
            vize=Convert.ToInt16(textBox3.Text);
            final=Convert.ToInt16(textBox4.Text);
            tc = maskedTextBox2.Text;
            numara = maskedTextBox1.Text;
            dogumtarihi=dateTimePicker1.Text;


            ortalama=(vize*0.20)+(final*0.50)/100+(p*0.30);
            label9.Text=ortalama.ToString();
            richTextBox1.Text=("Ad: " + ad + "\n" + "Soyad: " + soyad + "\n" + "numara = " + numara + "\n" + "tc= " + tc + "\n" + "vize= " + vize + " \n" + "final= " + final + "\n" + "ORTALAMA = " +ortalama);
 
            


        }
    }
}
