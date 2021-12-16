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
using ConsoleApp3testjson;
using Newtonsoft.Json;
using System.Threading;
using WpfAppProjet.Model;
using System.Diagnostics;
using WpfAppProjet.ViewModel;
using System.Net.Sockets;

namespace WpfAppProjet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string destination;
        public string src;
        public string extension;
        int i = 0;
        
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
            this.destination = dest;
            return this.destination;
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
        }

        List<SaveWork> SWork = new List<SaveWork>();
        static string jsonString;
        static JsonSerializer serializer = new JsonSerializer();
        List<string> dest_sequential = new List<string>();
        private void Button_create(object sender, RoutedEventArgs e)
        {
            this.i += 1;
            string name = "Save";
            name += " " + i.ToString();
            MessageBox.Show("");
            var data = new Save { Save_Name = name, Save_Src = src, Save_Dest = destination };
            SaveGrid.Items.Add(data);
            src = src.Replace(@"\", "/");
            destination = destination.Replace(@"\", "/");

            SaveWork u1 = new SaveWork
            {
                SaveName = name,
                Source = src,
                Target = destination

            };

            SWork.Add(u1);
            Tab2.IsEnabled = true;
            dest_sequential.Add(destination);
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

        bool Checked;
        private void Button_unique_play(object sender, RoutedEventArgs e)
        {
            Process[] process = Process.GetProcessesByName("calculator");
            if (process.Length > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                if (Encrypt.IsChecked is true)
                {
                     Checked = true;
                }
                else
                {
                    Checked = false;
                }

                _Inputs inp1 = new _Inputs();

                var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

                using (StreamReader r = new StreamReader(projectDirectory + @"\temp\test.json"))
                {
                    string json = r.ReadToEnd();
                    List<SaveWork> items = JsonConvert.DeserializeObject<List<SaveWork>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        string Name = item.SaveName;
                        string saveWork = GetSelectedCellValue();
                        if (Name == saveWork)
                        {
                            string source = item.Source;
                            string destination = item.Target;
                            string savename = item.SaveName;
                            inp1.Source(source);
                            inp1.Destination(destination);
                            inp1.SetName(savename);
                            string dest = inp1.GetDest();
                            string src = inp1.GetSource();
                            string name = inp1.GetName();
                            Logs log = new Logs();

                            string path = projectDirectory + @"\temp\logIRT.json";
                            if (File.Exists(path))
                            {

                            }
                            else
                            {
                                log.CreateLogI(path);
                            }

                            Data copy = new Data();
                            copy.Copy(src, dest, name, Checked, extensions, dest_sequential, server_started);
                        }
                        else if (Name == null)
                        {

                        }
                    }
                }
            }
        }

        int j = -1;
        private void Button_unique_pause(object sender, RoutedEventArgs e)
        {
            j++;
            while (j is 0)
            {
            }
            j = -1;
        }
        private void Button_unique_stop(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", $"/c taskkill /IM WpfAppProjet.exe");
        }

        private void Button_multiple_play(object sender, RoutedEventArgs e)
        {
            Process[] process = Process.GetProcessesByName("calculator");
            if (process.Length > 0)
            {
                MessageBox.Show("");
            }
            else
            {
                _Inputs inp1 = new _Inputs();

                var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

                using (StreamReader r = new StreamReader(projectDirectory + @"\temp\test.json"))
                {
                    string json = r.ReadToEnd();
                    List<SaveWork> items = JsonConvert.DeserializeObject<List<SaveWork>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        string source = item.Source;
                        string destination = item.Target;
                        string savename = item.SaveName;
                        inp1.Source(source);
                        inp1.Destination(destination);
                        inp1.SetName(savename);
                        string dest = inp1.GetDest();
                        string src = inp1.GetSource();
                        string name = inp1.GetName();

                        Logs log = new Logs();
                        string path = projectDirectory + @"\temp\logIRT.json";
                        if (File.Exists(path))
                        {

                        }
                        else
                        {
                            log.CreateLogI(path);
                        }

                        Data copy = new Data();
                        copy.Copy(src, dest, name, Checked, extensions, dest_sequential, server_started);
                    }
                }
            }    
        }
        
        private void Button_multiple_pause(object sender, RoutedEventArgs e)
        {
            j++;
            while (j is 0)
            {
            }
            j = -1;
        }
        private void Button_multiple_stop(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", $"/c taskkill /IM WpfAppProjet.exe");
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
            Encrypt.Content = "Crypté";
            add.Content = "Ajouter";
            Select.Content = "Selectionner";
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
            Encrypt.Content = "Crypted";
            add.Content = "Add";
            Select.Content = "Select";
            FR.IsEnabled = true;
            EN.IsEnabled = false;
        }

        private void Tab2_GotFocus(object sender, RoutedEventArgs e)
        {
            jsonString = JsonConvert.SerializeObject(SWork, Formatting.Indented);

            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

            using (var streamWriter = new StreamWriter(projectDirectory + @"\temp\test.json")) 
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonString));
                }
            }
        }

        //button extensions
        private void ExtensionAdd(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(Extension.Text.Insert(0,"."));
        }

        List<string> extensions = new List<string>();

        private void Selected_ext(object sender, RoutedEventArgs e)
        {
            string extension = ListBox.Items[ListBox.Items.IndexOf(ListBox.SelectedItem)].ToString();
            extensions.Add(extension);
            UPlay.IsEnabled = true;
            SPlay.IsEnabled = true;
        }

        private void Encrypt_Checked(object sender, RoutedEventArgs e)
        {
            UPlay.IsEnabled = false;
            SPlay.IsEnabled = false;
        }

        private void Encrypt_Unchecked(object sender, RoutedEventArgs e)
        {
            UPlay.IsEnabled = true;
            SPlay.IsEnabled = true;
        }

        bool server_started = false;
        private void ServerConnect_Click(object sender, RoutedEventArgs e)
        {
            server_started = true;
        }

        private void ServerDisconnect_Click(object sender, RoutedEventArgs e)
        {
            server_started = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Miss.IsVisible)
            {
                Miss.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("ceci est un easter egg");
                Miss.Visibility = Visibility.Visible;
            }
        }
    }
}