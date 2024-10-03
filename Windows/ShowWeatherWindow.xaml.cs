﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Serialization;
using WpfApp2.Classes;
using WpfApp2.CustomControls;
using WpfApp2.DataModel;

namespace WpfApp2.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherWindow.xaml
    /// </summary>
    public partial class ShowWeatherWindow : Window
    {
        
        public ShowWeatherWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData() =>
            new ModelEF().Prognosis.ToList().ForEach(item =>
            wrapPanelWeather.Children.Add(new PrognosisWeather(item)));
        private Prognosis prognosis;

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}