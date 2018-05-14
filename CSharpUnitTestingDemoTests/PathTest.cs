using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharpUnitTestingDemo;

namespace CSharpUnitTestingDemo.Tests

{
    public class PathTests
    {
        Map map;
        MapLocation[] pathLocations;
        Path target;

        public PathTests() {
            map = new Map(3, 4);
            pathLocations = new MapLocation[]
                {
                new MapLocation(0, 1, map),
                    new MapLocation(1, 1, map),
                    new MapLocation(2, 1, map)
                };
            target = new Path(pathLocations);
        }

        [Fact]
        public void MapLocationIsOnPath()
        {            
            Assert.True(target.IsOnPath(new MapLocation(0,1, map)));
        }

        [Fact]
        public void MapLocationIsNotOnPath()
        {          
            Assert.False(target.IsOnPath(new MapLocation(2, 3, map)));
        }

    }
}
