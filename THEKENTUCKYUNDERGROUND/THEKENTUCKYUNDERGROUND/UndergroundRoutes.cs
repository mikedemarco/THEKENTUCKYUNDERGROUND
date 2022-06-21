using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    public class UndergroundRoutes
    {
        public int TunnelNumber { get; }
        public int miles { get; }
        public string StartingPoint => PlacesServed[0];
        public string EndingPoint => PlacesServed[^1];
        public string[] PlacesServed { get; }
        public UndergroundRoutes(int number, string[] placesServed)
        {
            this.TunnelNumber = number;
            this.PlacesServed = placesServed;

        }
        public override string ToString() => $"{TunnelNumber}: {StartingPoint} -> {EndingPoint}";
        public bool Serves(string EndingPoint)
        {
            return Array.Exists(PlacesServed, place => place == EndingPoint);
        }
    }
}

