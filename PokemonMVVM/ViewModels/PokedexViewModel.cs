using PokemonMVVM.DAL;
using PokemonMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMVVM.ViewModels
{
    public class PokedexViewModel: INotifyPropertyChanged
    {
        public PokedexViewModel()
        {
            PropertyChanged += PokedexViewModel_PropertyChanged;
            LoadCharacters(SelectedPokemon.Url);
        }

        public async void LoadCharacters(string url)
        {
             Pokemon = await PokemonAPIDAL.LoadCharactersAsync(url);
        }

        private void PokedexViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "SelectedPokemon")
            {
                LoadCharacters(SelectedPokemon.Url);
            }
        }

        private List<Pokemon> characters;

        public List<Pokemon> Pokemon
        {
            get
            {
                return characters;
            }
            set
            {
                characters = value;
                OnPropertyChange("Pokemon");
            }
        }

        private Pokemon selectedPokemon;

        

        public Pokemon SelectedPokemon
        {
            get
            {
                return selectedPokemon;
            }
            set
            {
                selectedPokemon = value;
                OnPropertyChange("SelectedCharacter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}