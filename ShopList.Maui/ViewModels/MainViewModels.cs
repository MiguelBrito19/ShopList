using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using ShopList.Maui.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ShopList.Maui.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListItem> _items;
        public MainViewModels()
        {
            Items = new ObservableCollection<ShopListItem>();
            LoadItems();
        }
        private void LoadItems()
        {
            Items.Add(new ShopListItem { Nombre = "Leche", Cantidad = 2, Comprado = false });
            Items.Add(new ShopListItem { Nombre = "Pan", Cantidad = 1, Comprado = true });
            Items.Add(new ShopListItem { Nombre = "Harina", Cantidad = 3, Comprado = false });
        }
        [RelayCommand]
        private async Task ShowNewShopItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListItemPage));
        }
    }
}