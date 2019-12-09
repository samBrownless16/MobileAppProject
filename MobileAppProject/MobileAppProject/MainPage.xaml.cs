using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileAppProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadMainScreenImage();
        }

        // Main screen image
        private void LoadMainScreenImage()
        {
            var assembly = typeof(MainPage);
            string imageLocation = "MobileAppProject.Images.quiz_main.png";
            MainImage.Source = ImageSource.FromResource(imageLocation, assembly);
        }

        // Add category page selected to stack and navigate to it
        private void GenKnowledgeBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GenKnowledgeSection());
        }

        private void GeographyBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeographySection());
        }

        private void SportsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SportsSection());
        }
    }
}
