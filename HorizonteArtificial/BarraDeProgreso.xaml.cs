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

namespace HorizonteArtificial
{
    /// <summary>
    /// Interaction logic for BarraDeProgreso.xaml
    /// </summary>
    public partial class BarraDeProgreso : UserControl
    {
        // Uso de dependencia para guardar información. Esto permite animaciones, estilos, bindings, etc...
        public static readonly DependencyProperty ItemSourcePropiedad =
            DependencyProperty.Register("ItemSource", typeof(Uri), typeof(BarraDeProgreso));
        public Uri ItemSourceUri
        {
            get { return (Uri)GetValue(ItemSourcePropiedad); }
            set { SetValue(ItemSourcePropiedad, value); }
        }

        public static readonly DependencyProperty TextoPropiedad =
            DependencyProperty.Register("Texto", typeof(string), typeof(BarraDeProgreso));
        public string Texto
        {
            get { return (string) GetValue(TextoPropiedad); }
            set { SetValue(TextoPropiedad, value); }
        }

        public static readonly DependencyProperty ProgresoPropiedad =
            DependencyProperty.Register("Progreso", typeof(double), typeof(BarraDeProgreso));
        public double Progreso
        {
            get { return (double) GetValue(ProgresoPropiedad); }
            set { SetValue(ProgresoPropiedad, value); }
        }        

        public static readonly DependencyProperty VisibilidadPropiedad =
            DependencyProperty.Register("Visibilidad", typeof(Visibility), typeof(BarraDeProgreso));
        public Visibility Visibilidad
        {
            get { return (Visibility) GetValue(VisibilidadPropiedad); }
            set { SetValue(VisibilidadPropiedad, value); }
        }

        public static readonly DependencyProperty PrograsoIndeterminadoPropiedad =
            DependencyProperty.Register("ProgresoIndeterminado", typeof(bool), typeof(BarraDeProgreso));
        public bool PrograsoIndeterminado
        {
            get { return (bool)GetValue(PrograsoIndeterminadoPropiedad); }
            set { SetValue(PrograsoIndeterminadoPropiedad, value); }
        }

        public static readonly DependencyProperty ProgressForegroundBrushPropiedad =
            DependencyProperty.Register("ProgressForeground", typeof(SolidColorBrush), typeof(BarraDeProgreso));
        public SolidColorBrush ProgressForegroundBrush
        {
            get { return (SolidColorBrush)GetValue(ProgressForegroundBrushPropiedad); }
            set { SetValue(ProgressForegroundBrushPropiedad, value); }
        }

        public static readonly DependencyProperty ProgressBackgroundBrushPropiedad =
            DependencyProperty.Register("ProgressBackground", typeof(SolidColorBrush), typeof(BarraDeProgreso));
        public SolidColorBrush ProgressBackgroundBrush
        {
            get { return (SolidColorBrush)GetValue(ProgressBackgroundBrushPropiedad); }
            set { SetValue(ProgressBackgroundBrushPropiedad, value); }
        }
        
        public BarraDeProgreso()
        {
            InitializeComponent();
        }
    }
}
