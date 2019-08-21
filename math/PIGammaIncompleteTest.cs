using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for <see cref="pi.science.math.PIGammaIncomplete"/>.
  /// </summary>

  [TestClass]
  public class PIGammaIncompleteTest {

    [TestMethod]
    public void TestMethod() {

      PIDebug.TitleBig( "Gamma lower/upper incomplete function" );

      Console.WriteLine( "s=1 x=1 " );
      Console.WriteLine( "Gamma lower incomplete : " + PIGammaIncomplete.CalcLower( 1, 1.0 ) );
      Assert.AreEqual( 0.63212, PIGammaIncomplete.CalcLower( 1, 1.0 ), 0.0001 );
      Console.WriteLine( "Gamma upper incomplete : " + PIGammaIncomplete.CalcUpper( 1, 1.0 ) );
      Assert.AreEqual( 0.3678212, PIGammaIncomplete.CalcUpper( 1, 1.0 ), 0.0001 );

      PIDebug.Blank();

      Console.WriteLine( "s=2 x=5 " );
      Console.WriteLine( "Gamma lower incomplete : " + PIGammaIncomplete.CalcLower( 2, 5.0 ) );
      Assert.AreEqual( 0.9595, PIGammaIncomplete.CalcLower( 2, 5.0 ), 0.0001 );
      Console.WriteLine( "Gamma upper incomplete : " + PIGammaIncomplete.CalcUpper( 2, 5.0 ) );
      Assert.AreEqual( 0.0404, PIGammaIncomplete.CalcUpper( 2, 5.0 ), 0.0001 );

      PIDebug.Blank();

      Console.WriteLine( "s=2 x=5.5 " );
      Console.WriteLine( "Gamma lower incomplete : " + PIGammaIncomplete.CalcLower( 2, 5.5 ) );
      Assert.AreEqual( 0.9734, PIGammaIncomplete.CalcLower( 2, 5.5 ), 0.0001 );
      Console.WriteLine( "Gamma upper incomplete : " + PIGammaIncomplete.CalcUpper( 2, 5.5 ) );
      Assert.AreEqual( 0.0265, PIGammaIncomplete.CalcUpper( 2, 5.5 ), 0.0001 );

      PIDebug.Blank();

      Console.WriteLine( "s=3 x=5 " );
      Console.WriteLine( "Gamma lower incomplete : " + PIGammaIncomplete.CalcLower( 3, 5.0 ) );
      Assert.AreEqual( 1.7506, PIGammaIncomplete.CalcLower( 3, 5.0 ), 0.0001 );
      Console.WriteLine( "Gamma upper incomplete : " + PIGammaIncomplete.CalcUpper( 3, 5.0 ) );
      Assert.AreEqual( 0.2493, PIGammaIncomplete.CalcUpper( 3, 5.0 ), 0.0001 );

      PIDebug.Blank();

      Console.WriteLine( "s=10 x=10 " );
      Console.WriteLine( "Gamma lower incomplete : " + PIGammaIncomplete.CalcLower( 10, 10.0 ) );
      Assert.AreEqual( 196706.4652, PIGammaIncomplete.CalcLower( 10, 10.0 ), 0.0001 );
      Console.WriteLine( "Gamma upper incomplete : " + PIGammaIncomplete.CalcUpper( 10, 10.0 ) );
      Assert.AreEqual( 166173.5347, PIGammaIncomplete.CalcUpper( 10, 10.0 ), 0.0001 );

    }
  }
}
