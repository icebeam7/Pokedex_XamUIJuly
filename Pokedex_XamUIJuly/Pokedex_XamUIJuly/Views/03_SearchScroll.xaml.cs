using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Pokedex_XamUIJuly.ViewModels;

namespace Pokedex_XamUIJuly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _03_SearchScroll : ContentPage
    {
        PokemonViewModel vm;

        public _03_SearchScroll()
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

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var pokemon = searchBar.Text;
            var result = vm.SearchScrollPokemon(pokemon);

            if (result != null)
            {
                collectionView.ScrollTo(result, animate: false, position: ScrollToPosition.Center);
                collectionView.SelectedItem = result;
            }
        }
    }
}