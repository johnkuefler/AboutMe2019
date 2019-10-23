using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeNew
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<string> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<string>();

            Skills.Add("Typing");
            Skills.Add("Talking");
            Skills.Add("Coding");

            skillsList.ItemsSource = this.Skills;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            this.Skills.Add(newSkillEntry.Text);

            skillsList.ItemsSource = this.Skills;

            newSkillEntry.Text = "";
        }
    }
}