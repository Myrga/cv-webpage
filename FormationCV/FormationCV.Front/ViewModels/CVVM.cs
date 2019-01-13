using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCV.Front.ViewModels
{
    public class CVVM
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
        public string Erreur { get; set; }

        public IEnumerable<CompetenceVM> Competences { get; set; }
        public IEnumerable<ExperienceVM> Experiences { get; set; }
        public IEnumerable<FormationVM> Formations { get; set; }
        public IEnumerable<LangueVM> Langues { get; set; }
    }
}
