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
            mylistview.ItemsSource = bindingList;
        }
    }
}