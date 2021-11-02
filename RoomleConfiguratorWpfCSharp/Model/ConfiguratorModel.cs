using RoomleConfiguratorWpfCSharp.ViewModel;

namespace RoomleConfiguratorWpfCSharp.Model
{
    public class ConfiguratorModel
    {
        public ConfiguratorViewModel ViewModel { get; private set; }

        public ConfiguratorModel(ConfiguratorViewModel viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
