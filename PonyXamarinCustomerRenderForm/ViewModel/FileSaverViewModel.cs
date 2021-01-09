//using PCLStorage;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PonyXamarinCustomerRenderForm.ViewModel
{
    class FileSaverViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _url;
        public string urlPath
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
                OnPropertyChanged("urlPath");
            }
        }

        public FileSaverViewModel()
        {
            DownloadCommand = new Command(Start);
        }

        private async void Start()
        {
            await LaunchURLForSync();
        }
        private async Task LaunchURLForSync()
        {
            if (urlPath != null)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    Uri uri = new Uri(urlPath);

                    var targetFile = "/sdcard/foodWithMetaWithDataDownloaded.db";
                    if (Device.RuntimePlatform == Device.WPF)
                    {
                        targetFile = "s:\\foodWithMetaWithDataDownloaded.db";
                    }


                    using (FileStream file = new FileStream(targetFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {


                        var httpResponse = await client.GetAsync(uri);
                        byte[] dataBuffer = await httpResponse.Content.ReadAsByteArrayAsync();
                        await file.WriteAsync(dataBuffer, 0, dataBuffer.Length);
                        //await fileHandler.WriteAsync(dataBuffer, 0, dataBuffer.Length);
                    }
                }
                catch (Exception ex)
                {

                    int i = 30;

                    Debug.WriteLine(ex.Message);
                }
            }
        }




        public ICommand DownloadCommand { private set; get; }
    }
}
