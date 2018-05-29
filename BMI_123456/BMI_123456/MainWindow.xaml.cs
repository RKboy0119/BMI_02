using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI_123456
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 身高數值
            double Value = Math.Round(HeightSlider.Value, 2);
            HeightNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 200) * 320;
            Canvas.SetLeft(Height, v);

            // 計算BMI
            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);

            // 分割結果的整數與小數
            string[] parts = Math.Round(bmi, 1).ToString().Split('.');

            BmiNumber1.Text = parts[0];
            if (parts.Length > 1)
                BmiNumber2.Text = "." + parts[1];
            else
                BmiNumber2.Text = ".0";

        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 體重數值
            double Value = Math.Round(WeightSlider.Value, 2);
            WeightNumber.Text = Value.ToString();

            // 數字顯示位置
            double v = (Value / 100) * 320;
            Canvas.SetLeft(Weight, v);

            // 計算BMI
            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);

            // 分割結果的整數與小數
            string[] parts = Math.Round(bmi, 1).ToString().Split('.');

            BmiNumber1.Text = parts[0];
            if (parts.Length > 1)
                BmiNumber2.Text = "." + parts[1];
            else
                BmiNumber2.Text = ".0";

        }
    }
}

