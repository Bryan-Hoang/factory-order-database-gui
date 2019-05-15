﻿using System.Windows;

namespace Order_System_UI.Views
{
    /// <inheritdoc cref="Window" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// Start up the Home Window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        /// <summary>
        /// Go to input transportation data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event handler.</param>
        private void InputTransportationData(object sender, RoutedEventArgs e)
        {
            var transportationDataInputView = new TransportationDataInputView();
            this.Close();
            transportationDataInputView.Show();
        }

        /// <summary>
        /// Go to search transportation data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event handler.</param>
        private void SearchTransportationData(object sender, RoutedEventArgs e)
        {
            var transportationDataSearchView = new TransportationDataSearchView();
            this.Close();
            transportationDataSearchView.Show();
        }

        /// <summary>
        /// Go to input sales data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event handler.</param>
        private void InputSalesData(object sender, RoutedEventArgs e)
        {
            // N/A
        }

        /// <summary>
        /// Go to search sales data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event handler.</param>
        private void SearchSalesData(object sender, RoutedEventArgs e)
        {
            // N/A
        }
    }// end class
}// end namespace
