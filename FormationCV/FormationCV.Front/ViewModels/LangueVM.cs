using FormationCV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormationCV.Front.ViewModels
{
    public class LangueVM
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public Niveau Niveau { get; set; }
    }
}
