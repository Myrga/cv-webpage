using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCV.Front.ViewModels
{
    public class CVVM
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public DateTime DateDeNaissance { get; set; }
        [Required]
        public int? NumeroDeRue { get; set; }
        [Required]
        public string Rue { get; set; }
        [Required]
        public int? CodePostal { get; set; }
        [Required]
        public string Commune { get; set; }
        [Required]
        public bool Permis { get; set; }
        [Required]
        public string Titre { get; set; }
        public string Erreur { get; set; }

        public IEnumerable<CompetenceVM> Competences { get; set; }
        public IEnumerable<ExperienceVM> Experiences { get; set; }
        public IEnumerable<FormationVM> Formations { get; set; }
        public IEnumerable<LangueVM> Langues { get; set; }
    }
}
