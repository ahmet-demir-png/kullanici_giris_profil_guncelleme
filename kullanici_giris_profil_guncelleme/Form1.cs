using System.Data;
using System.Data.SqlClient;

namespace kullanici_giris_profil_guncelleme
{
    public partial class anasayfa : Form
    {

        // Local servis aðýna baðlantý alaný
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=OPTER;Initial Catalog=veritabanina_fotograrft_yukleme;Integrated Security=True");

        public static DataTable verilerigoster(string veriler)
        {

            SqlDataAdapter SQLadapter = new SqlDataAdapter(veriler, baglanti);
            DataTable dt = new DataTable();
            SQLadapter.Fill(dt);
            return dt;

        }

        public anasayfa()
        {

            InitializeComponent();
            // Form yüklendiðinde giriþ grubu görünür olsun
            groupBox_giris.Visible = true;
            groupBox_kayit_ol.Visible = false;
            pictureBox_giris.Visible = false;

        }

        private void radiobutton_giris_CheckedChanged(object sender, EventArgs e)
        {

            groupBox_giris.Visible = true;
            groupBox_kayit_ol.Visible = false;
            pictureBox_giris.Visible = false;

        }

        private void radiobutton_kayit_ol_CheckedChanged(object sender, EventArgs e)
        {

            groupBox_giris.Visible = false;
            groupBox_kayit_ol.Visible = true;
            pictureBox_giris.Visible = false;

        }

        // Fotoðrafý Dönüþtürme alaný :)
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        // Fotoðraf yükleme alaný
        private void button_kayit_ol_fotograf_ekle_Click(object sender, EventArgs e)
        {

            OpenFileDialog OfD = new OpenFileDialog();
            OfD.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg";
            OfD.Multiselect = false;
            if (OfD.ShowDialog() == DialogResult.OK)
            {
                pictureBox_kayit_ol.Image = new Bitmap(OfD.FileName);
                pictureBox_kayit_ol.BackgroundImage = new Bitmap(OfD.FileName);
                pictureBox_kayit_ol.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox_kayit_ol.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void pictureBox_kayit_ol_Click(object sender, EventArgs e)
        {

            OpenFileDialog OfD = new OpenFileDialog();
            OfD.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg";
            OfD.Multiselect = false;
            if (OfD.ShowDialog() == DialogResult.OK)
            {
                pictureBox_kayit_ol.Image = new Bitmap(OfD.FileName);
                pictureBox_kayit_ol.BackgroundImage = new Bitmap(OfD.FileName);
                pictureBox_kayit_ol.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox_kayit_ol.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void button_kayit_ol_kayit_ol_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.groupBox_kayit_ol.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).Count() > 0)
                {
                    this.groupBox_kayit_ol.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => { MessageBox.Show(f.Name + " boþ býrakýlamaz"); });
                }
                else
                {
                    if (textBox_kayit_ol_sifre.Text == textBox_kayit_ol_sifre_onayla.Text)
                    {
                        SqlCommand ekle = new SqlCommand("insert into fotograft_bilgi_girisi " +
                            "(kullanici_adi, sifre, image_adi, image) " +
                            "values " +
                            "(@kullanici_adi, @sifre, @image_adi, @image)", baglanti);
                        baglanti.Open();
                        ekle.Parameters.AddWithValue("@kullanici_adi", textBox_kayit_ol_kullanici_adi.Text);
                        ekle.Parameters.AddWithValue("@sifre", textBox_kayit_ol_sifre.Text);
                        ekle.Parameters.AddWithValue("@image_adi", Guid.NewGuid());
                        //ekle.Parameters.AddWithValue("@image_adi", fotograf_pictureBox.Text);

                        byte[] image = ConvertImageToBytes(pictureBox_kayit_ol.Image);
                        ekle.Parameters.AddWithValue("@image", image);
                        ekle.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Þifre onayý baþarýsýz");
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button_giris_giris_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.groupBox_giris.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).Count() > 0)
                {
                    this.groupBox_giris.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => { MessageBox.Show(f.Name + " boþ býrakýlamaz"); });
                }
                else
                {
                    baglanti.Open();
                    string kullaniciadionay = textBox_giris_kullanici_adi.Text;
                    string sifreonay = textBox_giris_sifre.Text;
                    SqlCommand giris = new SqlCommand("select * from fotograft_bilgi_girisi  where kullanici_adi = " + "'" + kullaniciadionay + "'" + " and sifre = " + "'" + sifreonay + "'", baglanti);
                    giris.ExecuteNonQuery();
                    SqlDataReader oku = giris.ExecuteReader();

                    if (oku.Read())
                    {
                        string kullaniciadionayli = oku["kullanici_adi"].ToString();
                        string sifreonayli = oku["sifre"].ToString();


                        if (textBox_giris_kullanici_adi.Text == kullaniciadionayli && textBox_giris_sifre.Text == sifreonayli)
                        {
                            MessageBox.Show("Ýþlem baþarýlý");
                            pictureBox_giris.Visible = true;
                            pictureBox_giris.Image = ConvertByteArrayToImage((byte[])oku["image"]);
                            pictureBox_giris.BackgroundImage = ConvertByteArrayToImage((byte[])oku["image"]);
                            pictureBox_giris.BackgroundImageLayout = ImageLayout.Zoom;
                            pictureBox_giris.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            MessageBox.Show("Kullanýcý adý ve þifre  onayý baþarýsýz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriþ baþarýsýz");
                    }
                    oku.Close();
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}