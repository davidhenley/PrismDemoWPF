using Prism.DryIoc;
using Prism.Ioc;
using PrismDemo.Views;
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
            
        }

        protected override Window CreateShell() => Container.Resolve<ShellView>();
    }
}
