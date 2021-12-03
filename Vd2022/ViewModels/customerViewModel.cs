using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vd2022.Models;

namespace Vd2022.ViewModels
{
    public class customerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
    }
}