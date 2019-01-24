using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace XF_Overlay
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Rg.Plugins.Popupを使わない場合
        async void OnOverlay(object sender, EventArgs e)
        {
            bglayer.IsVisible = true;
            frame.IsVisible = true;
            await Task.Delay(2000);
            bglayer.IsVisible = false;
            frame.IsVisible = false;
        }

        //Rg.Plugins.Popupを使う場合
        async void Rg(object sender, EventArgs e)
        {
            var page = new LoadingPopupPage();
            await PopupNavigation.Instance.PushAsync(page);
            await Task.Delay(2000);
            await PopupNavigation.Instance.PopAsync();
        }

    }
}
