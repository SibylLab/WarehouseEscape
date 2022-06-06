using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace WarehouseGameplay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpMessageBox : PopupPage
    {
        private string ImageUrl;
        private string PopUpMessage;
        
        public PopUpMessageBox(string imagePath, string popUpMessage)
        {
            InitializeComponent();
            this.ImageUrl = imagePath;
            this.PopUpMessage = popUpMessage;
            
            SetPopUpData();
        }

        private Task SetPopUpData()
        {
            lblMessageText.Text = PopUpMessage.ToString();
            ImgBacgroundPopUp.Source = ImageUrl.ToString();
           
            return Task.CompletedTask;
        }

        private async void CloseButton_Clicked(object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}