﻿using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace PrismDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new System.NotImplementedException();
        }

        protected override Window CreateShell()
        {
            throw new System.NotImplementedException();
        }
    }
}
