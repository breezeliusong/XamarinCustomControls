using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControl
{
    public class CustomCell:ViewCell
    {
        public static readonly BindableProperty KeyProperty =
             BindableProperty.Create("Key", typeof(string), typeof(CustomCell), "");

        public string Key
        {
            get { return (string)GetValue(KeyProperty); }
            set { SetValue(KeyProperty, value); }
        }

        public static readonly BindableProperty CategoryProperty =
            BindableProperty.Create("Category", typeof(string), typeof(CustomCell), "");

        public string Category
        {
            get { return (string)GetValue(CategoryProperty); }
            set { SetValue(CategoryProperty, value); }
        }

        public static readonly BindableProperty ImageFilenameProperty =
            BindableProperty.Create("ImageFilename", typeof(string), typeof(CustomCell), "");

        public string ImageFilename
        {
            get { return (string)GetValue(ImageFilenameProperty); }
            set { SetValue(ImageFilenameProperty, value); }
        }
    }
}
