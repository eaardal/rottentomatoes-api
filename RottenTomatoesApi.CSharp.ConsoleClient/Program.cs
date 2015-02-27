using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenTomatoesApi.CSharp.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var office = Api.Movies.GetBoxOffice();
            
            Console.ReadLine();
        }
    }
}
