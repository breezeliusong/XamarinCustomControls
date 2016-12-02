using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCustomControls.DataModel;
using XamarinCustomControls.ViewPages;

namespace XamarinCustomControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //MyListView.ItemsSource= DataSource.GetList();
            MyListView0.Items = DataSource.GetList();
            MyListView1.ItemsSource = DataSource.GetSource();
        }

        private async void OnItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ItemsPageXaml(e.SelectedItem));
        }
        private async void OnItemSelect_(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ItemsPageXaml(e.SelectedItem));
        }
    }
}
