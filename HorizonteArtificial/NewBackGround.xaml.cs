using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// Interaction logic for NewBackGround.xaml
    /// </summary>
    public partial class NewBackGround : UserControl
    {
        private double _pitch;

        [Description("Angulo de pitch"), Category("Condiciones Iniciales")]
        public double pitch
        {
            get
            {
                return _pitch;
            }
            set
            {
                _pitch = value;
                SkySize.Height = new GridLength(150 - _pitch);
                GroundSize.Height = new GridLength(150 + _pitch);
            }
        }

        public NewBackGround()
        {
            InitializeComponent();
        }
    }
}
