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
            var releases = Api.GetNewReleases();
            Console.WriteLine(releases);

            //var titles = Wrapper.GetNewReleaseTitles();

            //titles.ToList().ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
