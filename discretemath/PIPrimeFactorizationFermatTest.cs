using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.discretemath.test {

  /// <summary>
  /// Test class for <see cref="pi.science.discretemath.PIPrimeFactorizationFermat"/>.
  /// </summary>

  [TestClass]
  public class PIPrimeFactorizationFermatTest {

#pragma warning disable IDE0017 // Simplify object initialization
    readonly PIPrimeFactorizationFermat factorization = new PIPrimeFactorizationFermat();
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

      PIDebug.TitleBig( "Prime factorization - Fermat algorithm" );

      FactorizeItem( 123 );
      FactorizeItem( 501 );
      Assert.AreEqual( 3, factorization.Result.GetValue(0) );
      Assert.AreEqual( 167, factorization.Result.GetValue(1) );
      FactorizeItem( 54869 );      
      FactorizeItem( 45486857 );      
      FactorizeItem( 454868571 );
    }

  }

}
