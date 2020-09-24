using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TestAndroid.Models
{
    public class Shop
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string URL { get; set; }
        public Currencies Currencies { get; set; }
        public Categories Categories { get; set; }
        public string LocalDeliveryCost { get; set; }
        public Offers Offers { get; set; }
    }
}