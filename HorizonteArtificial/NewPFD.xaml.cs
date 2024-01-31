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
    /// Interaction logic for NewPFD.xaml
    /// </summary>
    public partial class NewPFD : UserControl
    {
        private double _roll;
        private double _pitch;

        [Description("Angulo de pitch"), Category("Condiciones Iniciales")]
        public double roll
        {
            get
            {
                return _roll;
            }

            set
            {
                _roll = value;
                TransformGroup myTransformGroup = new TransformGroup();
                myTransformGroup.Children.Add(new ScaleTransform(1.5, 1.5));
                myTransformGroup.Children.Add(new RotateTransform(_roll));
                Fondo.RenderTransform = myTransformGroup;
            }
        }

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
                Fondo.pitch = _pitch;
            }
        }      

        public NewPFD()
        {
            InitializeComponent();
        }
    }
}
