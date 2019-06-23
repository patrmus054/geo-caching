using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    public interface ILoginView
    {
        string login { get; }
        string password { get; }

        event Action authorize;
    }
}
