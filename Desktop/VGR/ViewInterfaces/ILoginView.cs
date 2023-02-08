using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGR.ViewInterfaces
{
    interface ILoginView
    {
        string UserName { get; }
        string Password { get; }
        string ErrorUserName { set; }
        string ErrorPassword { set; }
    }
}
