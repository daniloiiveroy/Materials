using ApplicationDesktopUI.Views;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationDesktopUI.ViewModels
{
    public class LoginViewModel
    {
        LoginView _login;
        public LoginViewModel(LoginView login)
        {
            _login = login;
            RegisterEvents();
        }

        void RegisterEvents()
        {
            _login.userName.TextChanged += delegate { TextChange(_login.userName.Text, _login.userName.Font); };
            _login.password.TextChanged += delegate { TextChange(_login.password.Text, _login.password.Font); };
        }

        void TextChange(string text,Font font)
        {
            Size size = TextRenderer.MeasureText(text, font);
            _login.userName.Width = size.Width;
            _login.userName.Height = size.Height;
        }
    }
}
