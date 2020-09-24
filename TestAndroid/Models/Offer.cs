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
    public class Offer
    {
        public string URL { get; set; }
        public string Price { get; set; }
        public string CurrencyId { get; set; }
        public CategoryId CategoryId { get; set; }
        public string Picture { get; set; }
        public string Delivery { get; set; }
        public string LocalDeliveryCost { get; set; }
        public string TypePrefix { get; set; }
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string ManufacturerWarranty { get; set; }
        public string CountryOfOrigin { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
        public string BID { get; set; }
        public string CBID { get; set; }
        public string Available { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Series { get; set; }
        public string Year { get; set; }
        public string ISBN { get; set; }
        public string Volume { get; set; }
        public string Part { get; set; }
        public string Language { get; set; }
        public string Binding { get; set; }
        public string PageExtent { get; set; }
        public string Downloadable { get; set; }
        public string PerformedBy { get; set; }
        public string PerformanceType { get; set; }
        public string Storage { get; set; }
        public string Format { get; set; }
        public string RecordingLength { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Media { get; set; }
        public string Starring { get; set; }
        public string Director { get; set; }
        public string OriginalName { get; set; }
        public string Country { get; set; }
        public string WorldRegion { get; set; }
        public string Region { get; set; }
        public string Days { get; set; }
        public List<String> DataTour { get; set; }
        public string HotelStars { get; set; }
        public string Room { get; set; }
        public string Meal { get; set; }
        public string Included { get; set; }
        public string Transport { get; set; }
        public string Place { get; set; }
        public Hall Hall { get; set; }
        public string HallPart { get; set; }
        public string Date { get; set; }
        public string IsPremiere { get; set; }
        public string IsKids { get; set; }
    }
}