using System;
using System.Windows.Forms;

namespace OOP.Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // FirstClass nesnesinin yeni bir örneğini aldık(instance)
            FirstClass fc = new FirstClass();

            #region Açıklama


            //fc.Equals(); => nesnenin birebir eşitlik duruma bakar
            // string tip=  fc.GetType().ToString(); // => OOP.Class.FirstClass
            //fc.GetHashCode() => ram asdresini teslim eder
            //fc.ToString()  => string' çevirme  eğer fc.ToString() değerini mb içerisinde gösteriseniz size, namespace+nesneAdi yani OOP.Class.FirstClass, yaaaani :) GetType() değerini döner default olarak. ama değiştirebilirsiniz :)

            //MessageBox.Show(fc.GetHashCode().ToString());
            //MessageBox.Show(fc.GetType().ToString());
            //MessageBox.Show(fc.ToString()); 
            #endregion

            #region Örnek

            /*
            string FirstName = txtAd.Text;
            string LastName = txtSoyad.Text;
            string Phone = txtTelefon.Text;
            int Age = int.Parse(txtYas.Text);
            int Weight = int.Parse(txtKilo.Text);


            MessageBox.Show($"Personelin Adı : {FirstName}\nPersonelin Soyadı : {LastName}\nPersonelin Telefonu : {Phone}\nPersonelin Yaşı : {Age}\nPersonelin Kilosu : {Weight}");
            */ 
            #endregion

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            FirstClass fc = new FirstClass();
            fc.FirstName = txtAd.Text;
            fc.LastName = txtSoyad.Text;
            fc.Phone = txtTelefon.Text;
            //fc.Age = int.Parse(txtYas.Text);
            fc.Weight = int.Parse(txtKilo.Text);


            MessageBox.Show($"Personelin Adı : {fc.FirstName}\nPersonelin Soyadı : {fc.LastName}\nPersonelin Telefonu : {fc.Phone}\nPersonelin Yaşı : 1\nPersonelin Kilosu : {fc.Weight}");
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstClass fc = new FirstClass();
            fc.FirstName = txtAd.Text;
            fc.LastName = txtSoyad.Text;
            fc.Phone = txtTelefon.Text;
            fc.Age = int.Parse(txtYas.Text);
            fc.Weight = int.Parse(txtKilo.Text);


            MessageBox.Show($"Personelin Adı : {fc.FirstName}\nPersonelin Soyadı : {fc.LastName}\nPersonelin Telefonu : {fc.Phone}\nPersonelin Yaşı : {fc.Age}\nPersonelin Kilosu : {fc.Weight}");
        }
    }
}
