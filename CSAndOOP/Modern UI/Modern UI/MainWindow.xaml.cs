
using System.Windows;
using System.Windows.Input;

namespace Modern_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TEST");
        }
    }
}
