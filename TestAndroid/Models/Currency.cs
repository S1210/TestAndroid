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
    public class Currency
    {
        public string ID { get; set; }
        public string Rate { get; set; }
        public string Plus { get; set; }
    }
}