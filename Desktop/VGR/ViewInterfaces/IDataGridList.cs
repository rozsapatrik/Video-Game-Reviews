using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.ViewInterfaces
{
    interface IDataGridList<G>
    {
        BindingList<G> BindingList { get; set; }
        int page { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { get;  set; }
    }
}
