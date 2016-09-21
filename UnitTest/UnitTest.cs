using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graham_scan_WF;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPolygonXY()
        {
            MainForm m = new MainForm();
            Polygon p = new Polygon(m.pictureBox);
            p.AddPoint(10, 15);
            Assert.AreEqual(p.pointsList[p.pointsList.Count - 1].X, 10);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddPointOutOfRange()
        {
            MainForm m = new MainForm();
            Polygon p = new Polygon(m.pictureBox);
            p.AddPoint(55000, 15);
        }


    }
}
