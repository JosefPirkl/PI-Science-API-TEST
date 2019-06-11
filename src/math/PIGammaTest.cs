using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for pi.science.math.PIGamma (<see cref="pi.science.math.PIGamma"/>).
  /// </summary>

  [TestClass]
  public class PIGammaTest {

    [TestMethod]
    public void TestMethod() {

      PIDebug.TitleBig( "Gamma function" );

      Console.WriteLine( "Gamma x=0.3 => " + PIGamma.Gamma_Lanczos( 0.3 ) );
      Assert.AreEqual( 2.9915, (double)PIGamma.Gamma_Lanczos( 0.3 ), 0.0001 );

      Console.WriteLine( "Gamma x=1.0 => " + PIGamma.Gamma_Lanczos( 1.0 ) );
      Assert.AreEqual( 1.0, (double)PIGamma.Gamma_Lanczos( 1.0 ), 0.0001 );

      Console.WriteLine( "Gamma x=2.23 => " + PIGamma.Gamma_Lanczos( 2.23 ) );
      Assert.AreEqual( 1.1202, (double)PIGamma.Gamma_Lanczos( 2.23 ), 0.0001 );

      Console.WriteLine( "Gamma x=24.0 => " + PIGamma.Gamma_Lanczos( 24.0 ) );
      Assert.AreEqual( 2.585201673888503E22, (double)PIGamma.Gamma_Lanczos( 24.0 ), 0.0001 );

      Console.WriteLine( "Gamma x=25.5 => " + PIGamma.Gamma_Lanczos( 25.5 ) );
      Assert.AreEqual( 3.086770540528693E24, (double)PIGamma.Gamma_Lanczos( 25.5 ), 0.0001 );

    }
  }
}
