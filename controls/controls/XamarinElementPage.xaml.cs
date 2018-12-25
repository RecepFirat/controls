using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamarinElementPage : ContentPage
	{
		public XamarinElementPage ()
		{
			InitializeComponent ();
		}

        private void Benimbutton_Clicked(object sender, EventArgs e)
        {
            myentry.Text = "Buttondan sana birseyler yazdım bro";
            benimlabel.Text = "buttondan labela ulastım bro";
            myslider.Value = 50;
           
          //  mydatapicker.Date = ;//saati olmayan sadece tarih olan bir girdi eklenmesi gerekiuo 
            myTimePicker.Time = new TimeSpan(4, 14,12);

            myswicth.IsToggled = true;
            benimbutton.Text = "Tikladım kirve";


            var mylist = new List<string>();
            mylist.Add("1");
            mylist.Add("2");
            mylist.Add("3");

            myPicker.ItemsSource = mylist.ToList();
        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            myentry.Text = myPicker.SelectedItem.ToString();
        }
    }
}