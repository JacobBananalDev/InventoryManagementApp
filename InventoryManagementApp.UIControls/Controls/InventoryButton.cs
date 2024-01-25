using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementApp.UIControls
{
    public class InventoryButton : Button
    {
        static InventoryButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InventoryButton), new FrameworkPropertyMetadata(typeof(InventoryButton)));
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(InventoryButton), new PropertyMetadata(default(CornerRadius)));

    }
}
