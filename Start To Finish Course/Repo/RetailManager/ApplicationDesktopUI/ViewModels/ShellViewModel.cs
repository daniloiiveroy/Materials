using ApplicationDesktopUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        LoginView _login;

        ShellView _shell;

        public ShellViewModel(ShellView shell, LoginView login, LoginViewModel loginView)
        {
            _shell = shell;
            _login = login;
            ActivateLogin();
        }

        void ActivateLogin()
        {
            _shell.form.ShellPanelView.Controls.Clear();
            _shell.form.ShellPanelView.Controls.Add(_login.view);
            _login.view.Dock = DockStyle.Fill;
        }

        public Form Run()
        {
            return _shell.form;
        }
    }
}
