using System.Collections.ObjectModel;
using static ShopList.MainPage;
public ObservableCollection<Produkt> Produkty { get; set; }

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

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ItemEntry.Text))
            {
                Produkty.Add(new Produkt { Nazwa = ItemEntry.Text });
                ItemEntry.Text = string.Empty;
            }
        }

    }
}
