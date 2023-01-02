﻿using System;
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

namespace WPF_Slider_Toggle.UserControls
{
    /// <summary>
    /// Interaction logic for ToggleSliderControl.xaml
    /// </summary>
    public partial class ToggleSliderControl : UserControl
    {
        public ToggleSliderControl()
        {
            InitializeComponent();
        }

        public event EventHandler UC_SliderToggled;

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
            UC_SliderToggled?.Invoke(this, e);
        }
    }
}
