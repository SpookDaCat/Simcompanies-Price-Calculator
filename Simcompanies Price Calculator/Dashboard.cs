using Simcompanies_Price_Calculator.Entities;

namespace Simcompanies_Price_Calculator {
    public partial class Dashboard : Form {
        private SimCoRestClient client = new SimCoRestClient();
        public List<MarketItem> Items { get; set; }

        public Dashboard() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }


    }
}