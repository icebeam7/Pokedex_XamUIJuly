using System;

using Pokedex_XamUIJuly.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex_XamUIJuly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _02_EmptyView : ContentPage
    {
        PokemonViewModel vm;

        public _02_EmptyView()
        {
            InitializeComponent();
            vm = new PokemonViewModel();
            BindingContext = vm;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await vm.LoadPokedex();
        }
    }
}