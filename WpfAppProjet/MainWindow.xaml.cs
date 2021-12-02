using System;
using System.IO;
using Microsoft.Win32;
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

namespace WpfAppProjet
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

        //to open file source and dest
        private void btnOpenFile_source(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FileName = "Folder Selection.";
            if (openFileDialog.ShowDialog() == true)
                txtEditor_source.Text = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
        }
        private void btnOpenFile_dest(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.ValidateNames = false;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FileName = "Folder Selection.";
            if (openFileDialog1.ShowDialog() == true)
                txtEditor_dest.Text = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
        }

        private void Button_create(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("create");
        }

        private void Button_unique_play(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("uplay");
        }
        private void Button_unique_pause(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("upause");
        }
        private void Button_unique_stop(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ustop");
        }
        private void Button_multiple_play(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mplay");
        }
        private void Button_multiple_pause(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mpause");
        }
        private void Button_multiple_stop(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mstop");
        }


        private void Button_language_french(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("french");
        }

        private void Button_language_english(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("english");
        }

                   
    }
}
