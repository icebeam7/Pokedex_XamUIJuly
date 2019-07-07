using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Pokedex_XamUIJuly.ViewModels;

namespace Pokedex_XamUIJuly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _05_TwoHorizontalLists : ContentPage
    {
        PokemonViewModel vm;

        public _05_TwoHorizontalLists()
        {
            InitializeComponent();

            vm = new PokemonViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await vm.LoadIceDarkPokedex();

            await Task.Delay(5000);

            var articuno = vm.IcePokemonList.Where(x => x.name.english == "Articuno").FirstOrDefault();
            collectionViewIce.ScrollTo(articuno, position: ScrollToPosition.Center, animate: false);
        }
    }
}