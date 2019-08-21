using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for <see cref="pi.science.distribution.PIWeibullDistribution"/>.
  /// </summary>

  [TestClass]
  public class PIParetoDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 5S2. */

      PIDebug.TitleBig( "Pareto distribution (alpha=3, xm=1)" );

      PIParetoDistribution distribution = new PIParetoDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X (CDF)" );

      /* alpha=1, xm=2 */
      PIDebug.Title( "..alpha=3; xm=1" );

      distribution.SetAlpha( 3 );
      distribution.SetXM( 1 );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 1.0 ), 0.001 );

      Console.WriteLine( "Probability for x=2.0 : " + distribution.GetCDF( 2.0 ) );
      Assert.AreEqual( 0.8752, distribution.GetProbability( 2.0 ), 0.001 );

      Console.WriteLine( "Probability for x=2.5 : " + distribution.GetCDF( 2.5 ) );
      Assert.AreEqual( 0.9363, distribution.GetProbability( 2.5 ), 0.001 );
            
      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability (InverseCDF)", true );

      /* alpha=1, xm=2 */
      PIDebug.Title( "..alpha=3; xm=1" );

      distribution.SetAlpha( 3 );
      distribution.SetXM( 1 );

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetInverseCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetInverseCDF( 0.0 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.8752 : " + distribution.GetInverseCDF( 0.8752 ) );
      Assert.AreEqual( 2.0, distribution.GetInverseCDF( 0.8752 ), 0.01 );
      
      Console.WriteLine( "X value for probability for prob=0.9363 : " + distribution.GetInverseCDF( 0.9363 ) );
      Assert.AreEqual( 2.5, distribution.GetInverseCDF( 0.9363 ), 0.01 );
     
      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density (PDF)", true );

      /* alpha=1, xm=2 */
      PIDebug.Title( "..alpha=3; xm=1" );

      distribution.SetAlpha( 3 );
      distribution.SetXM( 1 );

      Console.WriteLine( "x=0.1 : " + distribution.GetPDF( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.GetPDF( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=5.0 : " + distribution.GetPDF( 5.0 ) );

    }
  }
}
