using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD popestar = new CD("Popestar", "Ghost", "23:37");
            Song square = new Song("Square Hammer", "3:59");
            Song noctrl = new Song("Nocturnal Me", "5:13");
            Song blv = new Song("I Believe", "4:06");
            Song mssnr = new Song("Missionary Man", "3:42");
            Song bible = new Song("Bible", "6:34");

            popestar.AddSong(square);
            popestar.AddSong(noctrl);
            popestar.AddSong(blv);
            popestar.AddSong(mssnr);
            popestar.AddSong(bible);

        
            Console.WriteLine(popestar.ToString());


        }
    }
}
