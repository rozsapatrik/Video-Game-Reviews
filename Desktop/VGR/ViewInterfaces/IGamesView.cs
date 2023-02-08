using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.ViewInterfaces
{
    public interface IGamesView
    {
        games game { get; set; }
        string errorName { get; set; }
    }
}
