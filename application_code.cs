SqlConnection baglanti = new SqlConnection("Data Source=LENOVO-PC;Initial Catalog=Bilgi Küpü Veritabanı;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        void temizleme()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        










private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State==ConnectionState.Closed)
	        {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO OGRENCILER(Ogrenci_numara,Adres_id,Ogrenci_Adi,Ogrenci_Soyadi,Cinsiyet_id,Sinif_Adi,Veli_id) VALUES('" + int.Parse(textBox1.Text) + "','" + int.Parse(textBox2.Text) + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + int.Parse(textBox7.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                temizleme();
                MessageBox.Show("KAYIT TAMAMLANDI");
	        }
        }

        void listeleme()  
             {
                if (baglanti.State==ConnectionState.Closed)
	            {
		         baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from OGRENCILER";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "OGRENCILER");
                dataGridView1.DataSource = ds.Tables["OGRENCILER"];
                baglanti.Close();
	             }
           }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?","DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from OGRENCILER where Ogrenci_numara=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("KAYIT BAŞARIYLA SİLİNMİŞTİR");
                    listeleme();
                }
            }
           
        }

        
private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE OGRENCILER SET Ogrenci_numara='" + int.Parse(textBox1.Text) + "',Adres_id='" + int.Parse(textBox2.Text) + "',Ogrenci_Adi='" + textBox3.Text + "',Ogrenci_Soyadi='" + textBox4.Text + "',Cinsiyet_id='" + textBox5.Text + "',Sinif_Adi='" + textBox6.Text + "',Veli_id='" + int.Parse(textBox7.Text) + "' where Ogrenci_numara=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                temizleme();
                MessageBox.Show("GÜNCELLEME TAMAMLANDI");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from OGRENCILER where Ogrenci_numara=@num";
                cmd.Parameters.AddWithValue("@num", int.Parse(textBox8.Text));
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "OGRENCILER");
                dataGridView1.DataSource = ds.Tables["OGRENCILER"];
                baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       




 private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from OGRENCILER where Sinif_Adi=@sinif";
                cmd.Parameters.AddWithValue("@sinif", textBox9.Text);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "OGRENCILER");
                dataGridView1.DataSource = ds.Tables["OGRENCILER"];
                baglanti.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from OGRENCILER";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "OGRENCILER");
                dataGridView1.DataSource = ds.Tables["OGRENCILER"];
                baglanti.Close();
            }
        }
