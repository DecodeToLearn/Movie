using System;
using System.Collections.Generic;

namespace Example.Models
{
    public class MovieCategoryModel
    {
        public Movie movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

