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
using static TURİZM_ACENTESI_SISTEMI__TAS_.adminpanel;
using static TURİZM_ACENTESI_SISTEMI__TAS_.musteripanel;

namespace TURİZM_ACENTESI_SISTEMI__TAS_
{
    public partial class adminpanel : Form
    {

        public adminpanel()
        {
            InitializeComponent();
        }

        public class Tour
        {
            public int TourId { get; set; }
            public string TourName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string DepartureLocation { get; set; }
            public string ArrivalLocation { get; set; }
            public int Capacity { get; set; }
            public string TourStatus { get; set; }
        }
        public Tour[] tours = new Tour[1000];

        public int tursayaci = 0;

        public List<Tour> listtours = new List<Tour>();
        public class Bilet
        {
            public int BiletId { get; set; }
            public int TourId { get; set; }
            public string Durumu { get; set; }
            public string Fiyat { get; set; }
        }
        public Bilet[] bilets = new Bilet[1000];

        public int biletsayaci = 0;


        private int turidolsuturucu()
        {
            return new Random().Next(10000, 99999);
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

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


            listView4.Columns.Add("Bilet ID", 60);
            listView4.Columns.Add("Tur ID", 65);
            listView4.Columns.Add("Bilet Fiyatı", 100);
            listView4.Columns.Add("Bilet Durumu", 100);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tourName = turaditext.Text;
            DateTime startDate = baslangictarihipic.Value;
            DateTime endDate = bitistarihipic.Value;
            string departureLocation = baslangickonum.Text;
            string arrivalLocation = bitiskonum.Text;
            int capacity = Convert.ToInt32(kapasitemiz.Value);
            string tourStatus = "Aktif"; // Varsayılan olarak tur aktif durumda

            // Tur nesnesini oluşturuyoruz
            Tour yenitur = new Tour
            {
                TourId = turidolsuturucu(),
                TourName = tourName,
                StartDate = startDate,
                EndDate = endDate,
                DepartureLocation = departureLocation,
                ArrivalLocation = arrivalLocation,
                Capacity = capacity,
                TourStatus = tourStatus
            };

            turuarrayaekle(yenitur);

        }
        private void tumturlarilistele()
        {
            listView1.Items.Clear();


            // Tüm turları gezerek ListView'a ekleyin
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

        private void tumbiletlerilistele()
        {
            listView3.Items.Clear();

            foreach (var bilet in bilets)
            {
                if (bilet != null)
                {
                    string[] biletbilgsi = { bilet.BiletId.ToString(), bilet.TourId.ToString(), bilet.Fiyat, bilet.Durumu };
                    ListViewItem item = new ListViewItem(biletbilgsi);
                    listView3.Items.Add(item);
                }
            }
        }

        private void turuarrayaekle(Tour tour)
        {
            if (tursayaci >= tours.Length)
            {
                MessageBox.Show("Tur Ekleme Sınırına Ulaştınız");  // Çökmeler sisteme ağır gelme durumları olmasın diye güvenlik amaçlı koyuldu
                return;
            }
            tours[tursayaci++] = tour;
            MessageBox.Show("Tur Eklendi Tur ID: " + tour.TourId);
            tumturlarilistele();
        }

        private void biletiarrayaekle(Bilet bilet)
        {
            if (biletsayaci >= bilets.Length)
            {
  // Çökmeler sisteme ağır gelme durumları olmasın diye güvenlik amaçlı koyuldu
                return;
            }
            bilets[biletsayaci++] = bilet;

            tumturlarilistele();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tumturlarilistele();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tumturlarilistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tour silinecekTur = Array.Find(tours, t => t != null && t.TourId == Convert.ToInt32(silincekturidtexrt.Text));

            if (silinecekTur != null)
            {
                for (int i = 0; i < tours.Length; i++)
                {
                    if (tours[i] != null && tours[i].TourId == Convert.ToInt32(silincekturidtexrt.Text))
                    {
                        tours[i] = null;
                        tursayaci--;
                        MessageBox.Show("Tur Silindi! Kaldırılan Tur ID: " + Convert.ToInt32(silincekturidtexrt.Text));
                        tumturlarilistele();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Belirtilen Tur ID'si ile eşleşen tur bulunamadı.");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < biletadedidonguu.Value; i++)
            {
                Bilet yenibilet = new Bilet
                {
                    TourId = Convert.ToInt32(biletalturid.Text),
                    BiletId = turidolsuturucu(),
                    Durumu = "Alınabilir",
                    Fiyat = biletalfiyat.Text
                };
                
                biletiarrayaekle(yenibilet);
            tumbiletlerilistele();
                MessageBox.Show("Bilet Eklendi");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bilet silinecekbilet = Array.Find(bilets, t => t != null && t.BiletId == Convert.ToInt32(silinecekbiletid.Text));

            if (silinecekbilet != null)
            {
                for (int i = 0; i < bilets.Length; i++)
                {
                    if (bilets[i] != null && bilets[i].BiletId == Convert.ToInt32(silinecekbiletid.Text))
                    {
                        bilets[i] = null;
                        biletsayaci--;
                        MessageBox.Show("Bilet Silindi! Kaldırılan Bilet ID: " + Convert.ToInt32(silinecekbiletid.Text));
                        tumbiletlerilistele();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Belirtilen Bilet ID'si ile eşleşen bilet bulunamadı.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();

            foreach (var bilet in bilets)
            {
                if (bilet != null &&
                    (string.IsNullOrEmpty(biletaramabiletidsi.Text) || bilet.BiletId.ToString().ToLower().Contains(biletaramabiletidsi.Text.ToLower())) &&
                    (string.IsNullOrEmpty(biletaramaturidsi.Text) || bilet.TourId.ToString().ToLower().Contains(biletaramaturidsi.Text.ToLower())) &&
                    (string.IsNullOrEmpty(biletdurmucombo.Text) || bilet.Durumu.ToLower().Contains(biletdurmucombo.Text.ToLower())))
                {
                    ListViewItem item = new ListViewItem(bilet.BiletId.ToString());
                    item.SubItems.Add(bilet.TourId.ToString());
                    item.SubItems.Add(bilet.Fiyat);
                    item.SubItems.Add(bilet.Durumu);

                    listView4.Items.Add(item);
                }
            }
        }

        private void biletdurmucombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
