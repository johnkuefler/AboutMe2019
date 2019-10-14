using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AboutMeNew
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void AboutMeButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void SkillsButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}
