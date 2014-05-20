using Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.ViewModel;
using ModuleWithTemplate.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleWithTemplate.ViewModels
{
    public class ViewWithTemplateAndScopedRegionViewModel : BindableBase, IRegionManagerAware, INotifyPropertyChanged
    {
        private IRegionManager regionManager;

        public ViewWithTemplateAndScopedRegionViewModel()
        {
        }

        // This property will be set by the RegionManagerAwareBehavior
        public IRegionManager RegionManager
        {
            get
            {
                return this.regionManager;
            }

            set
            {
                this.regionManager = value;
                this.OnPropertyChanged("RegionManager");
            }
        }

        public DelegateCommand AddItem
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    this.regionManager.Regions["MainRegion"].Add(new CommonView());
                });
            }
        }
    }
}
