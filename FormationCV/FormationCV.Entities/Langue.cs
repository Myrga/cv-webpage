using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Entities
{
    public class Langue
    {
        public int Id { get; set; }
        public string Label { get; set; }
        // Propriété de navigation
        public CV CV { get; set; }        
        // Clé étrangère
        public int CVId { get; set; }
        public Niveau Niveau { get; set; }

    }
}
