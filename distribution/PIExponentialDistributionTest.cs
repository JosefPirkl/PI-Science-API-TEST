using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PIExponentialDistribution (<see cref="pi.science.distribution.PIExponentialDistribution"/>).
  /// </summary>

  [TestClass]
  public class PIExponentialDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * Exponential distribution.
       */

      PIDebug.TitleBig( "Exponential distribution (1)" );

      PIExponentialDistribution distribution = new PIExponentialDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X" );

      /* lambda=1 */
      PIDebug.Title( "..lambda=1" );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );
      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetProbability( 1.0 ) );
      Assert.AreEqual( 0.632, distribution.GetProbability( 1.0 ), 0.001 );
      Console.WriteLine( "Probability for x=2.0 : " + distribution.GetProbability( 2.0 ) );
      Assert.AreEqual( 0.864, distribution.GetProbability( 2.0 ), 0.001 );
      Console.WriteLine( "Probability for x=3.0 : " + distribution.GetProbability( 3.0 ) );
      Assert.AreEqual( 0.950, distribution.GetProbability( 3.0 ), 0.001 );
      Console.WriteLine( "Probability for x=5.0 : " + distribution.GetProbability( 5.0 ) );
      Assert.AreEqual( 0.9932, distribution.GetProbability( 5.0 ), 0.001 );

      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability", true );

      /* lambda=1  */
      PIDebug.Title( "..lambda=1" );

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetXForProbability( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetXForProbability( 0.0 ), 0.001 );
      Console.WriteLine( "X value for probability for prob=0.632 : " + distribution.GetXForProbability( 0.632 ) );
      Assert.AreEqual( 1.0, distribution.GetXForProbability( 0.632 ), 0.001 );
      Console.WriteLine( "X value for probability for prob=0.864 : " + distribution.GetXForProbability( 0.864 ) );
      Assert.AreEqual( 2.0, distribution.GetXForProbability( 0.864 ), 0.01 );
      Console.WriteLine( "X value for probability for prob=0.950 : " + distribution.GetXForProbability( 0.950 ) );
      Assert.AreEqual( 3.0, distribution.GetXForProbability( 0.950 ), 0.01 );
      Console.WriteLine( "X value for probability for prob=0.9932 : " + distribution.GetXForProbability( 0.9932 ) );
      Assert.AreEqual( 5.0, distribution.GetXForProbability( 0.9932 ), 0.01 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, lambda=1", true );

      Console.WriteLine( "x=0.1 : " + distribution.GetPDF( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.GetPDF( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=5.0 : " + distribution.GetPDF( 5.0 ) );

    }
  }
}
