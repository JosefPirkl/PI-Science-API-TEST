using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for <see cref="pi.science.distribution.PIWeibullDistribution"/>.
  /// </summary>

  [TestClass]
  public class PIWeibullDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 5S2. */

      PIDebug.TitleBig( "Weibull distribution (lambda=1, k=1)" );

      PIWeibullDistribution distribution = new PIWeibullDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X (CDF)" );

      /* lambda=1, k=2 */
      PIDebug.Title( "..lambda=1; k=2" );

      distribution.SetK( 2 );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=0.5 : " + distribution.GetCDF( 0.5 ) );
      Assert.AreEqual( 0.2212, distribution.GetProbability( 0.5 ), 0.001 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0 ) );
      Assert.AreEqual( 0.6321, distribution.GetProbability( 1.0 ), 0.001 );

      Console.WriteLine( "Probability for x=2.0 : " + distribution.GetCDF( 2.0 ) );
      Assert.AreEqual( 0.9817, distribution.GetProbability( 2.0 ), 0.001 );

      /* lambda=2, k=3 */
      PIDebug.Title( "..lambda=2; k=3", true );

      distribution.SetLambda( 2 );
      distribution.SetK( 3 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0) );
      Assert.AreEqual( 0.1175, distribution.GetProbability( 1.0 ), 0.001 );

      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability (InverseCDF)", true );

      /* lambda=1, k=2 */
      PIDebug.Title( "..lambda=1; k=2" );

      distribution.SetLambda( 1 );
      distribution.SetK( 2 );

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetInverseCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetInverseCDF( 0.0 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.2212 : " + distribution.GetInverseCDF( 0.2212 ) );
      Assert.AreEqual( 0.5, distribution.GetInverseCDF( 0.2212 ), 0.001 );
      
      Console.WriteLine( "X value for probability for prob=0.6321 : " + distribution.GetInverseCDF( 0.6321 ) );
      Assert.AreEqual( 1.0, distribution.GetInverseCDF( 0.6321 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.9817 : " + distribution.GetInverseCDF( 0.9817 ) );
      Assert.AreEqual( 2.0, distribution.GetInverseCDF( 0.9817 ), 0.001 );

      /* lambda=2, k=3 */
      PIDebug.Title( "..lambda=2; k=3", true );

      distribution.SetLambda( 2 );
      distribution.SetK( 3 );

      Console.WriteLine( "X value for probability for prob=0.1175 : " + distribution.GetInverseCDF( 0.1175 ) );
      Assert.AreEqual( 1.0, distribution.GetInverseCDF( 0.1175 ), 0.001 );
      
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
