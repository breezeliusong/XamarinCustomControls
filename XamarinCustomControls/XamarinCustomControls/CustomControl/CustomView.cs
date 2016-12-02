using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControl
{
    public class CustomView : Label
    {

        //custom a property attach to this CustomView
        public static readonly BindableProperty CustomProperty = BindableProperty.Create(
            propertyName: "Custom",
            returnType: typeof(Type),
            declaringType: typeof(CustomView),
            defaultValue: null);
        public Type Custom
        {
            get { return (Type)GetValue(CustomProperty); }
            set { SetValue(CustomProperty, value); }
        }

        public static readonly BindableProperty _TextProperty =
          BindableProperty.Create("_Text", typeof(string),
              typeof(CustomView), "Hello");

        public string _Text
        {
            get { return (string)GetValue(_TextProperty); }
            set { SetValue(_TextProperty, value); }
        }

        //public static readonly BindableProperty _TextProperty = BindableProperty.Create(
        //    "_Text",
        //     typeof(string),
        //    typeof(CustomView),
        //     "Custom view");
        //public string _Text
        //{
        //    get { return (string)GetValue(_TextProperty); }
        //    set { SetValue(_TextProperty, value); }
        //}

        //public static readonly BindableProperty _HeightProperty = BindableProperty.Create(
        //   propertyName: "_Height",
        //   returnType: typeof(Double),
        //   declaringType: typeof(CustomView),
        //   defaultValue: 10);
        //public Double _Height
        //{
        //    get { return (Double)GetValue(_HeightProperty); }
        //    set { SetValue(_HeightProperty, value); }
        //}

        //public static readonly BindableProperty _WidthProperty = BindableProperty.Create(
        //   propertyName: "_Width",
        //   returnType: typeof(double),
        //   declaringType: typeof(CustomView),
        //   defaultValue: 100);
        //public double _Width
        //{
        //    get { return (double)GetValue(_WidthProperty); }
        //    set { SetValue(_WidthProperty, value); }
        //}
    }
}
