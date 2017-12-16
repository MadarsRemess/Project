using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Random rnd = new Random();
            int card = rnd.Next(1, 20);

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Learn animals and spelling!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_0_0(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("DOG, D O G");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    
        private async void Tapped_0_1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("CAT, C A T");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_0_2(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("COW, C O W");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_1_0(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("HORSE, H O R S E");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_1_1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("DONKEY, D O N K E Y");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_1_2(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("PARROT, P A R R O T");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_2_0(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("LION, L I O N");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_2_1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("TIGER, T I G E R");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Tapped_2_2(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("PANDA, P A N D A");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

    }
}
