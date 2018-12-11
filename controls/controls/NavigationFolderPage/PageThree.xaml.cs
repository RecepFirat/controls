using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace controls.NavigationFolderPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageThree : ContentPage
	{
		public PageThree ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Uyari", "sen artık 3. sayfadasın", "Tamam");
           await Navigation.PopAsync();//geriye gider
        }
    }
}