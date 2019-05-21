﻿using CottonOilFactory.OrderSystemGUI.Factories;
using CottonOilFactory.OrderSystemGUI.Models;
using GalaSoft.MvvmLight.CommandWpf;

namespace CottonOilFactory.OrderSystemGUI.ViewModels.SalesData
{
    public class SalesDataInputViewModel : AbstractBackToMainWindowViewModel
    {
        private readonly AbstractWindowFactory saleDataConfirmWindowFactory;

        public SalesDataInputViewModel(AbstractWindowFactory mainWindowFactory, AbstractWindowFactory saleDataConfirmWindowFactory) 
            : base(mainWindowFactory)
        {
            this.saleDataConfirmWindowFactory = saleDataConfirmWindowFactory;
            SalesDataModel = new SalesDataModel();
            ConfirmSalesDataCommand = new RelayCommand(ConfirmSalesData, canExecute: () => SalesDataModel.IsValidData);
        }

        public SalesDataModel SalesDataModel { get; }

        public RelayCommand ConfirmSalesDataCommand { get; }

        private void ConfirmSalesData()
        {
            saleDataConfirmWindowFactory?.CreateWindow(SalesDataModel);
        }
    }
}