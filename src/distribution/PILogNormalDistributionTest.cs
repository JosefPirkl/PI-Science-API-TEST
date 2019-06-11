using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PILogNormalDistribution (<see cref="pi.science.distribution.PILogNormalDistribution"/>).
  /// </summary>

  [TestClass]
  public class PILogNormalDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * Log Normal distribution.
       */

      PIDebug.TitleBig( "Log Normal distribution (0,1)" );

      PILogNormalDistribution distribution = new PILogNormalDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X" );

      /* SD=1 */
      PIDebug.Title( "..SD=1" );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );
      Console.WriteLine( "Probability for x=0.776 : " + distribution.GetProbability( 0.776 ) );
      Assert.AreEqual( 0.4, distribution.GetProbability( 0.776 ), 0.001 );
      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetProbability( 1.0 ) );
      Assert.AreEqual( 0.5, distribution.GetProbability( 1.0 ), 0.001 );
      Console.WriteLine( "Probability for x=1.288 : " + distribution.GetProbability( 1.288 ) );
      Assert.AreEqual( 0.6, distribution.GetProbability( 1.288 ), 0.001 );
      Console.WriteLine( "Probability for x=3.602 : " + distribution.GetProbability( 3.602 ) );
      Assert.AreEqual( 0.9, distribution.GetProbability( 3.602 ), 0.001 );

      /* SD=2 */
      PIDebug.Title( "..SD=2", true );

      distribution.SetSD( 2.0 );

      /* -- get probability from x value */

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );
      Console.WriteLine( "Probability for x=0.602 : " + distribution.GetProbability( 0.602 ) );
      Assert.AreEqual( 0.4, distribution.GetProbability( 0.602 ), 0.001 );
      Console.WriteLine( "Probability for x=12.976 : " + distribution.GetProbability( 12.976 ) );
      Assert.AreEqual( 0.9, distribution.GetProbability( 12.976 ), 0.001 );

      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability", true );

      /* SD=1 */
      PIDebug.Title( "..SD=1" );

      distribution.SetSD( 1 );

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetXForProbability( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetXForProbability( 0.0 ), 0.001 );
      Console.WriteLine( "X value for probability for prob=0.01 : " + distribution.GetXForProbability( 0.01 ) );
      Assert.AreEqual( 0.098, distribution.GetXForProbability( 0.01 ), 0.001 );
      Console.WriteLine( "X value for probability for prob=0.4 : " + distribution.GetXForProbability( 0.4 ) );
      Assert.AreEqual( 0.776, distribution.GetXForProbability( 0.4 ), 0.001 );
      Console.WriteLine( "X value for probability for prob=0.9 : " + distribution.GetXForProbability( 0.9 ) );
      Assert.AreEqual( 3.602, distribution.GetXForProbability( 0.9 ), 0.001 );

      PIDebug.Title( "..SD=2", true );

      distribution.SetSD( 2.0 );

      Console.WriteLine( "X value for probability for prob=0.4 : " + distribution.GetXForProbability( 0.4 ) );
      Assert.AreEqual( 0.602, distribution.GetXForProbability( 0.4 ), 0.001 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, SD=1", true );

      distribution.SetSD( 1 );

      Console.WriteLine( "x=0.1 : " + distribution.CalcProbabilityDensity( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.CalcProbabilityDensity( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.CalcProbabilityDensity( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.CalcProbabilityDensity( 2.0 ) );

    }
  }
}
