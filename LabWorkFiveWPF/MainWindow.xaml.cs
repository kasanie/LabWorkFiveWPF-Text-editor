using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace LabWorkFiveWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
        Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
        string name;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenText_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text documents (.txt)|*.txt";
            openFileDialog1.ShowDialog();
            name = openFileDialog1.FileName;
            TextBox.Clear();
            TextBox.Text = File.ReadAllText(name);
        }

        private void SaveText_Click(object sender, RoutedEventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text documents (.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            name = saveFileDialog1.FileName;
            File.WriteAllText(name, TextBox.Text);
        }
    }
}
