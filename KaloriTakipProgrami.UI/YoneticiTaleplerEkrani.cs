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
    public partial class YoneticiTaleplerEkrani : Form
    {
        public YoneticiTaleplerEkrani()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//geri tuşu bir önceki sayfaya gönderiyor
        }
    }
}
