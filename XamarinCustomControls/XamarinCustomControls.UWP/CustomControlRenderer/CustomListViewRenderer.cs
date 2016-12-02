using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;
using XamarinCustomControls.CustomControl;
using XamarinCustomControls.UWP.CustomControlRenderer;

[assembly: ExportRenderer(typeof(CustomListView),typeof(CustomListViewRenderer))]
namespace XamarinCustomControls.UWP.CustomControlRenderer
{
    public class CustomListViewRenderer:ListViewRenderer
    {
        ListView listView;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            listView = Control as ListView;
            if (e.OldElement != null)
            {
                //unsubscribe
                listView.SelectionChanged -= OnSelectedItemChanged;
            }
            if (e.NewElement != null)
            {
                listView.SelectionMode = ListViewSelectionMode.Single;
                listView.IsItemClickEnabled = false;
                listView.ItemsSource = ((CustomListView)e.NewElement).Items;
                listView.ItemTemplate = App.Current.Resources["ListViewItemTemplate"] as DataTemplate;

                //subscribe
                listView.SelectionChanged += OnSelectedItemChanged;
            }
        }


        /*
         * If the NativeListView.Items property changes, 
         * due to items being added to or removed from the list, 
         * the custom renderer needs to respond by displaying the changes. 
         * This can be accomplished by overriding the OnElementPropertyChanged method
         */
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CustomListView.ItemsProperty.PropertyName)
            {
                listView.ItemsSource = ((CustomListView)Element).Items;
            }
        }

        private void OnSelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            ((CustomListView)Element).NotifyItemSelected(listView.SelectedItem);
        }
    }
}
