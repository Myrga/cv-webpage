using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Entities
{
    public class CV
    {
        public int Id { get; set; }        
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int NumeroDeRue { get; set; }
        public string Rue { get; set; }
        public int CodePostal { get; set; }
        public string Commune { get; set; }
        public bool Permis { get; set; }
        public string Titre { get; set; }
        public ICollection<Langue> Langues { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Formation> Formations { get; set; }
        public ICollection<Competence> Competences { get; set; }




    }
}
