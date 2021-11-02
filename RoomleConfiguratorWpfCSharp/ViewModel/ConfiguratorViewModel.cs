using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Runtime.CompilerServices;
using RoomleConfiguratorWpfCSharp.View;

namespace RoomleConfiguratorWpfCSharp.ViewModel
{
    public class ConfiguratorViewModel : INotifyPropertyChanged
    {
        private VirtualHost virtualHost;
        public event PropertyChangedEventHandler PropertyChanged;
        private int height = 350;
        private int width = 700;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (sender is ConfiguratorWebView view)
            {
                var localPath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, @"resource\wwwroot");
                virtualHost = new VirtualHost(view.configuratorWebView, "rubens.example", localPath);
            }
        }

        public void ChangeWidth(double newWidth)
        {
            int closestWidth = SelectNearestItem(new []{ 350, 395, 500, 700 }, newWidth);
            if (closestWidth != width)
            {
                width = closestWidth;
                Console.WriteLine($"{{ \"width\" : {width} }}");
                virtualHost?.PostMessageAsJson($"{{ \"width\" : {width} }}");
            }
        }

        public void ChangeHeight(double newHeight)
        {
            int closestHeight = SelectNearestItem(new[] { 100, 175, 250, 350, 395 }, newHeight);
            if (closestHeight != height)
            {
                height = closestHeight;
                Console.WriteLine($"{{ \"height\" : {height} }}");
                virtualHost?.PostMessageAsJson($"{{ \"height\" : {height} }}");
            }
        }

        private int SelectNearestItem(IEnumerable<int> items, double value) =>
            items
                .ToList()
                .Aggregate((a, b) => Math.Abs(a - value) < Math.Abs(b - value) ? a : b);
    }
}
