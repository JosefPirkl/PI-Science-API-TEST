using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PINormalDistribution (<see cref="pi.science.distribution.PINormalDistribution"/>).
  /// </summary>

  [TestClass]
  public class PINormalDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * Normal distribution.
       */

      PIDebug.TitleBig( "Normal distribution (0,1)" );

      PINormalDistribution distribution = new PINormalDistribution();

      /* -- get probability from Z-score */

      Console.WriteLine( "Probability for x=0 : " + distribution.GetProbability( 0.0 ) );
      Assert.AreEqual( 0.5, (double)distribution.GetProbability( 0.0 ) );
      Console.WriteLine( "Probability for x=-1 : " + distribution.GetProbability( -1.0 ) );
      Assert.AreEqual( 0.1586, (double)distribution.GetProbability( -1.0 ), 0.0001 );
      Console.WriteLine( "Probability for x=1 : " + distribution.GetProbability( 1.0 ) );
      Assert.AreEqual( 0.8413, (double)distribution.GetProbability( 1.0 ), 0.0001 );
      Console.WriteLine( "Probability for x=-5 : " + distribution.GetProbability( -5.0 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetProbability( -5.0 ), 0.0001 );
      Console.WriteLine( "Probability for x=5 : " + distribution.GetProbability( 5.0 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetProbability( 5.0 ), 0.0001 );

      //PIDebug.blank();

      //Console.WriteLine( "Probability for Z=0 : " + distribution.getPropTest( 0.0 ) );
      //Console.WriteLine( "Probability for Z=-1 : " + distribution.getPropTest( -1.0 ) );
      //Console.WriteLine( "Probability for Z=1 : " + distribution.getPropTest( 1.0 ) );

      PIDebug.Blank();

      /* -- get Z-score from probability */
      /*Console.WriteLine( "Z for probability=0.1 : " + distribution.GetXForProbability1( 0.1 ) );
      Console.WriteLine( "Z for probability=0.5 : " + distribution.GetXForProbability1( 0.5 ) );
      Console.WriteLine( "Z for probability=0.6 : " + distribution.GetXForProbability1( 0.6 ) );
      Console.WriteLine( "Z for probability=0.1 : " + distribution.GetXForProbability( 0.1 ) );
      Console.WriteLine( "Z for probability=0.5 : " + distribution.GetXForProbability( 0.5 ) );
      Console.WriteLine( "Z for probability=0.6 : " + distribution.GetXForProbability( 0.6 ) );*/


      Console.WriteLine( "x for probability=0.5 : " + distribution.GetXForProbability( 0.5 ) );
      Assert.AreEqual( 0.0, (double)distribution.GetXForProbability( 0.5 ), 0.001 );
      Console.WriteLine( "x for probability=0.15 : " + distribution.GetXForProbability( 0.1586 ) );
      Assert.AreEqual( -1.0, (double)distribution.GetXForProbability( 0.1586 ), 0.01 );
      Console.WriteLine( "x for probability=0.8413 : " + distribution.GetXForProbability( 0.8413 ) );
      Assert.AreEqual( 1.0, (double)distribution.GetXForProbability( 0.8413 ), 0.01 );
      Console.WriteLine( "x for probability=0.0001 : " + distribution.GetXForProbability( 0.0001 ) );
      Assert.AreEqual( -3.71, (double)distribution.GetXForProbability( 0.0001 ), 0.01 );
      Console.WriteLine( "x for probability=0.9999 : " + distribution.GetXForProbability( 0.9999 ) );
      Assert.AreEqual( 3.71, (double)distribution.GetXForProbability( 0.9999 ), 0.01 );
      Console.WriteLine( "x for probability=0.0 : " + distribution.GetXForProbability( 0.0 ) );
      Console.WriteLine( "x for probability=1.0 : " + distribution.GetXForProbability( 1.0 ) );

      PIDebug.Blank();

      /* -- compute curve value in point X */

      Console.WriteLine( "Probability density, x=-3 = " + distribution.CalcProbabilityDensity( -3 ) );
      Console.WriteLine( "Probability density, x=0 = " + distribution.CalcProbabilityDensity( 0 ) );
      Console.WriteLine( "Probability density, x=3 = " + distribution.CalcProbabilityDensity( 3 ) );

    }
  }
}
