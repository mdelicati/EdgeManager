﻿using System;
using System.Collections.Generic;
using System.Text;
using EdgeManager.Interfaces.Commands;
using EdgeManager.Interfaces.Services;

namespace EdgeManager.Gui.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IViewModelFactory viewModelFactory;
        private readonly IPowerShell powerShell;

        public MainWindowViewModel(IViewModelFactory viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
        }

        public TabsViewModel TabsViewModel { get; set; }
        public HubViewModel HubViewModel { get; set; }
        public DeviceViewModel DeviceViewModel { get; set; }

        public override void Initialize()
        {
            TabsViewModel = viewModelFactory.CreateViewModel<TabsViewModel>();
            HubViewModel = viewModelFactory.CreateViewModel<HubViewModel>();
            DeviceViewModel = viewModelFactory.CreateViewModel<DeviceViewModel>();
        }


    }

    public class DesignMainWindowViewModel : MainWindowViewModel
    {
        public DesignMainWindowViewModel() : base(ViewModelLocator.DesignViewModelFactory)
        {
        }
    }
}