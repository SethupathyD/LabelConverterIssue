using System.Globalization;
namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            label.SetBinding(Label.TextProperty, new Binding
            {
                Path = "Employees[0].Salary",
                StringFormat = "{0:C}°",
                Converter = new SalaryToCurrencyWithDegreeConverter()
            });

        }

    }

    public class SalaryToCurrencyWithDegreeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && decimal.TryParse(value.ToString(), out decimal columnValue))
            {
                // Format as currency and append the degree symbol
                return string.Format("{0:C}°", columnValue);
            }
            return null; // Return null if the value is not valid
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value; 
        }
    }
}
