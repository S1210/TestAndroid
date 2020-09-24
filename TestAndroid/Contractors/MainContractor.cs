using System.Collections.Generic;
using System.Threading.Tasks;
using TestAndroid.Adapters;
using TestAndroid.Models;

namespace TestAndroid.Contractors
{
    public interface MainContractor
    {
        public interface View
        {
            void SetAdapter(RecyclerViewMainAdapter adapter);
            void OpenIntent(string serObject);
            void HidePB();
            void ShowSnackbar(string v);
        }

        public interface Presenter
        {
            void GetOffers(string url);
        }

        public interface Repository
        {
            Task<List<YML.yml_catalogShopOffer>> GetOffers(string url);
        }
    }
}