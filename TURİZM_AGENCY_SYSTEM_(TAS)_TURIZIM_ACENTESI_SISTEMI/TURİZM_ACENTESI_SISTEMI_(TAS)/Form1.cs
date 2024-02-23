using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TURİZM_ACENTESI_SISTEMI__TAS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        adminpanel adminPanelForm = new adminpanel();
        musteripanel musteripanelform;


        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciaditextbox.Text == "admin" && sifretextbox.Text == "admin123")
            {
                this.Hide();
                adminPanelForm.ShowDialog();
                this.Show();
                
            } else if (kullaniciaditextbox.Text == "musteri" && sifretextbox.Text == "musteri123") {
                this.Hide();
                musteripanelform = new musteripanel(adminPanelForm.tours, adminPanelForm.bilets); 
                musteripanelform.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
