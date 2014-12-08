using System.Windows;
using System.Windows.Input;

namespace LabelClick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MyViewModel();
        }

        private void lblNext_TouchDown(object sender, TouchEventArgs e)
        {
            MessageBox.Show("Clicked from Code Behind");
        }
    }
}
