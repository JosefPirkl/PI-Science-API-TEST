using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PIFDistribution (<see cref="pi.science.distribution.PIFDistribution"/>).
  /// </summary>

  [TestClass]
  public class PIFDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * F distribution.
		   */

      PIDebug.TitleBig( "F distribution" );

      PIFDistribution distribution = new PIFDistribution();

      /* -- 1) Get probability */

      PIDebug.TitleBig( "Get probability" );

      /* DF1=1, DF2=1 */

      PIDebug.Title( "..df1=1, df2=1" );

      distribution.SetDF1( 1 );
      distribution.SetDF2( 1 );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 1.0, distribution.GetProbability( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=39.86 : " + distribution.GetProbability( 39.86 ) );
      Assert.AreEqual( 0.1, distribution.GetProbability( 39.86 ), 0.001 );

      Console.WriteLine( "Probability for x=161.45 : " + distribution.GetProbability( 161.45 ) );
      Assert.AreEqual( 0.05, distribution.GetProbability( 161.45 ), 0.001 );

      Console.WriteLine( "Probability for x=4052.2 : " + distribution.GetProbability( 4052.2 ) );
      Assert.AreEqual( 0.01, distribution.GetProbability( 4052.2 ), 0.001 );

      Console.WriteLine( "Probability for x=405284 : " + distribution.GetProbability( 405284 ) );
      Assert.AreEqual( 0.001, distribution.GetProbability( 405284 ), 0.001 );

      /* DF1=3, DF2=3 */

      PIDebug.Title( "..df1=3, df2=3", true );

      distribution.SetDF1( 3 );
      distribution.SetDF2( 3 );

      Console.WriteLine( "Probability for x=5.39 : " + distribution.GetProbability( 5.39 ) );
      Assert.AreEqual( 0.1, distribution.GetProbability( 5.39 ), 0.001 );

      Console.WriteLine( "Probability for x=9.28 : " + distribution.GetProbability( 9.28 ) );
      Assert.AreEqual( 0.05, distribution.GetProbability( 9.28 ), 0.001 );

      Console.WriteLine( "Probability for x=15.44 : " + distribution.GetProbability( 15.44 ) );
      Assert.AreEqual( 0.025, distribution.GetProbability( 15.44 ), 0.001 );

      Console.WriteLine( "Probability for x=29.46 : " + distribution.GetProbability( 29.46 ) );
      Assert.AreEqual( 0.01, distribution.GetProbability( 29.46 ), 0.001 );

      Console.WriteLine( "Probability for x=141.11 : " + distribution.GetProbability( 141.11 ) );
      Assert.AreEqual( 0.001, distribution.GetProbability( 141.11 ), 0.001 );

      /* DF1=5, DF2=5 */

      PIDebug.Title( "..df1=5, df2=5", true );

      distribution.SetDF1( 5 );
      distribution.SetDF2( 5 );

      Console.WriteLine( "Probability for x=3.45 : " + distribution.GetProbability( 3.45 ) );
      Assert.AreEqual( 0.1, distribution.GetProbability( 3.45 ), 0.001 );

      Console.WriteLine( "Probability for x=5.05 : " + distribution.GetProbability( 5.05 ) );
      Assert.AreEqual( 0.05, distribution.GetProbability( 5.05 ), 0.001 );

      Console.WriteLine( "Probability for x=7.15 : " + distribution.GetProbability( 7.15 ) );
      Assert.AreEqual( 0.025, distribution.GetProbability( 7.15 ), 0.001 );

      Console.WriteLine( "Probability for x=10.97 : " + distribution.GetProbability( 10.97 ) );
      Assert.AreEqual( 0.01, distribution.GetProbability( 10.97 ), 0.001 );

      Console.WriteLine( "Probability for x=29.75 : " + distribution.GetProbability( 29.75 ) );
      Assert.AreEqual( 0.001, distribution.GetProbability( 29.75 ), 0.001 );

      /* -- 2) Get X for probability */

      PIDebug.Title( "2) Get X for probability", true );

      /* DF1=1, DF2=1 */

      PIDebug.Title( "..df1=1, df2=1" );

      distribution.SetDF1( 1 );
      distribution.SetDF2( 1 );

      Console.WriteLine( "X value for probability for prop=1.0 : " + distribution.GetXForProbability( 1.0 ) );
      Assert.AreEqual( 0.0, distribution.GetXForProbability( 1.0 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.1 : " + distribution.GetXForProbability( 0.1 ) );
      Assert.AreEqual( 39.86, distribution.GetXForProbability( 0.1 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.05 : " + distribution.GetXForProbability( 0.05 ) );
      Assert.AreEqual( 161.45, distribution.GetXForProbability( 0.05 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.01 : " + distribution.GetXForProbability( 0.01 ) );
      Assert.AreEqual( 4052.2, distribution.GetXForProbability( 0.01 ), 0.02 );

      Console.WriteLine( "X value for probability for prop=0.001 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 405284, distribution.GetXForProbability( 0.001 ), 0.1 );

      /* DF1=3, DF2=3 */

      PIDebug.Title( "..df1=3, df2=3", true );

      distribution.SetDF1( 3 );
      distribution.SetDF2( 3 );

      Console.WriteLine( "X value for probability for prop=0.1 : " + distribution.GetXForProbability( 0.1 ) );
      Assert.AreEqual( 5.39, distribution.GetXForProbability( 0.1 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.05 : " + distribution.GetXForProbability( 0.05 ) );
      Assert.AreEqual( 9.28, distribution.GetXForProbability( 0.05 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.025 : " + distribution.GetXForProbability( 0.025 ) );
      Assert.AreEqual( 15.44, distribution.GetXForProbability( 0.025 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.01 : " + distribution.GetXForProbability( 0.01 ) );
      Assert.AreEqual( 29.46, distribution.GetXForProbability( 0.01 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.001 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 141.11, distribution.GetXForProbability( 0.001 ), 0.01 );

      /* DF1=5, DF2=5 */

      PIDebug.Title( "..df1=5, df2=5", true );

      distribution.SetDF1( 5 );
      distribution.SetDF2( 5 );

      Console.WriteLine( "X value for probability for prop=0.1 : " + distribution.GetXForProbability( 0.1 ) );
      Assert.AreEqual( 3.45, distribution.GetXForProbability( 0.1 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.05 : " + distribution.GetXForProbability( 0.05 ) );
      Assert.AreEqual( 5.05, distribution.GetXForProbability( 0.05 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.025 : " + distribution.GetXForProbability( 0.025 ) );
      Assert.AreEqual( 7.15, distribution.GetXForProbability( 0.025 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.01 : " + distribution.GetXForProbability( 0.01 ) );
      Assert.AreEqual( 10.97, distribution.GetXForProbability( 0.01 ), 0.01 );

      Console.WriteLine( "X value for probability for prop=0.001 : " + distribution.GetXForProbability( 0.001 ) );
      Assert.AreEqual( 29.75, distribution.GetXForProbability( 0.001 ), 0.01 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, df1=1, df2=1", true );

      distribution.SetDF1( 1 );
      distribution.SetDF2( 1 );

      Console.WriteLine( "x=0.0 : " + distribution.CalcProbabilityDensity( 0.0 ) );
      Console.WriteLine( "x=0.001 : " + distribution.CalcProbabilityDensity( 0.001 ) );
      Console.WriteLine( "x=0.1 : " + distribution.CalcProbabilityDensity( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.CalcProbabilityDensity( 0.5 ) );
      Console.WriteLine( "x=2.0 : " + distribution.CalcProbabilityDensity( 2.0 ) );
      Console.WriteLine( "x=7.0 : " + distribution.CalcProbabilityDensity( 7.0 ) );
    }

  }

}
