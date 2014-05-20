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
    public class ViewWithTemplateViewModel : BindableBase, IRegionManagerAware, INotifyPropertyChanged
    {
        private IRegionManager regionManager;

        public ViewWithTemplateViewModel()
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
                    this.regionManager.Regions["RegionInTemplate"].Add(new CommonView());
                });
            }
        }
    }
}
