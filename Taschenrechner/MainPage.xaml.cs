using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Taschenrechner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Application.Current.DebugSettings.EnableFrameRateCounter = false;
        }


        private string _firstNumberLastValidInput = "";
        private double _firstNumber;

        private void FirstNumberTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(FirstNumberTextBox.Text == "")
                    _firstNumber = 0;
                else
                    _firstNumber = Convert.ToDouble(FirstNumberTextBox.Text);

                _firstNumberLastValidInput = _firstNumber.ToString();
            }
            catch
            {
                FirstNumberTextBox.Text = _firstNumberLastValidInput;
                FirstNumberTextBox.Select(FirstNumberTextBox.Text.Length, 0);
            }
        }

        private string _secondNumberLastValidInput = "";
        private double _secondNumber;

        private void SecondNumberTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (SecondNumberTextBox.Text == "")
                    _secondNumber = 0;
                else
                    _secondNumber = Convert.ToDouble(SecondNumberTextBox.Text);

                _secondNumberLastValidInput = _secondNumber.ToString();
            }
            catch
            {
                SecondNumberTextBox.Text = _secondNumberLastValidInput;
                SecondNumberTextBox.Select(SecondNumberTextBox.Text.Length, 0);
            }
        }

        private void AdditionButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = (_firstNumber + _secondNumber).ToString();
        }

        private void SubstractionButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = (_firstNumber - _secondNumber).ToString();
        }

        private void MultiplicationButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = (_firstNumber * _secondNumber).ToString();
        }

        private void DivisionButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = (_firstNumber / _secondNumber).ToString();
        }

        private void ModuloButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = (_firstNumber % _secondNumber).ToString();
        }
    }
}
