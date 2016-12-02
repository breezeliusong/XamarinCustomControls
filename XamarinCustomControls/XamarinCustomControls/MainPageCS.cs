using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCustomControls.CustomControl;
using XamarinCustomControls.DataModel;
using XamarinCustomControls.ViewPages;

namespace XamarinCustomControls
{
    public class MainPageCS : ContentPage
    {
        CustomListView customListView;

        public MainPageCS()
        {
            customListView = new CustomListView
            {
                Items = DataSource.GetList(),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new Grid
            {
                RowDefinitions = {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
                },
                Children = {
                    new Label { Text = "I am a custom ListView", HorizontalTextAlignment = TextAlignment.Center },
                    customListView
                }
            };

            customListView.ItemSelected += OnItemSelected;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ItemsPageXaml(e.SelectedItem));
        }
    }
}
