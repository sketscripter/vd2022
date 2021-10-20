using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vd2022.Models;

namespace Vd2022.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}