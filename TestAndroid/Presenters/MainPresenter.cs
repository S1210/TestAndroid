using Newtonsoft.Json;
using System.Collections.Generic;
using TestAndroid.Adapters;
using TestAndroid.Contractors;
using TestAndroid.Models;

namespace TestAndroid.Presenters
{
    public class MainPresenter : MainContractor.Presenter
    {
        private MainContractor.View mView;
        private MainContractor.Repository mRepository;
        private List<YML.yml_catalogShopOffer> offers;
        private RecyclerViewMainAdapter adapter;

        public MainPresenter(MainContractor.View mView)
        {
            this.mView = mView;
            mRepository = new YML();
        }

        public async void GetOffers(string url)
        {
            offers = await mRepository.GetOffers(url);
            if (offers != null)
            {
                adapter = new RecyclerViewMainAdapter(offers);
                adapter.ItemClick += OnItemClick;
                mView.SetAdapter(adapter);
            } else
            {
                mView.ShowSnackbar("Произошла ошибка при получении данных");
            }
            mView.HidePB();
        }

        void OnItemClick(object sender, int position)
        {

            mView.OpenIntent(JsonConvert.SerializeObject(offers[position]));
        }
    }
}