using Microsoft.Web.WebView2.Wpf;
using Microsoft.Web.WebView2.Core;
using System;
using System.Threading.Tasks;

namespace RoomleConfiguratorWpfCSharp.ViewModel
{
    public class VirtualHost
    {
        private WebView2 webView;
        private string hostName;
        private string directory;
        private Task initilizationTask;

        public string Url => $"https://{hostName}/index.html";


        public VirtualHost(WebView2 webView, string hostName, string directory)
        {
            this.webView = webView;
            this.hostName = hostName;
            this.directory = directory;
            initilizationTask = InitializeAsync();
        }

        async private Task InitializeAsync()
        {
            // Wait for CoreWebView2 initialization, Explicitly triggers initialization of the control's CoreWebView2.
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.wpf.webview2.ensurecorewebview2async?view=webview2-dotnet-1.0.1056-prerelease
            await webView.EnsureCoreWebView2Async();

            // Set a mapping between a virtual host name and a folder path to make available to web sites via that host name.
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.setvirtualhostnametofoldermapping?view=webview2-dotnet-1.0.1056-prerelease
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                hostName, directory, CoreWebView2HostResourceAccessKind.DenyCors);

            webView.Source = new Uri(Url);
        }

        public void PostMessage(string message) =>
            webView?.CoreWebView2.PostWebMessageAsString(message);

        public void PostMessageAsJson(string messageAsJson) =>
            webView?.CoreWebView2.PostWebMessageAsJson(messageAsJson);
    }
}
