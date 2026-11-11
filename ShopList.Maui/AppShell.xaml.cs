using ShopList.Maui.Views;

namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Registra las rutas de las páginas de ka aplicación

            Routing.RegisterRoute(nameof(EditShopListItemPage), typeof(EditShopListItemPage));
        }
    }
}
