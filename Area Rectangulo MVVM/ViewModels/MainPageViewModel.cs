using Area_Rectangulo_MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Area_Rectangulo_MVVM.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _base;

        [ObservableProperty]
        private double _altura;

        [ObservableProperty]
        private double _resultado;

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                Rectangulo r = new Rectangulo();
                r.Base = Base;
                r.Altura = Altura;

                Resultado = r.Calcular();
            } catch (Exception ex) {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Base = 0;
            Altura = 0;
            Resultado = 0;
        }
    }
}
