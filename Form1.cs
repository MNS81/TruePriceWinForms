using System.Xml;

namespace TruePriceWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, double> PriceList = new Dictionary<int, double>();
        double price;
        double weight;
        double result;
        private void Form1_Load(object sender, EventArgs e) { }
        private void CalculateOutput_TextChanged(object sender, EventArgs e)
        {
            CalculateOutput.ReadOnly = true;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            price = (double)(PriceInput.Value);
            weight = (double)(WeightInput.Value);
            result = Math.Round(price / weight * 1000, 2);
            PriceList.Add(PriceList.Count + 1, result);
            CalculateOutput.Text = $"Цена за кг. {result} руб.";
            var summ = 0.0;
            var minKey = 0;
            var minValue = Double.MaxValue;
            foreach (var item in PriceList)
            {
                summ += item.Value;
                if (item.Value < minValue)
                {
                    minValue = item.Value;
                    minKey = item.Key;
                }
            }
            BestPriseText.Text = $"Оптимальная цена: {minKey} --> {minValue} р.";
        }

        private void ListWiewButton_Click(object sender, EventArgs e)
        {
            if (PriceList.Count == 0)
                CalculateOutput.Text = "Список пока пустой!";
            else
                MessageBox.Show($"{String.Join("\n", PriceList)}", "Список цен");
        }
        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            PriceInput.Value = 0;
            WeightInput.Value = 0;
            CalculateOutput.Text = String.Empty;
            BestPriseText.Text = String.Empty;
            PriceList.Clear();
        }
        private void BestPriseText_TextChanged(object sender, EventArgs e) { }
    }
}