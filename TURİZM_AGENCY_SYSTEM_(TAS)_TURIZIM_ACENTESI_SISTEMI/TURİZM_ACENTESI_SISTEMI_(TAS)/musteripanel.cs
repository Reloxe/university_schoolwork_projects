using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TURİZM_ACENTESI_SISTEMI__TAS_.adminpanel;

namespace TURİZM_ACENTESI_SISTEMI__TAS_
{
    public partial class musteripanel : Form
    {
        public Tour[] tours;

        public Bilet[] bilets;


        public string musterikimlikk = "451267";
        public string musteriadi = "Ahmet";
        public string musterisoyadi = "Mutlu";
        public string musteriyasi = "30";

        public class Revezvebilets
        {
            public int Rezervid { get; set; }
            public int BiletId { get; set; }
            public int TourId { get; set; }
            public string Musterikimlik { get; set; }
            public string Musteriadi { get; set; }
            public string Musterisoyad { get; set; }
            public string Musteriyasi { get; set; }

        }
        public Revezvebilets[] rezervebillets = new Revezvebilets[1000];

        public int rezervcounter = 0;

        public int biletsayaciiii = 0;
        public musteripanel(Tour[] adminTours = null, Bilet[] adminBilets = null)
        {
            InitializeComponent();
            tours = adminTours ?? new Tour[0];   
            bilets = adminBilets ?? new Bilet[0];
        }

        private void tumturlarilistele()
        {
            listView1.Items.Clear();

            foreach (var tour in tours)
            {
                if (tour != null)
                {
                    string[] turbilgisi = { tour.TourId.ToString(), tour.TourName, tour.StartDate.ToShortDateString(), tour.EndDate.ToShortDateString(), tour.DepartureLocation, tour.ArrivalLocation, tour.Capacity.ToString(), tour.TourStatus };
                    ListViewItem item = new ListViewItem(turbilgisi);
                    listView1.Items.Add(item);
                }
            }
        }

        private void biletlistele()
        {
            listView4.Items.Clear();

            foreach (var rezervbilgi in rezervebillets)
            {
                if (rezervbilgi != null)
                {
        string[] turbilgisi = { rezervbilgi.Rezervid.ToString(), rezervbilgi.BiletId.ToString(), rezervbilgi.TourId.ToString(), rezervbilgi.Musterikimlik, rezervbilgi.Musteriadi, rezervbilgi.Musterisoyad, rezervbilgi.Musteriyasi, };
                    ListViewItem item = new ListViewItem(turbilgisi);
                    listView4.Items.Add(item);
                }
            }
        }

        private void musteripanel_Load(object sender, EventArgs e)
        {
            useridsii.Text = musterikimlikk;
            aduserinput.Text = musteriadi;
            soyatinput.Text = musterisoyadi;
            yasinput.Text = musteriyasi;

            listView1.Columns.Add("Tur ID", 60);
            listView1.Columns.Add("Tur Adı", 65);
            listView1.Columns.Add("Başlangıç Tarihi", 100);
            listView1.Columns.Add("Bitiş Tarihi", 100);
            listView1.Columns.Add("Kalkış Konumu", 100);
            listView1.Columns.Add("Varış Konumu", 100);
            listView1.Columns.Add("Kapasite", 80);
            listView1.Columns.Add("Tur Durumu", 100);


            listView2.Columns.Add("Tur ID", 60);
            listView2.Columns.Add("Tur Adı", 65);
            listView2.Columns.Add("Başlangıç Tarihi", 100);
            listView2.Columns.Add("Bitiş Tarihi", 100);
            listView2.Columns.Add("Kalkış Konumu", 100);
            listView2.Columns.Add("Varış Konumu", 100);
            listView2.Columns.Add("Kapasite", 80);
            listView2.Columns.Add("Tur Durumu", 100);



            listView3.Columns.Add("Bilet ID", 60);
            listView3.Columns.Add("Tur ID", 65);
            listView3.Columns.Add("Bilet Fiyatı", 100);
            listView3.Columns.Add("Bilet Durumu", 100);


            listView4.Columns.Add("Rezervasyon ID", 100);
            listView4.Columns.Add("Bilet ID", 60);
            listView4.Columns.Add("Tur ID", 65);
            listView4.Columns.Add("Müşteri ID", 100);
            listView4.Columns.Add("Müşteri Adı", 100);
            listView4.Columns.Add("Müşteri Soyadı", 100);
            listView4.Columns.Add("Müşteri Yaşı", 100);

            tumturlarilistele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            foreach (var tour in tours)
            {
                if (tour != null &&
                    (string.IsNullOrEmpty(aramaturadi.Text) || tour.TourName.ToLower().Contains(aramaturadi.Text.ToLower())) &&
                    (string.IsNullOrEmpty(aramakalkisyeri.Text) || tour.DepartureLocation.ToLower().Contains(aramakalkisyeri.Text.ToLower())) &&
                    (string.IsNullOrEmpty(aramavarisyeri.Text) || tour.ArrivalLocation.ToLower().Contains(aramavarisyeri.Text.ToLower())) &&
                    (string.IsNullOrEmpty(aramaturkapasite.Text) || tour.Capacity.ToString().ToLower().Contains(aramaturkapasite.Text.ToLower())))
                {
                    ListViewItem item = new ListViewItem(tour.TourId.ToString());
                    item.SubItems.Add(tour.TourName);
                    item.SubItems.Add(tour.StartDate.ToShortDateString());
                    item.SubItems.Add(tour.EndDate.ToShortDateString());
                    item.SubItems.Add(tour.DepartureLocation);
                    item.SubItems.Add(tour.ArrivalLocation);
                    item.SubItems.Add(tour.Capacity.ToString());
                    item.SubItems.Add(tour.TourStatus);

                    listView2.Items.Add(item);
                }
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
  
            foreach (var bilet in bilets)
            {
                if (bilet != null && bilet.TourId.ToString().ToLower().Contains(biletbulidtext.Text))
                {
                    string[] biletbilgsi = { bilet.BiletId.ToString(), bilet.TourId.ToString(), bilet.Fiyat, bilet.Durumu };
                    ListViewItem item = new ListViewItem(biletbilgsi);
                    listView3.Items.Add(item);
                }
            }


        }



        private void biletiarrayaekle(Revezvebilets rezervebilet)
        {
            if (rezervcounter >= rezervebillets.Length)
            {
                MessageBox.Show("Sınırına Ulaştınız");  // Çökmeler sisteme ağır gelme durumları olmasın diye güvenlik amaçlı koyuldu
                return;
            }
            rezervebillets[rezervcounter++] = rezervebilet;
            MessageBox.Show("Rezerve edildi rezerve kimliği: " + rezervebilet.Rezervid);
            tumturlarilistele();
            biletlistele();

            Bilet degisilcekbilet = Array.Find(bilets, t => t != null && t.BiletId == rezervebilet.BiletId);

            if (degisilcekbilet != null)
            {
                degisilcekbilet.Durumu = "Satılmış";

            }


        }
        private int turidolsuturucu()
        {
            return new Random().Next(10000, 99999);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var bilet in bilets)
            {
                if (bilet != null && bilet.BiletId.ToString().ToLower().Contains(biletalidsite.Text))
                {
                    // Tur nesnesini oluşturuyoruz
                    Revezvebilets yeniblett = new Revezvebilets
                    {
                        Rezervid = turidolsuturucu(),
                        BiletId = bilet.BiletId,
                        TourId = bilet.TourId,
                        Musterikimlik = musterikimlikk,
                        Musteriadi = musteriadi,
                        Musterisoyad = musterisoyadi,
                        Musteriyasi = musteriyasi,

                    };

                 biletiarrayaekle(yeniblett);

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriadi = aduserinput.Text;
            musterisoyadi = soyatinput.Text;
            musteriyasi = yasinput.Text;

            MessageBox.Show("Bilgiler kaydedildi!");
        }
    }
}
