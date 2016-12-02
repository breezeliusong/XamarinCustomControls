using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinCustomControls.CustomControl;
using XamarinCustomControls.UWP.CustomControlRenderer;

//Each custom renderer class is decorated with an ExportRenderer attribute that registers the renderer with Xamarin.Forms.
//   MyEntry is parameter handler ,MyEntryRenderer is parameter target
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace XamarinCustomControls.UWP.CustomControlRenderer
{

    class CustomEntryRenderer : EntryRenderer
    {

        //the place to perform the native control customization
        //The call to the base class's OnElementChanged method instantiates an UWP TextBox control
        //with a reference to the control being assigned to the renderer's Control property

        // The OnElementChanged method is called when the corresponding Xamarin.Forms control is created.
        //after the control in portable project has been created.
        //is in this method(this.LoadApplication(new CustomRenderer.App());in each platform)
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Debug.Write(e.OldElement == null);
            Debug.Write(e.NewElement == null);
            if (e.OldElement != null || Element == null)
            {
                Debug.Write(e.OldElement);
                Debug.Write(e.NewElement);
            }

            //Element is a type of CustomRenderer.MyEntry of Xamarin.Forms control in Portable class
            //Element property refer to the CustomEntry define in Xamarin.Forms


            //A typed reference to the native control being used on the platform can be accessed through the Control property.
            //in this case the Control is a type of Xamarin.Forms.Platform.UWP.FormsTextBox
            if (Control != null)
            {

                //Control is the corresponding native Control (current situation is TextBox)
                // https://developer.xamarin.com/guides/xamarin-forms/custom-renderer/renderers/
                //the site of Renderer Base Classes and Native Controls
                Control.Background = new SolidColorBrush(Colors.Cyan);
            }
        }
    }
}