using System;
using System.Linq;

namespace E2_week7b
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtCollection artCollection = new ArtCollection();
            ArtCollection.Print(artCollection.UnsoldPieces(), "unsold");
            ArtCollection.Print(artCollection.SoldFrom20thCentury(), "Sold in 20th cent");
            ArtCollection.Print(artCollection.ArtFromLast10Years(), "Art from last 10 years");
            ArtCollection.Print(artCollection.SortedPaintings(), "Sorted list");


        }
    }
}
