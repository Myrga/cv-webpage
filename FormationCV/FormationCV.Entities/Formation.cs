using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Entities
{
    public class Formation
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Ecole { get; set; }
        public string Description { get; set; }
        public string Intitule { get; set; }
        public string Diplome { get; set; }
        public CV CV { get; set; }
        public int CVId { get; set; }
    }
}
