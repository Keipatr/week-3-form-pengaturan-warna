namespace Tugas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (txtbInput.Text.Contains("ISI:"))
            {
                var isi = txtbInput.Text.Substring(4);
                labelOutput.Text = isi;
            }
            else if(txtbInput.Text.Contains("WARNA:"))
            {
                var isi = txtbInput.Text.Substring(6);
                if (isi.Contains("MERAH"))
                {
                    labelOutput.ForeColor = Color.Red;
                }
                else if (isi.Contains("HIJAU"))
                {
                    labelOutput.ForeColor = Color.Green;
                }
                else if (isi.Contains ("BIRU"))
                {
                    labelOutput.ForeColor = Color.Blue;
                }
                else if (isi.Contains("DEFAULT"))
                {
                    labelOutput.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Syntax tidak terdaftar!");
                }
            }
            else if (txtbInput.Text == "RESTART")
            {
                labelOutput.Text = "[EMPTY]";
                labelOutput.Font = new Font(labelOutput.Font.FontFamily, 20);
            }
            else if (txtbInput.Text == "SHOWN")
            {
                labelOutput.Show();
            }
            else if (txtbInput.Text == "HIDE")
            {
                labelOutput.Hide();
            }
            else if (txtbInput.Text == "BESARKAN")
            {
                float ukurbesar;
                ukurbesar = labelOutput.Font.Size;
                ukurbesar += 1;
                labelOutput.Font = new Font(labelOutput.Font.FontFamily, ukurbesar);
            }
            else if (txtbInput.Text == "KECILKAN")
            {
                float ukurKecil;
                ukurKecil = labelOutput.Font.Size;
                ukurKecil -= 1;
                labelOutput.Font = new Font(labelOutput.Font.FontFamily, ukurKecil);
            }
            else
            {
                MessageBox.Show("Syntax tidak terdaftar!");
            }
        }
    }
}