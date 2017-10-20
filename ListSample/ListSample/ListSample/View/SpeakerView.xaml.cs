using ListSample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ListSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakerView : ContentPage
    {
        SpeakerViewModel vm;
        public SpeakerView()
        {
            InitializeComponent();
            vm = new SpeakerViewModel();
            //listSpeakers.ItemsSource = vm.Speakers;
            BindingContext = vm;
        }
    }
}