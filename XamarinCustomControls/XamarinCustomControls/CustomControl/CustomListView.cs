using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCustomControls.DataModel;

namespace XamarinCustomControls.CustomControl
{
    public class CustomListView:ListView
    {

        //create an Items property
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create("Items", typeof(IEnumerable<DataSource>), typeof(CustomListView), new List<DataSource>());
        public IEnumerable<DataSource> Items
        {
            get { return (IEnumerable<DataSource>)GetValue(ItemsProperty);}
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object ob)
        {
           if(ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(ob));
            }
        }

    }
}
