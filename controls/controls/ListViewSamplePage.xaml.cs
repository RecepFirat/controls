using controls.Data;
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
    public partial class ListViewSamplePage : ContentPage
    {
        List<Users> gerceklist=new List<Users>();
        public ListViewSamplePage()
        {
            InitializeComponent();

            var mylist = new List<string> {
                "Tarik",
                "Recep",
                "Tayyip"


            };


            var bindingList = new List<Users>
            { 
                new Users{

                    Userid= "007",
                      UserName="Recep Tayyip",
                         ImageURL="https://avatars3.githubusercontent.com/u/25421894?s=400&v=4",


                },

                new Users{


                    Userid= "008",
                    ImageURL="https://avatars3.githubusercontent.com/u/25421894?s=400&v=4",
                    UserName="firat"

                },

                 new Users{


                    Userid= "009",
                   UserName="firat",
                      ImageURL="https://avatars3.githubusercontent.com/u/25421894?s=400&v=4",
                 },
            };
            //   mylistview.ItemsSource = mylist;
            gerceklist = bindingList;
            mylistview.ItemsSource = gerceklist;
            
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            gerceklist.Add(new Users
            {
                Userid = "019",
                UserName = "firat",
                ImageURL = "https://avatars3.githubusercontent.com/u/25421894?s=400&v=4",
            });
            mylistview.ItemsSource = null;
            mylistview.ItemsSource = gerceklist;
        }

        private void OnDelete_Clicked(object sender, EventArgs e)
        {
            var mymenuitem = (MenuItem)sender;
            var UserID = mymenuitem.CommandParameter.ToString();//useridyi alıyorum
            gerceklist.RemoveAll(x => x.Userid == UserID);
            mylistview.ItemsSource = null;
            mylistview.ItemsSource = gerceklist;
        }

        //islem uzerinde yukleme anımasyonu ııcın
        private async void Mylistview_Refreshing(object sender, EventArgs e)
        {
            mylistview.IsRefreshing = true;

            await Task.Delay(4000);//bu delay kısım iste verinin aktıgı kısım

            //hani veri geldigi ve doldugu zamanda tekrar delayı kaldırabilirsin
            mylistview.IsRefreshing = false;
        }
    }
}