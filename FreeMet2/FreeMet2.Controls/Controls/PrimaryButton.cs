using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FreeMet2.Controls
{
    public class CircleButton : Button
    {
        private static int maxCornerRadius = 10;

        public static DependencyProperty CornerRadiusProperty;
        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        static CircleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleButton), new FrameworkPropertyMetadata(typeof(CircleButton)));

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.Inherits = true;
            metadata.DefaultValue = 5;
            metadata.AffectsMeasure = true;
            metadata.PropertyChangedCallback += (d, e) => { };
            CornerRadiusProperty = DependencyProperty.Register("CornerRadius",
                typeof(int), typeof(CircleButton), metadata,
                o =>
                {
                    int radius = (int)o;
                    if (radius >= 0 && radius <= maxCornerRadius) return true;
                    return false;
                });

        }

        public CircleButton() : base()
        {
            this.Style = this.FindResource("CircleButton") as Style;
            this.ApplyTemplate();
        }
    }
}
