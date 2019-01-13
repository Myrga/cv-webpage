using FormationCV.Client.Models;
using FormationCV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormationCV.Client
{
    /// <summary>
    /// Interaction logic for ListeCVsxaml.xaml
    /// </summary>
    public partial class ListeCVs : Window
    {
        private ListeCvsVM ViewModel
        {
            get { return this.DataContext as ListeCvsVM; }
        }

        public ListeCVs()
        {
            InitializeComponent();
        }

        private void AjoutCV(object sender, RoutedEventArgs e)
        {            
            this.ViewModel.AjoutCV();
        }

        private void SuppressionCV(object sender, RoutedEventArgs e)
        {
            var cv = (sender as Button).DataContext as CV;
            if (cv != null && MessageBox.Show("Etes vous sur ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.ViewModel.SupprimerCV(cv);
            }
        }

        private void RafraichirListe(object sender, RoutedEventArgs e)
        {
            this.ViewModel.RafraichirListeCvs();
        }

        private void DetailsCV(object sender, RoutedEventArgs e)
        {
            var cv = (sender as Button).DataContext as CV;
            MainWindow mw = new MainWindow(cv.Id);

        }
    }
}
