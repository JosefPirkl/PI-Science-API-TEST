using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PIStudentDistribution (<see cref="pi.science.distribution.PIStudentDistribution"/>).
  /// </summary>

  [TestClass]
  public class PIStudentDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * Student`s distribution.
       */

      PIDebug.TitleBig( "Student`s distribution" );

      PIStudentDistribution distribution = new PIStudentDistribution();

      /* -- 1) Get probability for T */

      PIDebug.Title( "1) Get probability" );

      /* DF=1 */

      PIDebug.Title( "..df=1" );

      distribution.SetDF( 1 );

      Console.WriteLine( "Probability for x=0.0, df=1 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 0.0 ), 0.1 );
      Console.WriteLine( "Probability for x=1, df=1 : " + distribution.GetProbability( 1.00 ) );
      Assert.AreEqual( 0.5, (double)distribution.GetProbability( 1.00 ), 0.1 );
      Console.WriteLine( "Probability for x=15.89, df=1 : " + distribution.GetProbability( 15.89 ) );
      Assert.AreEqual( 0.04, (double)distribution.GetProbability( 15.89 ), 0.1 );
      Console.WriteLine( "Probability for x=636.6, df=1 : " + distribution.GetProbability( 636.6 ) );
      Assert.AreEqual( 0.001, (double)distribution.GetProbability( 636.6 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 2 );

      Console.WriteLine( "Probability for x=0.0, df=2 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 0.0 ), 0.1 );
      Console.WriteLine( "Probability for x=0.816, df=2 : " + distribution.GetProbability( 0.816 ) );
      Assert.AreEqual( 0.5, (double)distribution.GetProbability( 0.816 ), 0.1 );
      Console.WriteLine( "Probability for x=4.849, df=2 : " + distribution.GetProbability( 4.849 ) );
      Assert.AreEqual( 0.04, (double)distribution.GetProbability( 4.849 ), 0.1 );
      Console.WriteLine( "Probability for x=31.6, df=2 : " + distribution.GetProbability( 31.6 ) );
      Assert.AreEqual( 0.001, (double)distribution.GetProbability( 31.6 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 3 );

      Console.WriteLine( "Probability for x=0.0, df=3 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 0.0 ), 0.1 );
      Console.WriteLine( "Probability for x=0.765, df=3 : " + distribution.GetProbability( 0.765 ) );
      Assert.AreEqual( 0.5, (double)distribution.GetProbability( 0.765 ), 0.1 );
      Console.WriteLine( "Probability for x=3.482, df=3 : " + distribution.GetProbability( 3.482 ) );
      Assert.AreEqual( 0.04, (double)distribution.GetProbability( 3.482 ), 0.1 );
      Console.WriteLine( "Probability for x=12.92, df=3 : " + distribution.GetProbability( 12.92 ) );
      Assert.AreEqual( 0.001, (double)distribution.GetProbability( 12.92 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 4 );

      Console.WriteLine( "Probability for x=0.0, df=4 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 0.0 ), 0.1 );
      Console.WriteLine( "Probability for x=0.741, df=4 : " + distribution.GetProbability( 0.741 ) );
      Assert.AreEqual( 0.5, (double)distribution.GetProbability( 0.741 ), 0.1 );
      Console.WriteLine( "Probability for x=2.999, df=4 : " + distribution.GetProbability( 2.999 ) );
      Assert.AreEqual( 0.04, (double)distribution.GetProbability( 2.999 ), 0.1 );
      Console.WriteLine( "Probability for x=8.610, df=4 : " + distribution.GetProbability( 8.610 ) );
      Assert.AreEqual( 0.001, (double)distribution.GetProbability( 8.610 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 5 );

      Console.WriteLine( "Probability for x=2.757, df=5 : " + distribution.GetProbability( 2.757 ) );
      Assert.AreEqual( 0.04, (double)distribution.GetProbability( 2.757 ), 0.1 );

      distribution.SetDF( 10 );

      Console.WriteLine( "Probability for x=1.372, df=10 : " + distribution.GetProbability( 1.372 ) );
      Assert.AreEqual( 0.2, (double)distribution.GetProbability( 1.372 ), 0.1 );


      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get T for probability", true );

      /* DF=1 */

      PIDebug.Title( "..df=1" );

      distribution.SetDF( 1 );

      Console.WriteLine( "X value for probability for prob=1.0, df=1 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 1.0 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.5, df=1 : " + distribution.GetXForProbability( 0.5 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetXForProbability( 0.5 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.04, df=1 : " + distribution.GetXForProbability( 0.04 ) );
      Assert.AreEqual( 15.89, (double)distribution.GetXForProbability( 0.04 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.001, df=1 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 636.6, (double)distribution.GetXForProbability( 0.001 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 2 );

      Console.WriteLine( "X value for probability for prob=1.0, df=2 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 1.0 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.5, df=2 : " + distribution.GetXForProbability( 0.5 ) );
      Assert.AreEqual( 0.816, (double)distribution.GetXForProbability( 0.5 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.04, df=2 : " + distribution.GetXForProbability( 0.04 ) );
      Assert.AreEqual( 4.849, (double)distribution.GetXForProbability( 0.04 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.001, df=2 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 31.6, (double)distribution.GetXForProbability( 0.001 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 3 );

      Console.WriteLine( "X value for probability for prob=1.0, df=3 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 1.0 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.5, df=3 : " + distribution.GetXForProbability( 0.5 ) );
      Assert.AreEqual( 0.765, (double)distribution.GetXForProbability( 0.5 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.04, df=3 : " + distribution.GetXForProbability( 0.04 ) );
      Assert.AreEqual( 3.482, (double)distribution.GetXForProbability( 0.04 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.001, df=3 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 12.92, (double)distribution.GetXForProbability( 0.001 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 4 );

      Console.WriteLine( "X value for probability for prob=1.0, df=4 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 1.0 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.5, df=4 : " + distribution.GetXForProbability( 0.5 ) );
      Assert.AreEqual( 0.741, (double)distribution.GetXForProbability( 0.5 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.04, df=4 : " + distribution.GetXForProbability( 0.04 ) );
      Assert.AreEqual( 2.999, (double)distribution.GetXForProbability( 0.04 ), 0.1 );
      Console.WriteLine( "X value for probability for prob=0.04, df=4 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 8.610, (double)distribution.GetXForProbability( 0.001 ), 0.1 );

      PIDebug.Blank();

      distribution.SetDF( 5 );

      Console.WriteLine( "X value for probability for prob=0.04, df=5 : " + distribution.GetXForProbability( 0.04 ) );
      Assert.AreEqual( 2.757, (double)distribution.GetXForProbability( 0.04 ), 0.1 );

      distribution.SetDF( 10 );

      Console.WriteLine( "X value for probability for prob=0.2, df=10 : " + distribution.GetXForProbability( 0.2 ) );
      Assert.AreEqual( 1.372, (double)distribution.GetXForProbability( 0.2 ), 0.1 );

      PIDebug.Blank();

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, df=1", true );

      distribution.SetDF( 1 );

      Console.WriteLine( "x=-7.0 : " + distribution.GetPDF( -7.0 ) );
      Console.WriteLine( "x=-2.0 : " + distribution.GetPDF( -2.0 ) );
      Console.WriteLine( "x=-0.5 : " + distribution.GetPDF( -0.5 ) );
      Console.WriteLine( "x=0.0 : " + distribution.GetPDF( 0.0 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=7.0 : " + distribution.GetPDF( 7.0 ) );

    }

  }

}
