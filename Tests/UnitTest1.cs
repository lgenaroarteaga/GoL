using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmpty()
        {
            GoL.Grid grid = new GoL.Grid(10, 10);
            Assert.AreEqual(grid.CountCells(), 0);
        }

        [TestMethod]
        public void TestNElements()
        {
            GoL.Grid grid = new GoL.Grid(10, 10);
            grid.SetCell(5,5, true);
            grid.SetCell(5, 5, true);
            grid.SetCell(2, 5, true);
            Assert.AreEqual(grid.CountCells(), 2);
        }

        [TestMethod]
        public void Neighbours0() {
            GoL.Grid grid = new GoL.Grid(10, 10);
            grid.SetCell(5, 5, true);
            Assert.AreEqual(grid.CountNeighbours(5,5), 0);
        }

        [TestMethod]
        public void Neighbours1()
        {
            GoL.Grid grid = new GoL.Grid(10, 10);
            grid.SetCell(5, 5, true);
            Assert.AreEqual(grid.CountNeighbours(5, 4), 1);
        }

        [TestMethod]
        public void Neighbours2() {
            GoL.Grid grid = new GoL.Grid(10, 10);
            grid.SetCell(0, 0, true);
            Assert.AreEqual(grid.CountNeighbours(0,1), 1);
        }

        [TestMethod]
        public void Neighbours3()
        {
            GoL.Grid grid = new GoL.Grid(10, 10);
            grid.SetCell(-1, -1, true);
            Assert.AreEqual(grid.CountNeighbours(0, 1), 1);
        }

    }
}
