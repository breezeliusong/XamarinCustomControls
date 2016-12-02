using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinCustomControls.DataModel;

namespace XamarinCustomControls.ViewPages
{
    public partial class ItemsPageXaml : ContentPage
    {
        public ItemsPageXaml(object detail)
        {
            InitializeComponent();
            if(detail is string)
            {
                PageLabel.Text = detail as string;
            }else if(detail is DataSource){
                PageLabel.Text = (detail as DataSource).Name;
                }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
