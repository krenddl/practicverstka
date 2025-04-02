using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using verstkapracticwpf.Models;

namespace verstkapracticwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public byte[] Avatar {  get; set; } 
        public List<Education> Education { get; set; } =  new List<Education>();
        public MainWindow()
        {
            InitializeComponent();
            DG.ItemsSource = Education;
            Avatar = File.ReadAllBytes(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "man.jpg"));
            DataContext = this;
        }
        private void BAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg | *.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                Avatar = File.ReadAllBytes(dialog.FileName);
                               
            }
            DataContext = null;
            DataContext = this;
        }
    }
}
