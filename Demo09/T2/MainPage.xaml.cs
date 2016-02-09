/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 9.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void EuroButton_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(ModifiedTextBlock.Text);
            double euros = num / 5.94573;
            string value = euros.ToString("0.00");
            ModifiedTextBlock.Text = value;
        }

        private void MarkkaButton_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(MoneyTextBox.Text);
            double markat = num * 5.94573;
            string value = markat.ToString("0.00");
            ModifiedTextBlock.Text = value;
        }
    }
}
