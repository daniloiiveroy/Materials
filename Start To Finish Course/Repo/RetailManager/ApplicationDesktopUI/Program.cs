using ApplicationDesktopUI.ViewModels;
using ApplicationDesktopUI.Views;
using Autofac;
using System;
using System.Windows.Forms;

namespace ApplicationDesktopUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<ShellViewModel>();
                Application.Run(app.Run());
                
            }
        }
    }
}
