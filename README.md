# WebView

## Important methods

- [EnsureCoreWebView2Async](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.wpf.webview2.ensurecorewebview2async?view=webview2-dotnet-1.0.1056-prerelease)

   Wait for CoreWebView2 initialization, Explicitly triggers initialization of the control's CoreWebView2.

- [SetVirtualHostNameToFolderMapping]( https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.setvirtualhostnametofoldermapping?view=webview2-dotnet-1.0.1056-prerelease)

  Set a mapping between a virtual host name and a folder path to make available to web sites via that host name.

- [CoreWebView2.PostWebMessageAsJson](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.postwebmessageasjson?view=webview2-dotnet-1.0.1056-prerelease)

  Posts the specified webMessageAsJson to the top level document in this WebView.

- [CoreWebView2.PostWebMessageAsString](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.postwebmessageasstring?view=webview2-dotnet-1.0.1056-prerelease)

  Posts a message that is a simple String rather than a JSON string representation of a JavaScript object.

## Resources

- [WebView2 sample code](https://docs.microsoft.com/en-us/microsoft-edge/webview2/code-samples-links)  
- [MicrosoftEdge/WebView2Samples](https://github.com/MicrosoftEdge/WebView2Samples)

# Roomel SDK

[Roomle - Embedding Integration](https://docs.roomle.com/web/embedding/#getting-started)

Get sdk ([@roomle/embedding-lib](https://www.npmjs.com/package/@roomle/embedding-lib)):

```lang-none
npm i @roomle/embedding-lib
```