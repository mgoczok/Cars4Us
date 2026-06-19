using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cars4Us.Models;
using Cars4Us.Repositories;
using Cars4Us.Services.Pricing;

namespace Cars4Us
{
    public partial class PricingForm : Form
    {
        private readonly PricingPipelineService _pricingService;
        private readonly OptionRepository _optionRepository;
        private readonly CarRepository _carRepository;
        private List<Car> _cars;
        private List<Option> _options;

        public PricingForm()
        {
            InitializeComponent();
            _pricingService = new PricingPipelineService();
            _optionRepository = new OptionRepository();
            _carRepository = new CarRepository();
            _cars = new List<Car>();
            _options = new List<Option>();

            LoadCars();
            LoadOptions();
        }

        private void LoadCars()
        {
            try
            {
                _cars = _carRepository.GetAllAvailable();
                cbCar.Items.Clear();
                cbCar.Items.Add("-- Wybierz samochód --");

                foreach (var car in _cars)
                {
                    cbCar.Items.Add($"{car.Brand} {car.Model} ({car.VIN}) - {car.BasePrice:N2} PLN");
                }

                cbCar.SelectedIndex = 0;

                if (_cars.Count == 0)
                {
                    MessageBox.Show("Brak dostępnych samochodów w bazie danych.",
                        "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania samochodów: {ex.Message}",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOptions()
        {
            try
            {
                _options = _optionRepository.GetAllActive();
                clbOptions.Items.Clear();

                foreach (var option in _options)
                {
                    clbOptions.Items.Add($"{option.Name} ({option.Category}) - {option.Price:N2} PLN");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania opcji: {ex.Message}",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carIndex = cbCar.SelectedIndex - 1; // -1 for the placeholder item
            if (carIndex >= 0 && carIndex < _cars.Count)
            {
                numBasePrice.Value = _cars[carIndex].BasePrice;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal basePrice = numBasePrice.Value;

                if (cbCar.SelectedIndex <= 0)
                {
                    MessageBox.Show("Proszę wybrać samochód z listy.",
                        "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (basePrice <= 0)
                {
                    MessageBox.Show("Cena bazowa musi być większa niż 0.",
                        "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Collect prices of selected options
                var selectedOptionPrices = new List<decimal>();
                foreach (int index in clbOptions.CheckedIndices)
                {
                    selectedOptionPrices.Add(_options[index].Price);
                }

                // Determine financing type
                FinancingType financingType = FinancingType.Cash;
                if (rbLeasing.Checked) financingType = FinancingType.Leasing;
                else if (rbCredit.Checked) financingType = FinancingType.Credit;

                bool applyFleetDiscount = chkFleetDiscount.Checked;
                bool applySeasonalPromotion = chkSeasonalPromotion.Checked;

                // Call the pricing pipeline — all calculation logic is in PricingPipelineService
                PricingResult result = _pricingService.Calculate(
                    basePrice,
                    selectedOptionPrices,
                    applyFleetDiscount,
                    applySeasonalPromotion,
                    financingType);

                // Display results
                txtBreakdown.Text = result.Breakdown.Replace("\n", Environment.NewLine);
                lblFinalPrice.Text = $"{result.FinalPrice:N2} PLN";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas kalkulacji wyceny: {ex.Message}",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
