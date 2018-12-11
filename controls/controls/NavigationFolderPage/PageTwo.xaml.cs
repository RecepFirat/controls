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
	public partial class PageTwo : ContentPage
	{
		public PageTwo ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)//bekletme ıslemı async oldugundan fonk da async oluyo 

        {
            //await Navigation.PushModalAsync(new PageOne()); //iceriye yazdıgım async metodu awaitle bekletıyourum

            //navigation mantıgında ıse
            await Navigation.PushAsync(new PageThree());
        }
    }
}