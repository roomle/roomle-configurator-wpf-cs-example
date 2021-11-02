using RoomleConfiguratorWpfCSharp.View;
using RoomleConfiguratorWpfCSharp.ViewModel;
using RoomleConfiguratorWpfCSharp.Model;
using System.Windows;

namespace RoomleConfiguratorWpfCSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ConfiguratorModel configuratorModel;

        public App () {}

        public void OnLoadConfigurationView(object sender, RoutedEventArgs e)
        {
            if ((MainWindow as ConfiguratorWebView)?.DataContext is ConfiguratorViewModel configuratorViewModel)
            {
                configuratorModel = new ConfiguratorModel(configuratorViewModel);
            }
        }
    }
}
