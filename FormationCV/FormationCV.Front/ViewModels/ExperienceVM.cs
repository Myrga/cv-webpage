using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCV.Front.ViewModels
{
    public class ExperienceVM
    {
        public int Id { get; set; }
        public int CvId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Entreprise { get; set; }
        public string Poste { get; set; }
        public string Description{ get; set; }
    }
}
