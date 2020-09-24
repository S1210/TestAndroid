using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using TestAndroid.Models;

namespace TestAndroid.Adapters
{
    public class RecyclerViewMainAdapter : RecyclerView.Adapter
    {
        private List<YML.yml_catalogShopOffer> offers;
        public event EventHandler<int> ItemClick;

        public RecyclerViewMainAdapter(List<YML.yml_catalogShopOffer> offers)
        {
            this.offers = offers;
        }

        public override int ItemCount => offers.Count;

        void OnClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder viewHolder = holder as RecyclerViewHolder;
            viewHolder.Bind(offers[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_rv_main, parent, false);
            return new RecyclerViewHolder(view, OnClick);
        }

        public void SetItems(List<YML.yml_catalogShopOffer> offers)
        {
            this.offers.AddRange(offers);
            NotifyDataSetChanged();
        }
        
    }
    public class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        private TextView tvID;

        public RecyclerViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            tvID = itemView.FindViewById<TextView>(Resource.Id.tv_id);
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }

        internal void Bind(YML.yml_catalogShopOffer yml_catalogShopOffer)
        {
            tvID.Text = yml_catalogShopOffer.id.ToString();
        }
    }
}