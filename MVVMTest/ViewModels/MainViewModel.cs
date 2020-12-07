using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MVVMTest.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            LoadCommand = new AsyncRelayCommand<string>(Load);
        }

        /// <summary>
        /// Gets the <see cref="IAsyncRelayCommand{T}"/> responsible for loading the source markdown docs.
        /// </summary>
        public IAsyncRelayCommand<string> LoadCommand { get; }

        private async Task Load(string arg)
        {
            await Task.Delay(500);
            Debug.WriteLine("Loaded event!");
        }
    }
}