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

                "\nJeg er 32 år gammel, og jeg er på udkig efter en læreplads som Datateknikker med speciale i programmering, eller forkortet: Software-udvikler\n" +

                "\nJeg har lavet denne WPF app for at vise, at jeg kan sætte en lille smule kode sammen, denne app vil løbende udvikle sig med mere design og mere infomation omkring mig\n" +
                "\n"
                
                
                );



        }


        private void Krapyl_Click(object sender, RoutedEventArgs e)
        {
            // URL til YouTube
            string url = "https://linktr.ee/Krapyl";

            try
            {
                // Åbner linket i standardbrowseren
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Kræves for at åbne URL'en
                });
            }
            catch (Exception ex)
            {
                // Fejlhåndtering, hvis noget går galt
                MessageBox.Show($"Kunne ikke åbne linket. Fejl: {ex.Message}", "Fejl", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void GitHub_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Bmantaz",
                UseShellExecute = true
            });
        }
        private void Video_Click(object sender, RoutedEventArgs e)
        {
            // Tilføj din logik her, for eksempel:
            MessageBox.Show("Video-knappen blev klikket!");
        }




        private void ShowMediaPlayer_Click(object sender, RoutedEventArgs e)
        {
            // Opret et nyt VideoPlayerWindow og send URI'en til videoen
            VideoPlayerWindow videoWindow = new VideoPlayerWindow("Assets/GenerelAnsøgning.mp4");
            videoWindow.Show();  // Dette åbner vinduet
        }

 


      
    }


}