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
        public ObservableCollection<SkillItem> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<SkillItem>();

            SkillItem codingSkill = new SkillItem();
            codingSkill.Name = "Coding";
            codingSkill.Description = "sadness to elation and back every 5 minutes";
            codingSkill.Icon = "https://img.icons8.com/cotton/2x/laptop-coding.png";

            SkillItem publicSpeakingSkill = new SkillItem();
            publicSpeakingSkill.Name = "Public Speaking";
            publicSpeakingSkill.Description = "Talking a lot";
            publicSpeakingSkill.Icon = "https://cdn0.iconfinder.com/data/icons/usa-politics/67/24-512.png";

            SkillItem bowlingSkill = new SkillItem();
            bowlingSkill.Name = "Bowling";
            bowlingSkill.Description = "Throwing a ball at pins";
            bowlingSkill.Icon = "https://image.flaticon.com/icons/png/512/125/125521.png";

            Skills.Add(publicSpeakingSkill);
            Skills.Add(bowlingSkill);
            Skills.Add(codingSkill);

            skillsList.ItemsSource = this.Skills;
        }

        private void SkillsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            SkillItem selectedSkill = e.SelectedItem as SkillItem;

            (sender as ListView).SelectedItem = null;

            Navigation.PushAsync(new SkillDetailPage(selectedSkill));

            // DisplayAlert("Description", selectedSkill.Description, "Ok");
        }
    }
}