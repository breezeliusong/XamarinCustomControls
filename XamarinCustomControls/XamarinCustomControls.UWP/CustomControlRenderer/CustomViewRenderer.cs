using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinCustomControls.CustomControl;
using XamarinCustomControls.UWP.CustomControlRenderer;

[assembly:ExportRenderer(typeof(CustomView),typeof(CustomViewRenderer))]
namespace XamarinCustomControls.UWP.CustomControlRenderer
{
    public class CustomViewRenderer:LabelRenderer 
    {
        TextBlock textblock;
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                // Instantiate the native control and assign it to the Control property with
                // the SetNativeControl method
                textblock = new TextBlock();
            }
            else
            {
                textblock = Control as TextBlock;
            }


            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null)
            {
                // Configure the control and subscribe to event handlers
                textblock.Text = ((CustomView)Element)._Text;
                //textblock.Height = ((CustomView)Element)._Height;
                //textblock.Width = ((CustomView)Element)._Width;
            }
        }
    }
}
