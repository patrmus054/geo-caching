using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    interface IRegisterView
    {
        string UserName { get; }
        string Surname { get; }
        string Email { get; }
        string Password { get; }
        string Password2 { get; }
        event Action SuccesfulRegistration;
        event Action TerminateDialog;
    }
}
