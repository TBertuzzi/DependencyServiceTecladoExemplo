﻿using Android.App;
using Android.Content;
using Android.Views.InputMethods;
using DependencyServiceTecladoExemplo.Droid.Helpers;
using DependencyServiceTecladoExemplo.Helpers;
using Xamarin.Forms;


[assembly: Dependency(typeof(DroidKeyboardHelper))]
namespace DependencyServiceTecladoExemplo.Droid.Helpers
{
    public class DroidKeyboardHelper : IKeyboardHelper
    {
        public void HideKeyboard()
        {
            var context = Forms.Context;
            var inputMethodManager = context.GetSystemService(Context.InputMethodService) as InputMethodManager;
            if (inputMethodManager != null && context is Activity)
            {
                var activity = context as Activity;
                var token = activity.CurrentFocus?.WindowToken;
                inputMethodManager.HideSoftInputFromWindow(token, HideSoftInputFlags.None);

                activity.Window.DecorView.ClearFocus();
            }
        }
    }
}