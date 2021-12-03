using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vd2022.Models;

namespace Vd2022.ViewModels
{
    public class movieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}