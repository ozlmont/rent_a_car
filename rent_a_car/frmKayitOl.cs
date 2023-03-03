using rent_a_car.ORM.Context;
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
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void btn_Kayit_Ol_Click(object sender, EventArgs e)
        {
            Musteri musteris = new Musteri()
            {
                Adi = txt_Name.Text,
                Soyadi = txt_Surname.Text,
                TC = txt_TC.Text,
                Sifre = txt_Sifre.Text,
                EhliyetNo = txt_EhliyetNo.Text,
                Telefon = txt_Telefon.Text,
                Email = txt_EMail.Text,
                Adres = txt_Adres.Text,
                Role = cb_Role.Text
            };
            db.Musteris.Add(musteris);
            db.SaveChanges();
            MessageBox.Show("Kayıt İşleminiz Başarıyla Tamamlanmıştır.");
            this.Hide();
            frmKullaniciGirisi frmKullaniciGirisi = new frmKullaniciGirisi();
            frmKullaniciGirisi.Show();

        }
    }
}
