using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for <see cref="pi.science.distribution.PIRayleighDistribution"/>.
  /// </summary>

  [TestClass]
  public class PIRayleighDistributionTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 5S2. */

      PIDebug.TitleBig( "Rayleigh distribution" );

      PIRayleighDistribution distribution = new PIRayleighDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X (CDF)" );

      /* sigma=1 */
      PIDebug.Title( "..sigma=1" );    

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetProbability( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0 ) );
      Assert.AreEqual( 0.3933, distribution.GetProbability( 1.0 ), 0.001 );

      Console.WriteLine( "Probability for x=2.0 : " + distribution.GetCDF( 2.0 ) );
      Assert.AreEqual( 0.8646, distribution.GetProbability( 2.0 ), 0.001 );

      Console.WriteLine( "Probability for x=2.5 : " + distribution.GetCDF( 2.5 ) );
      Assert.AreEqual( 0.9560, distribution.GetProbability( 2.5 ), 0.001 );

      /* sigma=3 */
      PIDebug.Title( "..sigma=3", true );

      distribution.SetSigma( 3 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0 ) );
      Assert.AreEqual( 0.0540, distribution.GetProbability( 1.0 ), 0.001 );

      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability (InverseCDF)", true );

      /* sigma=1 */
      PIDebug.Title( "..sigma=1" );

      distribution.SetSigma( 1 );  

      Console.WriteLine( "X value for probability for prob=0.0 : " + distribution.GetInverseCDF( 0.0 ) );
      Assert.AreEqual( 0.0, distribution.GetInverseCDF( 0.0 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.3933 : " + distribution.GetInverseCDF( 0.3933 ) );
      Assert.AreEqual( 1.0, distribution.GetInverseCDF( 0.3933 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.8646 : " + distribution.GetInverseCDF( 0.8646 ) );
      Assert.AreEqual( 2.0, distribution.GetInverseCDF( 0.8646 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.9560 : " + distribution.GetInverseCDF( 0.9560 ) );
      Assert.AreEqual( 2.5, distribution.GetInverseCDF( 0.9560 ), 0.001 );

      /* sigma=3 */
      PIDebug.Title( "..sigma=3", true );

      distribution.SetSigma( 3 );   

      Console.WriteLine( "X value for probability for prob=0.0540 : " + distribution.GetInverseCDF( 0.0540 ) );
      Assert.AreEqual( 1.0, distribution.GetInverseCDF( 0.0540 ), 0.001 );
      
      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density (PDF)", true );

      PIDebug.Title( "..sigma=1" );

      distribution.SetSigma( 1 );      

      Console.WriteLine( "x=0.1 : " + distribution.GetPDF( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.GetPDF( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=5.0 : " + distribution.GetPDF( 5.0 ) );

    }
  }
}
