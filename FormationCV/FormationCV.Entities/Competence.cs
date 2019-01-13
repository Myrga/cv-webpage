using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Entities
{
    public class Competence
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public CV CV { get; set; }
        public int CVId { get; set; }
    }
}
