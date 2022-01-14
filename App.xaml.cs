using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using PrismDemo.Core.Regions;
using PrismDemo.Views;
using System.Windows;
using System.Windows.Controls;

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

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings mappings)
        {
            base.ConfigureRegionAdapterMappings(mappings);

            mappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
        }
    }
}
