using CrossPlatformTest.Models;
using CrossPlatformTest.Services;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CrossPlatformTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IProductClient _productClient;
        public MainViewModel(INavigationService navigationService, IProductClient productClient) : base(navigationService)
        {
            _productClient = productClient;
            LoadData();
        }

        private ObservableCollection<Product> items;
        public ObservableCollection<Product> Items
        {
            get => this.items;
            set
            {
                this.items = value;
                RaisePropertyChanged();
            }
        }

        private async void LoadData()
        {
            await _productClient.GetAsync()
                .ContinueWith((x) =>
                {
                    var products = x.Result;
                    if (products.Any())
                    {
                        Items = new ObservableCollection<Product>(products);
                    }
                });
        }
    }
}
