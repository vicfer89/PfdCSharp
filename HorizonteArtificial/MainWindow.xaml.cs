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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HorizonteArtificial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PFD1.roll = RollSelector.Value;
            PFD2.RollAngle = RollSelector.Value;
            Progreso.Progreso = RollSelector.Value;
        }

        private void PitchSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PFD1.pitch = PitchSelector.Value;
            PFD2.PitchAngle = PitchSelector.Value;
        }
    }
}
