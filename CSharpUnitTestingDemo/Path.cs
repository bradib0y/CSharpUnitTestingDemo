using System;
using System.Linq;

namespace CSharpUnitTestingDemo
{
    public class Path
    {
        private MapLocation[] pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            this.pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation)
        {
            bool b = pathLocations.Contains(mapLocation);
            return Array.IndexOf(pathLocations, mapLocation) >= 0;
        }
    }
}