using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ECommerceApp.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }


        #endregion
        #region Constructors
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }
        #endregion
        #region Methods
        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            { 
                Icon = "Product.png",
                PageName = "ProductsPage",
                Title = "Productos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Customer.png",
                PageName = "CustomersPage",
                Title = "Clientes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Order.png",
                PageName = "OrdersPage",
                Title = "Ordenes",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Delivery.png",
                PageName = "DeliveriesPage",
                Title = "Entregas",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Configuration.png",
                PageName = "ConfigurationsPage",
                Title = "Configuraciones",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "Exit.png",
                PageName = "LogoutPage",
                Title = "Salir",
            });
        }
        #endregion
    }
}
