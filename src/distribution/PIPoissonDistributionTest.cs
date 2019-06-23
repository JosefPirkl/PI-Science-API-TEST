using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.distribution.test {

  /// <summary>
  /// Test class for pi.science.distribution.PIPoissonDistribution (<see cref="pi.science.distribution.PIPoissonDistribution"/>).
  /// </summary>

  [TestClass]
  public class PIPoissonDistributionTest {

    [TestMethod]
    public void TestMethod() {

       PIDebug.TitleBig( "Poisson distribution (1)" );

      PIPoissonDistribution distribution = new PIPoissonDistribution();

      /* -- 1) Get probability */

      PIDebug.Title( "1) Get probability for X" );

      /* lambda=1 */
      PIDebug.Title( "..lambda=1" );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.3679, distribution.GetCDF( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=1.0 : " + distribution.GetCDF( 1.0 ) );
      Assert.AreEqual( 0.7358, distribution.GetCDF( 1.0 ), 0.001 );

      Console.WriteLine( "Probability for x=3.0 : " + distribution.GetCDF( 3.0 ) );
      Assert.AreEqual( 0.981, distribution.GetCDF( 3.0 ), 0.001 );

      Console.WriteLine( "Probability for x=5.0 : " + distribution.GetCDF( 5.0 ) );
      Assert.AreEqual( 0.9994, distribution.GetCDF( 5.0 ), 0.001 );

      /* lambda=3 */
      PIDebug.Title( "..lambda=3", true );

      distribution.SetLambda( 3 );

      Console.WriteLine( "Probability for x=0.0 : " + distribution.GetCDF( 0.0 ) );
      Assert.AreEqual( 0.0498, distribution.GetCDF( 0.0 ), 0.001 );

      Console.WriteLine( "Probability for x=3.0 : " + distribution.GetCDF( 3.0 ) );
      Assert.AreEqual( 0.6472, distribution.GetCDF( 3.0 ), 0.001 );

      /* -- 2) Get T for probability */

      PIDebug.Title( "2) Get X for probability", true );

      /* lambda=1  */
      PIDebug.Title( "..lambda=1" );

      distribution.SetLambda( 1 );

      Console.WriteLine( "X value for probability for prob=0.7358 : " + distribution.GetXForProbability( 0.7358 ) );
      Assert.AreEqual( 1.0, distribution.GetXForProbability( 0.7358 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.9810 : " + distribution.GetXForProbability( 0.9810 ) );
      Assert.AreEqual( 3.0, distribution.GetXForProbability( 0.9810 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.9994 : " + distribution.GetXForProbability( 0.9994 ) );
      Assert.AreEqual( 5.0, distribution.GetXForProbability( 0.9994 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=1 : " + distribution.GetXForProbability( 1 ) );
      //Assert.AreEqual( 5.0, distribution.GetXForProbability( 1 ), 0.001 );

      /* lambda=3 */
      PIDebug.Title( "..lambda=3", true );

      distribution.SetLambda( 3 );

      Console.WriteLine( "X value for probability for prob=0.0498 : " + distribution.GetXForProbability( 0.0498 ) );
      Assert.AreEqual( 0.0, distribution.GetXForProbability( 0.0498 ), 0.001 );

      Console.WriteLine( "X value for probability for prob=0.6472 : " + distribution.GetXForProbability( 0.6472 ) );
      Assert.AreEqual( 3.0, distribution.GetXForProbability( 0.6472 ), 0.001 );

      /* -- 3) Get probability density */

      PIDebug.Title( "3) Get probability density, lambda=1", true );

      distribution.SetLambda( 1 );

      Console.WriteLine( "x=0.1 : " + distribution.GetPDF( 0.1 ) );
      Console.WriteLine( "x=0.5 : " + distribution.GetPDF( 0.5 ) );
      Console.WriteLine( "x=1.0 : " + distribution.GetPDF( 1.0 ) );
      Console.WriteLine( "x=2.0 : " + distribution.GetPDF( 2.0 ) );
      Console.WriteLine( "x=5.0 : " + distribution.GetPDF( 5.0 ) );

    }
  }
}
