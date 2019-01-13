using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set;}
        public DateTime? DateFin { get; set; }
        public string Entreprise { get; set; }
        public string Poste { get; set; }
        public string Description { get; set; }
        public CV CV { get; set; }        
        public int CVId { get; set; }
    }
}
