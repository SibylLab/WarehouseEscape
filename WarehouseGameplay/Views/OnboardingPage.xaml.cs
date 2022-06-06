using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();
            
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            try
            {
                base.OnSizeAllocated(width, height);
                MyRadialGradient.RadiusX = width * 6;
            }
            catch (Exception)
            {

                throw;
            }
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await FadeBox.FadeTo(1, 500);
                await Navigation.PopModalAsync(false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //MyRadialGradient.RadiusX = this.Width * e.NewValue;
        }
    }
}