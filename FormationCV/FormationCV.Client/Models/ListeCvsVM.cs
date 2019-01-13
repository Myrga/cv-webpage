using FormationCV.Data;
using FormationCV.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Client.Models
{
    public class ListeCvsVM // DATACONTEXT
    {       

        public ObservableCollection<CV> CVs { get; set; }
        public ListeCvsVM()
        {
            this.CVs = new ObservableCollection<CV>();
        }


        public void AjoutCV()
        {
            Context context = new Context(); // FOrmationCV.Data.Context
            context.CVs.Add(new CV
            {
                Titre = "Nouveau CV..."
            });

            context.SaveChanges();
            this.RafraichirListeCvs();
        }

        public void RafraichirListeCvs()
        {
            Context context = new Context();
            this.CVs.Clear(); // ObservableCollection
            foreach(var cv in context.CVs)
            {
                this.CVs.Add(cv); // ajout à l'ObservableCollection
            }
        }

        public void SupprimerCV(CV cv)
        {
            // A tester, peut ne pas marcher pour plusieurs raisons
            Context context = new Context();
            context.CVs.Remove(cv);
            context.SaveChanges();
            this.RafraichirListeCvs();
        }

    }
}
