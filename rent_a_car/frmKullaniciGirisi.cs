using rent_a_car.ORM.Context;
using rent_a_car.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class frmKullaniciGirisi : Form
    {
        ProjectContext db = new ProjectContext();
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btn_GİRİS_Click(object sender, EventArgs e)
        {
            string tc = "";
            string sifre ="";
            string id = "";
            string role = "";

            List<Musteri> musteri = new List<Musteri>();
            musteri=db.Musteris.Where(x => x.TC == txt_TC.Text).ToList();

            foreach(Musteri musteris in musteri) 
            {
                tc = musteris.TC;
                sifre = musteris.Password;
                id=musteris.Id.ToString();
                role=musteris.Role;
            }
            if (role.ToLower()=="admin" && txt_PAROLA.Text==sifre && txt_TC.Text==tc) 
            {
                frmAdminPanel frmAdminPanel = new frmAdminPanel();
                frmAdminPanel.Show();
                this.Hide();
            }
            else 
            {
                if (tc==txt_TC.Text && !string.IsNullOrEmpty(tc)) 
                {
                    if (sifre==txt_PAROLA.Text && !string.IsNullOrEmpty(sifre)) 
                    {
                        frmMusteriPanel frmMusteriPanel = new frmMusteriPanel();
                        frmMusteriPanel.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Lütfen Doğru Şifre Giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru TC giriniz.");
                }
            }

        }

        private void lbl_Kayit_Ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();
            this.Hide();
        }
    }
}
