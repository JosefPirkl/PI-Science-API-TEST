using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.math;
using System;

namespace pi.science.probability.test {

  /// <summary>
  /// Test class for <see cref="pi.science.probability.PIProbabilityUtils"/>.
  /// </summary>

  [TestClass]
  public class PIProbabilityUtilsTest {

    [TestMethod]
    public void TestMethod() {

      /* -- Factorial */

      PIDebug.TitleBig( "Factorial" );

      Console.WriteLine( "Factorial(0) = " + PIProbabilityUtils.Factorial( 0 ) );
      Assert.AreEqual( 1, PIProbabilityUtils.Factorial( 0 )  );

      Console.WriteLine( "Factorial(1) = " + PIProbabilityUtils.Factorial( 1 ) );
      Assert.AreEqual( 1, PIProbabilityUtils.Factorial( 1 )  );

      Console.WriteLine( "Factorial(2) = " + PIProbabilityUtils.Factorial( 2 ) );
      Assert.AreEqual( 2, PIProbabilityUtils.Factorial( 2 )  );

      Console.WriteLine( "Factorial(3) = " + PIProbabilityUtils.Factorial( 3 ) );
      Assert.AreEqual( 6, PIProbabilityUtils.Factorial( 3 )  );

      Console.WriteLine( "Factorial(7) = " + PIProbabilityUtils.Factorial( 7 ) );
      Assert.AreEqual( 5040, PIProbabilityUtils.Factorial( 7 )  );

      Console.WriteLine( "Factorial(10) = " + PIProbabilityUtils.Factorial( 10 ) );
      Assert.AreEqual( 3628800, PIProbabilityUtils.Factorial( 10 )  );

      /* -- Combination */

      PIDebug.TitleBig( "Combination", true );

      Console.WriteLine( "C(10,3) = " + PIProbabilityUtils.Combination( 10, 3 ) );
      Assert.AreEqual( 120, PIProbabilityUtils.Combination( 10, 3 ) );

      Console.WriteLine( "C(14,5) = " + PIProbabilityUtils.Combination( 14, 5 ) );
      Assert.AreEqual( 2002, PIProbabilityUtils.Combination( 14, 5 ) );

      Console.WriteLine( "C(7,2) = " + PIProbabilityUtils.Combination( 7, 2 ) );
      Assert.AreEqual( 21, PIProbabilityUtils.Combination( 7, 2 ) );

      Console.WriteLine( "C(52,5) = " + PIProbabilityUtils.Combination( 52, 5 ) );
      Assert.AreEqual( 2598960, PIProbabilityUtils.Combination( 52, 5 ) );

      /* -- Catalan number */
      
      PIDebug.TitleBig( "Catalan number", true );

      Console.WriteLine( "Catalan number(0) = " + PIProbabilityUtils.CatalanNumber( 0 ) );
      Assert.AreEqual( 1, PIProbabilityUtils.CatalanNumber( 0 ) );

      Console.WriteLine( "Catalan number(1) = " + PIProbabilityUtils.CatalanNumber( 1 ) );
      Assert.AreEqual( 1, PIProbabilityUtils.CatalanNumber( 1 ) );

      Console.WriteLine( "Catalan number(2) = " + PIProbabilityUtils.CatalanNumber( 2 ) );
      Assert.AreEqual( 2, PIProbabilityUtils.CatalanNumber( 2 ) );

      Console.WriteLine( "Catalan number(3) = " + PIProbabilityUtils.CatalanNumber( 3 ) );
      Assert.AreEqual( 5, PIProbabilityUtils.CatalanNumber( 3 ) );

      Console.WriteLine( "Catalan number(4) = " + PIProbabilityUtils.CatalanNumber( 4 ) );
      Assert.AreEqual( 14, PIProbabilityUtils.CatalanNumber( 4 ) );

      Console.WriteLine( "Catalan number(5) = " + PIProbabilityUtils.CatalanNumber( 5 ) );
      Assert.AreEqual( 42, PIProbabilityUtils.CatalanNumber( 5 ) );

      Console.WriteLine( "Catalan number(6) = " + PIProbabilityUtils.CatalanNumber( 6 ) );
      Assert.AreEqual( 132, PIProbabilityUtils.CatalanNumber( 6 ) );

      Console.WriteLine( "Catalan number(7) = " + PIProbabilityUtils.CatalanNumber( 7 ) );
      Assert.AreEqual( 429, PIProbabilityUtils.CatalanNumber( 7 ) );

      Console.WriteLine( "Catalan number(15) = " + PIProbabilityUtils.CatalanNumber( 15 ) );
      Assert.AreEqual( 9694845, PIProbabilityUtils.CatalanNumber( 15 ) );

      Console.WriteLine( "Catalan number(25) = " + PIProbabilityUtils.CatalanNumber( 25 ) );
      Assert.AreEqual( (ulong)4861946401452, (ulong)PIProbabilityUtils.CatalanNumber( 25 ) );

      Console.WriteLine( "Catalan number(50) = " + PIProbabilityUtils.CatalanNumber( 50 ) );

      Console.WriteLine( "Catalan number(150) = " + PIProbabilityUtils.CatalanNumber( 150 ) );
     
    }
  }
}
