using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for pi.science.math.PIBeta (<see cref="pi.science.math.PIBeta"/>).
  /// </summary>

  [TestClass]
  public class PIBetaTest {

    [TestMethod]
    public void TestMethod() {

      PIDebug.TitleBig( "Beta function" );

      Console.WriteLine( "Beta x=1, y=1 = " + PIBeta.Calc( 1, 1 ) );
      Assert.AreEqual( 1.0, PIBeta.Calc( 1, 1 ), 0.00001 );

      Console.WriteLine( "Beta x=2, y=2 = " + PIBeta.Calc( 2, 2 ) );
      Assert.AreEqual( 0.16667, PIBeta.Calc( 2, 2 ), 0.00001 );

      Console.WriteLine( "Beta x=3, y=5 = " + PIBeta.Calc( 3, 5 ) );
      Assert.AreEqual( 0.0095238, PIBeta.Calc( 3, 5 ), 0.00001 );

      Console.WriteLine( "Beta x=7, y=8 = " + PIBeta.Calc( 7, 8 ) );
      Assert.AreEqual( 0.000041625, PIBeta.Calc( 7, 8 ), 0.00001 );
    }
  }
}
