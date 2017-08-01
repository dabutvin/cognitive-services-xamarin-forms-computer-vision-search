using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace VisualSearchApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //AppConstants.ComputerVisionApiKey = <Add your Cognitive Services Vision API Key Here>
            //AppConstants.BingWebSearchApiKey = <Add your Bing Web Search API Key Here>
            
            //Applicable OCR server locations (at time of writing) are: westus, eastus2, westcentralus, westeurope, southeastasia 
            //AppConstants.SetOcrLocation(<add the location of your Computer Vision server here>);

            MainPage = new NavigationPage(new OcrSelectPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}