using System;
using System.Windows;
using System.Windows.Media.Imaging;
using RoomleConfiguratorWpfCSharp.ViewModel;

namespace RoomleConfiguratorWpfCSharp.View
{
    public partial class ConfiguratorWebView : Window
    {
        public ConfiguratorWebView()
        {
            InitializeComponent();
            if (DataContext is ConfiguratorViewModel viewModel)
            {
                Loaded += viewModel.OnLoaded;
            }
            if (Application.Current is App app)
            {
                Loaded += app.OnLoadConfigurationView;
            }
        }

        private void WidthValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) =>
            (DataContext as ConfiguratorViewModel)?.ChangeWidth(e.NewValue);

        private void HeightValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) =>
            (DataContext as ConfiguratorViewModel)?.ChangeHeight(e.NewValue);
    }
}
