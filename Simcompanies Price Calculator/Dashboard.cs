using Simcompanies_Price_Calculator.Entities;
using System.Linq;

namespace Simcompanies_Price_Calculator {
    public partial class Dashboard : Form {
        private SimCoRestClient client = new SimCoRestClient();
        public List<MarketItem> Items { get; set; }

        public Dashboard() {
            InitializeComponent();
            Items = client.GetMarketData(this.MarketIDTextBox.Text).OrderBy(x => x.Price).ToList();
            decimal marketPrice = GetCheapestItem().Price;
            this.MPTextBox.Text = marketPrice.ToString();
            this.MP2TextBox.Text = Math.Round(marketPrice * 0.98m, 2).ToString();
            this.MP3TextBox.Text = Math.Round(marketPrice * 0.97m, 2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private MarketItem GetCheapestItem() {
            var item = Items.FirstOrDefault(x => x.Quality >= int.Parse(this.QualityTextBox.Text));
            return item ?? new MarketItem() { Price = -1};
        }

    }
}