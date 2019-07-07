using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex_XamUIJuly.ViewModels;

namespace Pokedex_XamUIJuly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _04_TwoColumns : ContentPage
    {
        PokemonViewModel vm;

        public _04_TwoColumns()
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