using System.Collections.ObjectModel;
using static ShopList.MainPage;


namespace ShopList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Produkt> Produkty { get; set; }
        public class Produkt
        {
            public string Nazwa { get; set; }
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

        private void Done(object sender, EventArgs e)
        {
            
        }
    }
}
