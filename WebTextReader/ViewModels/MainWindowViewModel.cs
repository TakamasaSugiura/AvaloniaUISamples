using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Avalonia.Media;

namespace WebTextReader.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _url = "";
        public string Url
        {
            get => _url;
            set => this.RaiseAndSetIfChanged(ref _url, value);
        }

        private string _webContent = "";
        public string WebContent
        {
            get => _webContent;
            set => this.RaiseAndSetIfChanged(ref _webContent, value);
        }

        private bool _hasError = false;
        public bool HasError
        {
            get => _hasError;
            set => this.RaiseAndSetIfChanged(ref _hasError, value);
        }


        private bool _canGet = true;
        public bool CanGet
        {
            get => _canGet;
            set => this.RaiseAndSetIfChanged(ref _canGet, value);
        }

        public async void GetContent()
        {
            try
            {
                CanGet = false;
                var request = WebRequest.Create(Url);
                using var response = request.GetResponse();
                using var stream = response.GetResponseStream();
                using var reader = new StreamReader(stream);
                var text = await reader.ReadToEndAsync();
                WebContent = text;
                HasError = false;
            }
            catch (Exception ex)
            {
                WebContent = ex.ToString();
                HasError = true;
            }
            finally
            {
                CanGet = true;
            }
        }
    }
}
