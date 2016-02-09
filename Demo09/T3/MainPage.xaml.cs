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

namespace T3
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

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            // window size
            int width = int.Parse(windowwidthTextBox.Text);
            int height = int.Parse(windowheightTextBox.Text);
            int window = (width * height) / 10;
            windowsizeTextBox.Text = window.ToString() + " cm^2";

            // glass size
            int wood = int.Parse(woodwidthTextBox.Text);
            int glasswidth = width - (2 * wood);
            int glassheight = height - (2 * wood);
            int glass = (glassheight * glasswidth) / 10;
            glassizeTextBox.Text = glass.ToString() + " cm^2";

            // wood circle
            int circle = ((width * 2) + ((height - (2 * wood)) * 2)) / 10;
            woodcircleTextBox.Text = circle.ToString() + " cm";
        }
    }
}
