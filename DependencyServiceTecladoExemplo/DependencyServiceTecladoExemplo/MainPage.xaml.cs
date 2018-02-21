using DependencyServiceTecladoExemplo.Helpers;
using System;
using Xamarin.Forms;

namespace DependencyServiceTecladoExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnEsconderTeclado_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IKeyboardHelper>().HideKeyboard();
        }
    }
}
