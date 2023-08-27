using System;
using System.Text;
using System.Threading.Tasks;
// untuk membuat system menggunakan border-radius seperti
// membuat kotak menjadi halus
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {



        // ini adalah sebuah variabel pada angka pertama dan juga angka kedua
        // serta operator aritmatika dan juga hasil dari sebuah variabel
        private decimal Input1 = 0.0m;
        private decimal Input2 = 0.0m;
        private decimal Hasil = 0.0m;
        private string opr = "+";


        public calculator()
        {
            InitializeComponent();
            /*this.FormBorderStyle = FormBorderStyle.None;*/
        }



        private void nol_btn_Click(object sender, EventArgs e)
        {

            // jika tombol di klik maka angka memuncukan angka 0
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "0";
            }
            // jika sebuah angka adalah 0 pada awalnya maka pada calculator
            // tidak akan berubah angkanya hanya 0 saja
            else
            {
                Hasil_TextBox.Text += "0";
            }
        }

        private void koma_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah tombol , di klik maka angka akan menghasilkan sebuah koma
            if (!Hasil_TextBox.Text.Contains(","))
            {
                Hasil_TextBox.Text += ",";
            }
        }

        private void satu_btn_Click(object sender, EventArgs e)
        {
            // jika sebuah timbol 1 di klik maka akan menghasilkan angka 1 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "1";
            }
            else
            {
                Hasil_TextBox.Text += "1";
            }
        }

        private void dua_btn_Click(object sender, EventArgs e)
        {
            // jika sebuah timbol 2 di klik maka akan menghasilkan angka 2
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "2";
            }
            else
            {
                Hasil_TextBox.Text += "2";
            }
        }

        private void tiga_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 3 di klik maka akan menghasilkan angka 3
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "3";
            }
            else
            {
                Hasil_TextBox.Text += "3";
            }
        }

        private void empat_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 4 di klik maka akan menghasilkan angka 4 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "4";
            }
            else
            {
                Hasil_TextBox.Text += "4";
            }
        }

        private void lima_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 5 di klik maka akan menghasilkan angka 5 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "5";
            }
            else
            {
                Hasil_TextBox.Text += "5";
            }
        }

        private void enam_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 6 di klik maka akan menghasilkan angka 6 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "6";
            }
            else
            {
                Hasil_TextBox.Text += "6";
            }
        }

        private void tujuh_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 7 di klik maka akan menghasilkan angka 7 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "7";
            }
            else
            {
                Hasil_TextBox.Text += "7";
            }
        }

        private void delapan_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 8 di klik maka akan menghasilkan angka 8 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "8";
            }
            else
            {
                Hasil_TextBox.Text += "8";
            }
        }

        private void sembilan_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah timbol 9 di klik maka akan menghasilkan angka 9 
            // meskipun angka itu sudah 0 tetap akan bertambah
            if (Hasil_TextBox.Text == "0")
            {
                Hasil_TextBox.Text = "9";
            }
            else
            {
                Hasil_TextBox.Text += "9";
            }
        }

        private void Minuplus_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah tombol minplus di pencet maka sebuah angka
            // maka angka tersebut menjadi minus ataupun plus
            if (Hasil_TextBox.Text.Contains("-"))
            {
                Hasil_TextBox.Text = Hasil_TextBox.Text.Trim('-');
            }
            else
            {
                Hasil_TextBox.Text = "-" + Hasil_TextBox.Text;
            }
        }

        private void kurang_btn_Click(object sender, EventArgs e)
        {


            // jika sebuah operator "-" maka akan mengoperatorkan angka 
            // menjadi berkurang
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "-";
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah operator "+" maka akan mengoperatorkan angka 
            // menjadi Bertambah
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "+";
        }

        private void kali_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah operator "*" maka akan mengoperatorkan angka 
            // menjadi dikalikan
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "*";
        }

        private void bagi_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah operator "/" maka akan mengoperatorkan angka 
            // menjadi dibagikan
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "/";
        }

        private void persen_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah operator "%" maka akan mengoperatorkan angka 
            // menjadi dipersenkan
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "%";
        }

        private void pangkat_btn_Click(object sender, EventArgs e)
        {

            // jika sebuah operator "^" maka akan mengoperatorkan angka 
            // menjadi dipangkatkan
            Input1 = decimal.Parse(Hasil_TextBox.Text);
            Hasil_TextBox.Clear();
            opr = "^";
        }



        private void samadengan_btn_Click(object sender, EventArgs e)
        {

            // switch difungsikan sebagai hasil dari sebuah operator jumlah
            // yang di hasilkan dari segala operator
            switch (opr)
            {
                case "+":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = Input1 + Input2;
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;

                case "-":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = Input1 - Input2;
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;

                case "*":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = Input1 * Input2;
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;

                case "/":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = Input1 / Input2;
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;

                case "%":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = Input1 % Input2;
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;



                // rumus perpangkatan  
                case "^":
                    Input2 = decimal.Parse(Hasil_TextBox.Text);
                    Hasil = (decimal)Math.Pow((double)Input1, (double)Input2);
                    Hasil_TextBox.Text = Hasil.ToString();
                    break;

            }
        }

        private void backspace_btn_Click(object sender, EventArgs e)
        {

            // Jika ada angka maka akan menghilangkan 1 angka tersebut
            if (Hasil_TextBox.Text.Length > 0)
            {
                Hasil_TextBox.Text = Hasil_TextBox.Text.Substring(0, Hasil_TextBox.Text.Length - 1);
            }

            // Jika tidak ada angka lagi, ubah menjadi "0"
            if (Hasil_TextBox.Text.Length == 0)
            {
                Hasil_TextBox.Text = "0";
            }
        }




        private void clear_btn_Click(object sender, EventArgs e)
        {

            // jika dipencet maka semua angka akan menjadi 0 atau ter reset
            Input1 = 0.0m;
            Input2 = 0.0m;
            Hasil_TextBox.Text = "0";
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void Hasil_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}