using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.ViewInterfaces
{
    interface IGamesListView: IDataGridList<games>
    {
        BindingList<games> gamesList { get; set; }
    }
}
