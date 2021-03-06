﻿using System;
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

namespace OxyPlot_charts_working_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel;

        public MainWindow()
        {
            viewModel = new ViewModel();

            DataContext = viewModel;

            InitializeComponent();


        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            

            viewModel.LoadData();
            viewModel.PlotModel.InvalidatePlot(true);

        }
    }
}
