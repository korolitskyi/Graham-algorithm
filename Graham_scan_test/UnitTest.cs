using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graham_scan_WF;
using System.Drawing;

namespace Graham_scan_test
{
    [TestClass]
    public class PolygonUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRangeAddPointX()
        {
            MainForm mf = new MainForm();            
            Polygon p = new Polygon(mf.pictureBox);
            p.AddPoint(56000, 5);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRangeAddPointY()
        {
            MainForm mf = new MainForm();   
            Polygon p = new Polygon(mf.pictureBox);
            p.AddPoint(5, 56000);            
        }                 
        

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorNullArguments()
        {            
            Polygon p = new Polygon(null);
        }              
        

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSolveNullArguments()
        {            
            MainForm mf = new MainForm(); 
            Polygon p = new Polygon(mf.pictureBox);
            Point[] points = null;
            p.Solve(ref points);
        }
    }
}
