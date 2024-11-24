using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personlig_Profil
{
    public partial class VideoPlayerWindow : Window
    {
        public VideoPlayerWindow(string videoUri)
        {
            InitializeComponent();

            // Sæt videoens URI på MediaElement
            VideoPlayer.Source = new Uri(videoUri, UriKind.RelativeOrAbsolute);
            VideoPlayer.Play();  // Start videoen
        }

        // Play video
        private void PlayVideo(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Play();
        }

        // Pause video
        private void PauseVideo(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Pause();
        }

        // Stop video
        private void StopVideo(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Stop();
            SeekSlider.Value = 0;  // Nulstil slideren
        }

        // Update seek slider position
        private void SeekSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoPlayer.NaturalDuration.HasTimeSpan)
            {
                VideoPlayer.Position = TimeSpan.FromSeconds(SeekSlider.Value);
            }
        }

        // Volume control
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoPlayer.Volume = VolumeSlider.Value;
        }
    }
}