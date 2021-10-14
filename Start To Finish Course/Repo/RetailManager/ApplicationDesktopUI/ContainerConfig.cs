using ApplicationDesktopUI.ViewModels;
using ApplicationDesktopUI.Views;
using Autofac;
using System.Reflection;

namespace ApplicationDesktopUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ShellView>();
            builder.RegisterType<LoginView>();
            builder.RegisterType<ShellViewModel>();
            builder.RegisterType<LoginViewModel>();
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(ApplicationDesktopUI)))
            //    .Where(x => x.Namespace.Contains("Views"))
            //    .As(x => x.GetInterfaces().FirstOrDefault(i => i.Name == $"I{x.Name}"));

            return builder.Build();
        }
    }
}
