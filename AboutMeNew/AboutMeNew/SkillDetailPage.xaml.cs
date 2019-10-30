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
    public partial class SkillDetailPage : ContentPage
    {
        private SkillItem skillOnPage;

        public SkillDetailPage(SkillItem skill)
        {
            InitializeComponent();

            this.skillOnPage = skill;

            this.skillImage.Source = skillOnPage.Icon;
            this.skillLabel.Text = skillOnPage.Name;
            this.descriptionLabel.Text = skillOnPage.Description;
        }
    }
}