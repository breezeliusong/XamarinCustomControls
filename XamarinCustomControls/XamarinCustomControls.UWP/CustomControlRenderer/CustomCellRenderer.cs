using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinCustomControls.CustomControl;
using XamarinCustomControls.UWP.CustomControlRenderer;

[assembly:ExportRenderer(typeof(CustomCell),typeof(CustomCellRenderer))]
namespace XamarinCustomControls.UWP.CustomControlRenderer
{
    public class CustomCellRenderer:ViewCellRenderer
    {
        public override Windows.UI.Xaml.DataTemplate GetTemplate(Cell cell)
        {
            return App.Current.Resources["CellTemplate"] as Windows.UI.Xaml.DataTemplate;
        }
    }
}
