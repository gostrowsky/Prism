using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ModuleWithTemplate.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleWithTemplate 
{
    public class ModuleWithTemplateModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public ModuleWithTemplateModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            this.regionManager.Regions["MainRegion"].Add(this.container.Resolve<ViewWithTemplate>());
            var scopedManager = this.regionManager.Regions["MainRegion"].Add(this.container.Resolve<ViewWithTemplateAndScopedRegion>(), "ViewWithScopedRegion", true); // Creates a scoped region manager.
        }
    }
}
