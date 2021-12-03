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
using Projet_progsys;
using System.Collections;
using System.Data;


namespace WpfAppProjet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string dest;
        public string src;
        int i = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        public string SetSrc()
        {
            string src = txtEditor_source.Text;
            this.src = src;
            return this.src;
        }

        public string SetDest()
        {
            string dest = txtEditor_dest.Text;
            this.dest = dest;
            return this.dest;
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
            SetSrc();
            //string src = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
        }

        private void btnOpenFile_dest(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ValidateNames = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FileName = "Folder Selection.";
            if (openFileDialog.ShowDialog() == true)
                txtEditor_dest.Text = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
            SetDest();
            //string dest = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
        }

        private void Button_create(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("create");
            string name = "Save";
            name += " " + i.ToString();
            this.i += 1;
            MessageBox.Show(src + " " + dest);
            var data = new Save { Save_Name = name, Save_Src = src, Save_Dest = dest };
            SaveGrid.Items.Add(data);

        }
        public class Save
        {
            public string Save_Name { get; set; }
            public string Save_Src { get; set; }
            public string Save_Dest { get; set; }


        }

        public string GetSelectedCellValue()
        {
            DataGridCellInfo cellInfo = SaveGrid.SelectedCells[0];
            if (cellInfo == null) return null;

            DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
            if (column == null) return null;

            FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
            BindingOperations.SetBinding(element, TagProperty, column.Binding);

            return element.Tag.ToString();
        }

        private void Button_unique_play(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("uplay");
            _Inputs inp1 = new _Inputs();
            inp1.Source();
            inp1.Destination();
            inp1.SetName();
            string dest = inp1.GetDest();
            string src = inp1.GetSource();
            string name = inp1.GetName();
            //MessageBox.Show(dest + " " + src + " " + name);
            Logs log = new Logs();
            string path = "C:/Users/Hanton/Desktop/Tout/logIRT.json";
            if (File.Exists(path))
            {

            }
            else
            {
                log.CreateLogI(path);
            }

            Data copy = new Data();
            copy.Copy(src, dest , name);
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
            btnOpenFile_s.Content = "Source";
            btnOpenFile_d.Content = "Destination";
            create_button.Content = "Créer";
            Usave_placeholder.Content = "Sauvegarde Unique";
            Ssave_placeholder.Content = "Sauvegarde séquentielle";
            UPlay.Content = "Lancer";
            UPause.Content = "Pause";
            USTop.Content = "Stop";
            SPlay.Content = "Lancer";
            SPause.Content = "Pause";
            SStop.Content = "Stop";
            Language_placeholder.Content = "Selectionnez la langue";
            FR.Content = "Français";
            EN.Content = "English";
            tab1.Header = "Création de sauvegarde";
            Tab2.Header = "Gestion de sauvegarde";
            tab3.Header = "Paramètres";
            FR.IsEnabled = false;
            EN.IsEnabled = true;
        }

        private void Button_language_english(object sender, RoutedEventArgs e)
        {
            btnOpenFile_s.Content = "Source";
            btnOpenFile_d.Content = "Destination";
            create_button.Content = "Create";
            Usave_placeholder.Content = "Unique Save";
            Ssave_placeholder.Content = "Sequential Save";
            UPlay.Content = "Start";
            UPause.Content = "Pause";
            USTop.Content = "Stop";
            SPlay.Content = "Start";
            SPause.Content = "Pause";
            SStop.Content = "Stop";
            Language_placeholder.Content = "Select your language";
            FR.Content = "French";
            EN.Content = "English";
            tab1.Header = "Save Setup";
            Tab2.Header = "Save Worker";
            tab3.Header = "Settings";
            FR.IsEnabled = true;
            EN.IsEnabled = false;
        }
    }
}