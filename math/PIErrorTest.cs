using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for pi.science.math.PIError (<see cref="pi.science.math.PIError"/>).
  /// </summary>

  [TestClass]
  public class PIErrorTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 6G. */

      PIDebug.TitleBig( "Error function" );

      Console.WriteLine( "Complementary error x=0.35 = " + PIError.Erfc(0.35) );
      Assert.AreEqual( 0.6206, PIError.Erfc( 0.35 ), 0.001 );

      Console.WriteLine( "Complementary error x=0.72 = " + PIError.Erfc( 0.72 ) );
      Assert.AreEqual( 0.3038, PIError.Erfc( 0.72 ), 0.01 );

      Console.WriteLine( "Complementary error x=-0.5 = " + PIError.Erfc( -0.5 ) );
      Assert.AreEqual( 1.5205, PIError.Erfc( -0.5 ), 0.0001 );

      Console.WriteLine( "Complementary error x=0.0 = " + PIError.Erfc( 0.0 ) );
      Assert.AreEqual( 1.0, PIError.Erfc( 0.0 ), 0.0001 );

      Console.WriteLine( "Complementary error x=1.0 = " + PIError.Erfc( 1.0 ) );
      Assert.AreEqual( 0.1572, PIError.Erfc( 1.0 ), 0.0001 );

    }
  }
}
