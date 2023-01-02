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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Slider_Toggle.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ucSlider.UC_SliderToggled += Main_SliderToggle;
            // reference: https://stackoverflow.com/a/7880901/6908282
        }

        private void Main_SliderToggle(object sender, EventArgs e)
        {
            // reference: https://stackoverflow.com/a/7880901/6908282
            bool ischecked = (bool)((e as RoutedEventArgs).Source as CheckBox).IsChecked;
            string checkboxStatus = ischecked ? "Checked" : "Unchecked";
            ucSlider.SliderText = checkboxStatus;
            // MessageBox.Show(checkboxStatus);
        }
    }
}
