using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Microsoft.Win32;

namespace obr.MainViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string pathtoimg;
        public string PathToImg { get => PathToImg; set { PathToImg = value; NotifyPropertyChanged(); } }
        public void LoadImg()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var result = openFileDialog.ShowDialog();
            if ((bool)result) PathToImg = openFileDialog.FileName;
        }





        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
