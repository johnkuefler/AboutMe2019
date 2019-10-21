using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeNew
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if (nameEntry.Text == "" || nameEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please enter a name", "OK");
                return;
            }

            if (emailEntry.Text == "" || emailEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please enter an email", "OK");
                return;
            }

            if (questionEntry.Text == "" || questionEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please enter a question", "OK");
                return;
            }

            await DisplayAlert("Thanks!", "Your message was sent", "OK");

            Navigation.PopAsync();
        }
    }
}