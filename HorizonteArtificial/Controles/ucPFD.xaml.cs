using System;
using System.Collections.Generic;
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
using System.Collections.Generic;
using System.ComponentModel;

namespace HorizonteArtificial.Controles
{
    /// <summary>
    /// Interaction logic for ucPFD.xaml
    /// </summary>
    public partial class ucPFD : UserControl
    {

        private double _PitchAngle;
        private double _RollAngle;
 
        [Description("Angulo de Pitch"), Category("Condiciones Iniciales")]
        public double PitchAngle
        {                  
            get { return _PitchAngle; }
            set
            {
                _PitchAngle = value;
                Background.RenderTransform = ApplyTransform();
            }
        }

        [Description("Angulo de Roll"), Category("Condiciones Iniciales")]
        public double RollAngle
        {
            get { return _RollAngle; }
            set
            {
                _RollAngle = value;
                Background.RenderTransform = ApplyTransform();
            }
        }

        private TransformGroup ApplyTransform()
        {
            TransformGroup myTransformGroup = new TransformGroup();
            myTransformGroup.Children.Add(new TranslateTransform(0, TransformAngleToSizePitch(_PitchAngle)));
            myTransformGroup.Children.Add(new RotateTransform(_RollAngle));
            return myTransformGroup;
        }


        public ucPFD()
        {
            InitializeComponent();
        }

        private double TransformAngleToSizePitch(double angle)
        {
            angle = (angle > 90.0) ? 90.0 : angle;
            angle = (angle < -90.0) ? -90.0 : angle;            
            return (angle * 250.0) / 90.0;
        }
    }
}
