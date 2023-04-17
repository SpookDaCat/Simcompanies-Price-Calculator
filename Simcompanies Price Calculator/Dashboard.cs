using Simcompanies_Price_Calculator.Entities;
using System.Globalization;
using System.Linq;

namespace Simcompanies_Price_Calculator {
    public partial class Dashboard : Form {
        private SimCoRestClient client = new SimCoRestClient();
        public List<MarketItem> Items { get; set; } = new List<MarketItem>();
        public Dictionary<int, string> MarketIndexer { get; set; }

        public MarketItem CheapestItem { get; set; }= new MarketItem();

        public Dashboard() {
            InitializeComponent();

            // generate market index & autocomplete
            MarketIndexer = MarketIndex.GenerateIndex();
            var autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange(MarketIndexer.Values.ToArray());
            MarketNameTextBox.AutoCompleteCustomSource = autocomplete;

            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private MarketItem GetCheapestItem() {
            var item = Items.FirstOrDefault(x => x.Quality >= int.Parse(this.QualityTextBox.Text));
            return item ?? new MarketItem() { Price = -1};
        }

        private void MarketNameTextBox_TextChanged(object sender, EventArgs e) {
            var self = sender as TextBox;
            if (self == null) return; // so it stops complaining

            var t = MarketIndexer.FirstOrDefault(x=>x.Value == self.Text);
            if (t.Value == null || t.Key == 0) {
                // it was not found
                return;
            } else {
                MarketIDTextBox.Text = t.Key.ToString();
            }
        }

        public void RefreshMarketData() {

            // validation
            if (!int.TryParse(this.MarketIDTextBox.Text, out int id) || !MarketIndexer.ContainsKey(id)) {
                MessageBox.Show("Your Market Id value seems corrupt. It cannot be converted to Int");
                return;
            }
            if (!int.TryParse(this.QualityTextBox.Text, out int q) || q < 0) {
                MessageBox.Show("Quality must be an positive integer");
                return;
            }

            Items = client.GetMarketData(this.MarketIDTextBox.Text).OrderBy(x => x.Price).ToList();
            CheapestItem = GetCheapestItem();
            decimal marketPrice = CheapestItem.Price;
            this.MPTextBox.Text = marketPrice.ToString("C", CultureInfo.CurrentCulture);
            this.MP2TextBox.Text = Math.Round(marketPrice * 0.98m, 2).ToString("C", CultureInfo.CurrentCulture);
            this.MP25TextBox.Text = Math.Round(marketPrice * 0.975m, 2).ToString("C", CultureInfo.CurrentCulture);
            this.MP3TextBox.Text = Math.Round(marketPrice * 0.97m, 2).ToString("C", CultureInfo.CurrentCulture);

            this.MPCostTextBox.Text = this.MPTextBox.Text;
            this.MCCostTextBox.Text = this.MPTextBox.Text;
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            RefreshMarketData();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// MANUAL PERCENT: PERCENT TEXT BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MPPercentTextBox_TextChanged(object sender, EventArgs e) {

            var self = sender as TextBox;
            if (self == null || !decimal.TryParse(self.Text.Replace("%",""), out decimal bigPercent)) {
                return;
            }
            this.MPCostTextBox.Text = Math.Round(CheapestItem.Price * (100-bigPercent)/100, 2).ToString("C", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// MANUAL COST: COST TEXT BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MCCostTextBox_TextChanged(object sender, EventArgs e) {
            var self = sender as TextBox;
            if (self == null || !decimal.TryParse(self.Text.Replace("$",""), out decimal cost)) {
                return;
            }
            var bigPercent = 100- (Math.Round((cost / CheapestItem.Price), 4) * 100);
            this.MCPercentTextBox.Text = bigPercent.ToString() + "%";
        }

        private void MCCostTextBox_Leave(object sender, EventArgs e) {
            var self = sender as TextBox;
            if (self == null) return;
            if (!self.Text.StartsWith("$")) self.Text = "$"+self.Text;
        }

        private void MPPercentTextBox_Leave(object sender, EventArgs e) {
            var self = sender as TextBox;
            if (self == null) return;
            if (!self.Text.EndsWith("%")) self.Text = self.Text + "%";
        }
    }
}