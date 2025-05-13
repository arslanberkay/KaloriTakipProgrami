using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Models
{
    public class Ogun
    {
        public int Id { get; set; }
        public string OgunAdi { get; set; } //Kahvaltı,öğle,akşam,ara öğün vb.

        public List<OgunYemek> OgunYemekler { get; set; } // 1 öğün BİRDEN FAZLA ogunyemekte olabilir.
    }
}
