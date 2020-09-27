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

/// Week 4		Homework 1
/// File Name: MainWindow.xaml.cs
/// @author: Antonio Monteiro
/// Date:  September 27th 2020

namespace Part_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            //intialize variables
            double weight = Double.Parse(weightTextBox.Text);
            double height = Double.Parse(heightTextBox.Text);
            double bmi;

            //calculate bmi and assign value
            bmi = calculateBMI(weight, height);

            //check and update screen
            if (bmi < 15)
            {
                //update screen
                bmiCanvas.Background = Brushes.Blue;
                bmiLabel.Content = "You are below healthy BMI. (" + bmi + ")";

            } else if (bmi > 26)
            {
                //update screen
                bmiCanvas.Background = Brushes.Green;
                bmiLabel.Content = "You are at a healthy BMI. (" + bmi + ")";

            } else
            {
                //update screen
                bmiCanvas.Background = Brushes.Yellow;
                bmiLabel.Content = "You are above healthy BMI. (" + bmi + ")";

            }

        }

        //calculate bmi function
        public double calculateBMI(double weight, double height)
        {

            //declare bmi variable
            double bmi;

            //calculate bmi
            bmi = (weight * 720.0) / (height * height);

            //return bmi
            return Math.Round(bmi, 2);

        }
    }
}
