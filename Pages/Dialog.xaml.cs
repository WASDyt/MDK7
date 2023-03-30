using Microsoft.Win32;
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

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Page
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.txt";
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = "D:\\";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == false)
                return;
            string filename = ofd.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            MessageBox.Show($"Файл {filename} открыт. Пароль: {fileText}");
            
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        { 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt";
            //sfd.InitialDirectory = "..";
            if (sfd.ShowDialog() == false)
            {
                return;
            }
            string filename = sfd.FileName;
            //string content = LstText.SelectedValue.ToString();
            string content = this.Name;
            System.IO.File.WriteAllText(filename, $"МДК 01.01 Диалоговые окна + {content}");
        }
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)

                printDialog.PrintVisual();
            


        }
        private void btnFont_Click(object sender, RoutedEventArgs e)
        {
            //FontDialog
        }
        private void btnColor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
