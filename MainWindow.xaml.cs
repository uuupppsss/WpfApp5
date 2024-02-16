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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ProjectOptions ProjectOptions { get; set; } = new ProjectOptions();
        public MainWindow()
        {

            InitializeComponent();
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                FontFamily_List.Items.Add(fontFamily.Source);
            }
        }

    }
    public class ProjectOptions
    {
        public string FontName { get; set; }
        public int FontSize { get; set; }
        public string FontColour { get; set; }


        public bool IsVolumeOn { get; set; }
        public string SelectedDevice { get; set; }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
