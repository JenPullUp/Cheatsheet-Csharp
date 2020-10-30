using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E2_week7b
{
    class ArtCollection
    {
        public List<ArtPiece> pieces;

        public ArtCollection()
        {
            pieces = new List<ArtPiece>();
            pieces.Add(new ArtPiece(ArtType.Painting, "De aardappeleters", 1885, true));
            pieces.Add(new ArtPiece(ArtType.Statue, "The thinker", 1880, true));
            pieces.Add(new ArtPiece(ArtType.Painting, "Untitled", 1720, false));
            pieces.Add(new ArtPiece(ArtType.Performance, "The Artist is Present", 2010, false));
            pieces.Add(new ArtPiece(ArtType.Painting, "Starry night", 1889, true));
            pieces.Add(new ArtPiece(ArtType.Statue, "Puppy", 1992, true));
            pieces.Add(new ArtPiece(ArtType.Painting, "Who's Afraid of Red, Yellow and Blue", 1967, false));
            pieces.Add(new ArtPiece(ArtType.Painting, "Untitled", 1981, true));
            pieces.Add(new ArtPiece(ArtType.Painting, "Abstract shapes", 1981, false));
        }

        public static void Print<T>(IEnumerable<T> list, string header)
        {
            Console.WriteLine($"-----{header}-----");
            foreach (var item in list.ToList())
            {
                Console.WriteLine(item.ToString());
            }
            //list.ForEach(o => Console.WriteLine(o.ToString()));
        }

        public IEnumerable<ArtPiece> UnsoldPieces()
        {
            return pieces.Where(p => !p.Sold);
        }

        public IEnumerable<string> SoldFrom20thCentury()
        {
            return pieces.Where(p => p.Year >= 1901 && p.Year <= 2000).Select(p=> p.Name);
        }

        public IEnumerable<ArtPiece> ArtFromLast10Years()
        {
            DateTime currentTime = DateTime.Today;
            return pieces.Where(p => p.Year >= currentTime.Year - 10 && p.Year <= currentTime.Year);
        }

        public IEnumerable<ArtPiece> SortedPaintings()
        {
            return pieces.OrderByDescending(p => p.Year).ThenBy(p => p.Name);
        }





    }
}
