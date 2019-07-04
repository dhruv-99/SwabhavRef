using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movies = new Folder("Movies");
            Folder hindiMovies = new Folder("Hindi Movies");
            Folder comedyMovies = new Folder("Comedy Movies");
            File movieA = new File("Movie A", ".avi", 500);
            File movieB = new File("Movie B", ".mp4", 400);
            File movieC = new File("Movie C", ".mpeg", 250);
            File movieD = new File("Movie D", ".avi", 300);
            File movieE = new File("Movie E", ".mp4", 600);
            File movieF = new File("Movie F", ".avi", 800);

            movies.AddItem(movieA);
            movies.AddItem(movieE);
            movies.AddItem(hindiMovies);
            movies.AddItem(comedyMovies);
           
            hindiMovies.AddItem(movieB);
            hindiMovies.AddItem(movieC);
            comedyMovies.AddItem(movieD);
            movies.AddItem(movieF);
            movies.Display(1); 
        }
    }
}
