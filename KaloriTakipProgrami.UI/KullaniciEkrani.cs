using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipProgrami.UI
{
    public partial class KullaniciEkrani : Form
    {
        public KullaniciEkrani()
        {
            InitializeComponent();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciBilgiGuncelleEkrani kullaniciBilgiGuncelleEkrani = new KullaniciBilgiGuncelleEkrani();
            kullaniciBilgiGuncelleEkrani.ShowDialog();
        }

        private void bnOgunBilgileriGoster_Click(object sender, EventArgs e)
        {
            KullaniciOgunBilgiEkrani kullaniciOgunBilgiEkrani= new KullaniciOgunBilgiEkrani();
            kullaniciOgunBilgiEkrani.ShowDialog();
        }
    }
}
