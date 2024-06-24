using System.Windows;

namespace Task1
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

        private void NewWindowMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new();
            window.Show();
        }

        private void MainWindows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ClosingWindow closingWidow = new();
            closingWidow.ShowDialog();
            if (closingWidow.DialogResult != true)
                e.Cancel = true;
        }
    }
}