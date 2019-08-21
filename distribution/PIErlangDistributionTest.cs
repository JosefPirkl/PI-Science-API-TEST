using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for <see cref="pi.science.distribution.PIErlangDistribution"/>.
  /// </summary>

  [TestClass]
  public class PIErlangDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 5R4. */

      PIDebug.TitleBig( "Erlang distribution (lambda=1, k=1)" );

      PIErlangDistribution distribution = new PIErlangDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X (CDF)" );

      /* lambda=1, k=1 */
      PIDebug.Title( "..lambda=1; k=1" );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=0.1111 : " + distribution.GetCDF( 0.1111 ) );
      Assert.AreEqual( 0.1053, distribution.GetProbability( 0.1111 ), 0.001 );

      Console.WriteLine( "Probability for x=0.25 : " + distribution.GetCDF( 0.25 ) );
      Assert.AreEqual( 0.2213, distribution.GetProbability( 0.25 ), 0.001 );

      Console.WriteLine( "Probability for x=8 : " + distribution.GetCDF( 8 ) );
      Assert.AreEqual( 0.9998, distribution.GetProbability( 8 ), 0.001 );

      /* lambda=1, k=1 */
      PIDebug.Title( "..lambda=2; k=3", true );

      distribution.SetLambda( 2 );
      distribution.SetK( 3 );

      Console.WriteLine( "Probability for x=0.1111 : " + distribution.GetCDF( 0.1111 ) );
      Assert.AreEqual( 0.0015, distribution.GetProbability( 0.1111 ), 0.001 );

      Console.WriteLine( "Probability for x=0.25 : " + distribution.GetCDF( 0.25 ) );
      Assert.AreEqual( 0.0144, distribution.GetProbability( 0.25 ), 0.001 );

      Console.WriteLine( "Probability for x=8 : " + distribution.GetCDF( 8 ) );
      Assert.AreEqual( 1.0, distribution.GetProbability( 8 ), 0.001 );


      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability (InverseCDF)", true );

      PIDebug.Title( "..lambda=1, k=1" );

      distribution.SetLambda( 1 );
      distribution.SetK( 1 );

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetInverseCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetInverseCDF( 0.0 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.1053 : " + distribution.GetInverseCDF( 0.1053 ) );
      Assert.AreEqual( 0.1111, distribution.GetInverseCDF( 0.1053 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.2213 : " + distribution.GetInverseCDF( 0.2213 ) );
      Assert.AreEqual( 0.25, distribution.GetInverseCDF( 0.2213 ), 0.001 );

      PIDebug.Title( "..lambda=2; k=3", true );

      distribution.SetLambda( 2 );
      distribution.SetK( 3 );

      Console.WriteLine( "X value for probability for prob=0.0015 : " + distribution.GetInverseCDF( 0.0015 ) );
      Assert.AreEqual( 0.1111, distribution.GetInverseCDF( 0.0015 ), 0.01 );

      Console.WriteLine( "X value for probability for prob=0.0144 : " + distribution.GetInverseCDF( 0.0144 ) );
      Assert.AreEqual( 0.25, distribution.GetInverseCDF( 0.0144 ), 0.01 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density (PDF)", true );

      PIDebug.Title( "..lambda=1, k=1" );

      distribution.SetLambda( 1 );
      distribution.SetK( 1 );

      Console.WriteLine( "x=0.1 : " + distribution.GetPDF( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.GetPDF( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=5.0 : " + distribution.GetPDF( 5.0 ) );

    }
  }
}
