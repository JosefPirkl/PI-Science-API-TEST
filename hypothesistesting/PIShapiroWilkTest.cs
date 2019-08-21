using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.hypothesistesting.test {

  /// <summary>
  /// Test class <see cref="pi.science.hypothesistesting.PIShapiroWilk"/>.
  /// </summary>

  [TestClass]
  public class PIShapiroWilkTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 9D1/1. */

      PIDebug.TitleBig( "Shapiro-Wilk (original) test, 9D1/1" );

      PIVariable var = new PIVariable();
      var.AddValues( new int[] { 65, 61, 63, 86, 70, 55, 74, 35, 72, 68, 45, 58 } );

      PIShapiroWilk test = new PIShapiroWilk( var );    

      test.Evaluate();

      Console.WriteLine( "W value = " + test.W );
      Console.WriteLine( "p-value = " + test.PValue );
      Console.WriteLine( test.ToString() );

      Assert.AreEqual( 0.8736, test.PValue, 0.001 );
      
      /* Source 9D1/2. */

      PIDebug.TitleBig( "Shapiro-Wilk (original) test, 9D1/2", true );

      PIVariable var1 = new PIVariable();
      var1.AddValues( new double[] { 1.2, 1.6, 1.8, 1.9, 1.9, 2.0, 2.2, 2.6, 3.0, 3.5, 4.0, 4.8, 5.6, 6.6, 7.6 } );

      PIShapiroWilk test1 = new PIShapiroWilk( var1 );    

      test1.Evaluate();

      Console.WriteLine( "W value = " + test1.W );
      Console.WriteLine( "p-value = " + test1.PValue );
      Console.WriteLine( test1.ToString() );

      Assert.AreEqual( 0.0418, test1.PValue, 0.001 );
    }
  }
}
