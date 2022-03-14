using CustomWebViewTest;
using CustomWebViewTest.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace CustomWebViewTest.UWP
{
    public class CustomWebViewRenderer : ViewRenderer<CustomWebView, WebView2>
    {
        WebView2 _webView2;

        protected override void OnElementChanged(ElementChangedEventArgs<CustomWebView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    _webView2 = new WebView2();
                    SetNativeControl(_webView2);
                    _webView2.NavigationCompleted += OnWebViewNavigationCompleted;
                    _webView2.Source = new Uri(Element.Uri);
                }


            }
        }

        private void OnWebViewNavigationCompleted(WebView2 sender, CoreWebView2NavigationCompletedEventArgs args)
        {

        }
    }
}
