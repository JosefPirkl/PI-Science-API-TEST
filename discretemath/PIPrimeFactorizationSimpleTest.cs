using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.discretemath.test {

  /// <summary>
  /// Test class for <see cref="pi.science.discretemath.PIPrimeFactorizationSimple"/>.
  /// </summary>

  [TestClass]
  public class PIPrimeFactorizationSimpleTest {

#pragma warning disable IDE0017 // Simplify object initialization
    readonly PIPrimeFactorizationSimple factorization = new PIPrimeFactorizationSimple();
#pragma warning restore IDE0017 // Simplify object initialization

    /* Factorization - display item. */
    private void FactorizeItem( long _value ) {
      factorization.Value = _value;
      factorization.Factorize();
      Console.Write( factorization.Value + " => " );
      Console.WriteLine( factorization.ResultAsMultipleString() + " = " + factorization.ResultAsMultipleWithExpString() );
      PIDebug.Blank();
    }

    [TestMethod]
    public void TestMethod() {

      /* Source 6I. */

      PIDebug.TitleBig( "Prime factorization" );

      FactorizeItem( 2 );
      FactorizeItem( 123 );
      FactorizeItem( 500 );
      FactorizeItem( 54868 );      
      FactorizeItem( 45486857 );      
      FactorizeItem( 454868572 );
      Assert.AreEqual( 2, factorization.Result.GetValue(0) );
      Assert.AreEqual( 2, factorization.Result.GetValue(1) );
      Assert.AreEqual( 5743, factorization.Result.GetValue(2) );
      Assert.AreEqual( 19801, factorization.Result.GetValue(3) );

    }

  }

}
