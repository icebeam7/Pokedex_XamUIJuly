using Pokedex_XamUIJuly.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_XamUIJuly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _01_CollectionView : ContentPage
    {
        PokemonViewModel vm;

        public _01_CollectionView()
        {
            InitializeComponent();
            vm = new PokemonViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadPokedex();
        }
    }
}