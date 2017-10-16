﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImplicitAnimationsPage : Page
    {
        private Random random = new Random();

        public ImplicitAnimationsPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Element.Visibility = Element.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(Element, random.NextDouble() * Window.Current.Bounds.Height);
            Canvas.SetLeft(Element, random.NextDouble() * Window.Current.Bounds.Width);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var visual = ElementCompositionPreview.GetElementVisual(Element);
            visual.Scale = new Vector3(
                (float)random.NextDouble() * 2,
                (float)random.NextDouble() * 2,
                1);
        }
    }
}
