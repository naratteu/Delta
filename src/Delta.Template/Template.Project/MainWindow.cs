﻿using Delta.WPF;
using Template.Project.Components;
using System.Windows;

namespace Template.Project
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Title = "MVU Application";
            Width = 800;
            Height = 600;
            HotReloadService.UpdateApplicationEvent += ReloadUI;
            ApplicationRoot.Initialize (new CounterComponent (), this);
        }

        private void ReloadUI(Type[] obj)
        {
            Dispatcher.BeginInvoke (() =>
            {
                ApplicationRoot.Instance.Rebuild ();
            });
        }
    }
}