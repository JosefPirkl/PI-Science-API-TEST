using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PICHISquareDistribution (<see cref="pi.science.distribution.PICHISquareDistribution"/>).
  /// </summary>

  [TestClass]
  public class PICHISquareDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
     * CHI-SQUARE distribution.
		 */

      PIDebug.TitleBig( "Chi-square distribution" );

      PICHISquareDistribution distribution = new PICHISquareDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability" );

      /* DF=1 */

      PIDebug.Title( "..df=1" );

      distribution.SetDF( 1 );

      Console.WriteLine( "Probability for x=0.0, df=1 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 0.0 ), 0.1 );

      Console.WriteLine( "Probability for x=0.001, df=1 : " + distribution.GetProbability( 0.001 ) );
      Assert.AreEqual( 0.975, (double)distribution.GetProbability( 0.001 ), 0.001 );

      Console.WriteLine( "Probability for x=2.706, df=1 : " + distribution.GetProbability( 2.706 ) );
      Assert.AreEqual( 0.100, (double)distribution.GetProbability( 2.706 ), 0.001 );

      Console.WriteLine( "Probability for x=5.024, df=1 : " + distribution.GetProbability( 5.024 ) );
      Assert.AreEqual( 0.025, (double)distribution.GetProbability( 5.024 ), 0.001 );

      Console.WriteLine( "Probability for x=200, df=1 : " + distribution.GetProbability( 200 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 200 ), 0.001 );

      /* DF=2 */      

      PIDebug.Title( "..df=2", true );

      distribution.SetDF( 2 );

      Console.WriteLine( "Probability for x=0.103, df=2 : " + distribution.GetProbability( 0.103 ) );
      Assert.AreEqual( 0.95, (double)distribution.GetProbability( 0.103 ), 0.001 );

      Console.WriteLine( "Probability for x=10.597, df=2 : " + distribution.GetProbability( 10.597 ) );
      Assert.AreEqual( 0.005, (double)distribution.GetProbability( 10.597 ), 0.001 );

      /* DF=40 */

      PIDebug.Title( "..df=40", true );

      distribution.SetDF( 40 );

      Console.WriteLine( "Probability for x=29.051, df=40 : " + distribution.GetProbability( 29.051 ) );
      Assert.AreEqual( 0.9, (double)distribution.GetProbability( 29.051 ), 0.001 );

      /* -- 2) Get X */

      PIDebug.Title( "2) Get X", true );

      /* DF=1 */

      PIDebug.Title( "..df=1" );

      distribution.SetDF( 1 );

      Console.WriteLine( "X for probability=1.0, df=1 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 1.0 ), 0.001 );

      Console.WriteLine( "X for probability=0.975, df=1 : " + distribution.GetXForProbability( 0.975 ) );
      Assert.AreEqual( 0.001, (double)distribution.GetXForProbability( 0.975 ), 0.001 );

      Console.WriteLine( "X for probability=0.1, df=1 : " + distribution.GetXForProbability( 0.1 ) );
      Assert.AreEqual( 2.706, (double)distribution.GetXForProbability( 0.1 ), 0.001 );

      Console.WriteLine( "X for probability=0.025, df=1 : " + distribution.GetXForProbability( 0.025 ) );
      Assert.AreEqual( 5.023, (double)distribution.GetXForProbability( 0.025 ), 0.001 );

      /* DF=2 */

      PIDebug.Title( "..df=2", true );

      distribution.SetDF( 2 );

      Console.WriteLine( "X for probability=0.95, df=2 : " + distribution.GetXForProbability( 0.95 ) );
      Assert.AreEqual( 0.103, (double)distribution.GetXForProbability( 0.95 ), 0.001 );

      Console.WriteLine( "X for probability=0.005, df=2 : " + distribution.GetXForProbability( 0.005 ) );
      Assert.AreEqual( 10.597, (double)distribution.GetXForProbability( 0.005 ), 0.001 );

      /* DF=40 */

      PIDebug.Title( "..df=40", true );

      distribution.SetDF( 40 );

      Console.WriteLine( "X for probability=0.9, df=40 : " + distribution.GetXForProbability( 0.9 ) );
      Assert.AreEqual( 29.051, (double)distribution.GetXForProbability( 0.9 ), 0.001 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, df=1", true );

      distribution.SetDF( 1 );

      Console.WriteLine( "x=0.5 : " + distribution.CalcProbabilityDensity( 0.5 ) );
      Console.WriteLine( "x=0.7 : " + distribution.CalcProbabilityDensity( 0.7 ) );
      Console.WriteLine( "x=2.0 : " + distribution.CalcProbabilityDensity( 2.0 ) );
      Console.WriteLine( "x=7.0 : " + distribution.CalcProbabilityDensity( 7.0 ) );

    }
  }
}
