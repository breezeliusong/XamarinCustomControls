using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinCustomControls.DataModel
{
    public class DataSource
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImageFilename { get; set; }
        public DataSource(string name,string category,string imageFilename)
        {
            Name = name;
            Category = category;
            ImageFilename = imageFilename;
        }

        public static List<DataSource> GetList()
        {
            var l= new List<DataSource>();
            l.Add(new DataSource("Asparagus", "Asparagus", "/Pictures"));
            l.Add(new DataSource("Avocados", "Avocados", "/Pictures"));
            l.Add(new DataSource("Beetroots", "Beetroots", "/Pictures"));
            l.Add(new DataSource("Capsicum", "/Pictures", "/pic"));
            l.Add(new DataSource("Broccoli", "/Pictures", "/pic"));
            l.Add(new DataSource("Brussel sprouts", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Cabbage", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Carrots", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Cauliflower", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Celery", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Corn", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Cucumbers", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Eggplant", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Fennel", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Garlic", "/Pictures", "/Pictures"));
            l.Add(new DataSource("/Pictures", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Peas", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Kale", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Leeks", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Mushrooms", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Olives", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Onions", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Potatoes", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Lettuce", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Spinach", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Squash", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Sweet potatoes", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Tomatoes", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Turnips", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Apples", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Apricots", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Bananas", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Blueberries", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Rockmelon", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Figs", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Grapefruit", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Grapes", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Honeydew Melon", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Kiwifruit", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Lemons", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Oranges", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Pears", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Pineapple", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Plums", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Raspberries", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Strawberries", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Watermelon", "/Pictures", "/Pictures"));
            l.Add(new DataSource("Balmain Bugs", "/Pictures", ""));
            l.Add(new DataSource("Calamari", "/Pictures", ""));
            l.Add(new DataSource("Cod", "/Pictures", ""));
            l.Add(new DataSource("Prawns", "/Pictures", ""));
            l.Add(new DataSource("Lobster", "/Pictures", ""));
            l.Add(new DataSource("Salmon", "/Pictures", ""));
            l.Add(new DataSource("Scallops", "/Pictures", ""));
            l.Add(new DataSource("Shrimp", "/Pictures", ""));
            l.Add(new DataSource("Tuna", "/Pictures", ""));
            l.Add(new DataSource("Almonds", "Nuts", ""));
            l.Add(new DataSource("Cashews", "Nuts", ""));
            l.Add(new DataSource("Peanuts", "Nuts", ""));
            l.Add(new DataSource("Walnuts", "Nuts", ""));

            return l;
        }

        public static List<DataSource> GetSource()
        {
            List<DataSource> l = new List<DataSource>();
            l.Add(new DataSource("Black /Pictures", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Dried peas", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Kidney /Pictures", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Lentils", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Lima /Pictures", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Miso", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Soy/Pictures", "/Pictures & /Pictures", "/Pictures"));
            l.Add(new DataSource("Beef", "Meat", ""));
            l.Add(new DataSource("Buffalo", "Meat", ""));
            l.Add(new DataSource("Chicken", "Meat", ""));
            l.Add(new DataSource("Lamb", "Meat", ""));
            l.Add(new DataSource("Cheese", "Dairy", ""));
            l.Add(new DataSource("Milk", "Dairy", ""));
            l.Add(new DataSource("Eggs", "Dairy", ""));
            l.Add(new DataSource("Basil", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Black pepper", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Chili pepper, dried", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Cinnamon", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Cloves", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Cumin", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Dill", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Ginger", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Mustard", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Oregano", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Parsley", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Peppermint", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Rosemary", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Sage", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Thyme", "Herbs & Spices", "/Pictures"));
            l.Add(new DataSource("Turmeric", "Herbs & Spices", "/Pictures"));
            return l;
        }
    }
}
