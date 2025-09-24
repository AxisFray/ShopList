using System.Collections.ObjectModel;

namespace ShopList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public class Produkt
        {
            public string Nazwa { get; set; }
            public string Obrazek { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();
            Produkty = new ObservableCollection<Produkt>
        {
            new Produkt { Nazwa = "Apple"},
            new Produkt { Nazwa = "Mango"}
        };
            BindingContext = this;
        }

        
        }
}
