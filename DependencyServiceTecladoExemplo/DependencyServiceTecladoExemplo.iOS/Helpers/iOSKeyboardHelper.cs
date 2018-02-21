using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyServiceTecladoExemplo.Helpers;
using DependencyServiceTecladoExemplo.iOS.Helpers;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSKeyboardHelper))]
namespace DependencyServiceTecladoExemplo.iOS.Helpers
{
    public class iOSKeyboardHelper : IKeyboardHelper
    {
        public void HideKeyboard()
        {
            UIApplication.SharedApplication.KeyWindow.EndEditing(true);
        }
    }
}