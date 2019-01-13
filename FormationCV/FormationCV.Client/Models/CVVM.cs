using FormationCV.Data;
using FormationCV.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Client.Models
{
    public class CVVM : INotifyPropertyChanged
    {
        #region OnPropertyChanged 
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public CVVM()
        {
            this.Langues = new ObservableCollection<Langue>();
            this.CVs = new ObservableCollection<CV>();
        }

        public ObservableCollection<Langue> Langues { get; set; }
        public ObservableCollection<CV> CVs { get; set; }

        public CV CvEnEdition { get; set; }

        public void AjoutCV()
        {
            Context context = new Context();
            var cv = new CV();
            context.CVs.Add(cv);
            context.SaveChanges();

            this.CVs.Add(cv);
        }

        public void RafraichirCV()
        {
            this.CVs.Clear();
            Context context = new Context();
            var cvs = context.CVs.ToList();
            foreach (var cv in cvs)
            {
                this.CVs.Add(cv);
            }
        }








    }
}
