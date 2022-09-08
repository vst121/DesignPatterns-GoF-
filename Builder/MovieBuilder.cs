using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        private Movie movie= new Movie();

        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.Text, 5);
        }

        public Movie GetMovie()
        {
            return movie;
        }
    }
}
