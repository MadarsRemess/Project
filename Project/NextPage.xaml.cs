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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NextPage : Page
    {
        public NextPage()
        {
            this.InitializeComponent();
        }

        // Switches from 2nd page to mainpage
        public void MainPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Button_Click1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Learn animals and sentences!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Next_0_0(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Dogs play catch.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Next_0_1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Cats play with string.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Next_1_0(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Horses jump over fences.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Next_1_1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Tigers love to hunt.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Sentence1(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Dogs are humans best friend. Cats love to sleep.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private async void Sentence2(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var talk = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await talk.SynthesizeTextToStreamAsync("Horses jump really high. Tigers are very dangerous.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

    } // public class

} // namespace
