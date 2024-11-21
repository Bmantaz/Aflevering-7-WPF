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

namespace Personlig_Profil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Profilbillede - venstre sektion
            string relativePath1 = "Assets/Profil Billede.jpg";
            string fullPath1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath1);
            var imageSource1 = new BitmapImage(new Uri(fullPath1, UriKind.Absolute));
            ProfilBillede.Source = imageSource1;

            // Krapyl logo - midtersektion
            string relativePath2 = "Assets/Krapyl Logo.jpg";
            string fullPath2 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath2);
            var imageSource2 = new BitmapImage(new Uri(fullPath2, UriKind.Absolute));
            KrapylLogoJpg.Source = imageSource2;
        }



        


        private void LidtOmMig_Click(object sender, RoutedEventArgs e) // LidtOmMig knappens funktion
        {
            MessageBox.Show("Hej! Mit navn er Bjarke Pallisgaard Andersen!\nJeg bor i Ådum med min kæreste, Lisa og hendes to børn.\n" +
                 
                "\nJeg har lavet denne WPF app for at vise, at jeg kan sætte en lille smule kode sammen, selvom det ikke lige frem er  mit modersmål, endnu ;)\n" +
                "\nJeg er 32 år gammel, og jeg er på udkig efter en læreplads som Datateknikker med speciale i programmering, eller forkortet: Software-\n");



        }


        private void Krapyl_Click(object sender, RoutedEventArgs e) // LidtOmMig knappens funktion
        {
            MessageBox.Show("Det her er mit 'Hjertebarn', mit band Krapyl. https://www.youtube.com/results?search_query=krapyl+song+13.  ");

        }
    }
}
