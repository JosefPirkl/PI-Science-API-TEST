using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.hypothesistesting.test {

  /// <summary>
  /// Test class <see cref="pi.science.hypothesistesting.PIDAgostinoPearson"/>.
  /// </summary>

  [TestClass]
  public class PIDAgostinoPearsonTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 9D4/1. */

      PIDebug.TitleBig( "D`Agostino-Pearson test of normality, 9D7" );

      PIVariable var = new PIVariable();
      var.AddValues( new int[] { 34, 56, 39, 71, 84, 92, 44, 67, 98, 49, 55, 73,
                                 50, 62, 75, 44, 88, 53, 61, 25, 36, 66, 77, 35 } );

      PIDAgostinoPearson test = new PIDAgostinoPearson( var );    

      test.Evaluate();

      Console.WriteLine( "Z value = " + test.Z );
      Console.WriteLine( "p-value = " + test.PValue );
      Console.WriteLine( test.ToString() );

      Assert.AreEqual( 0.6362, test.PValue, 0.001 );            
      
      /* Data source 9D4/2. This test with Shapiro-Wilk (expanded) rejects normality, try it with this test. */

      PIDebug.TitleBig( "D`Agostino-Pearson test of normality, data from 9D4,2", true );

      PIVariable var1 = new PIVariable();
      var1.AddValues( new int[] { 12, 27, 18, 23, 72, 27, 27, 53, 3, 45, 53, 125, 50 } );

      PIDAgostinoPearson test1 = new PIDAgostinoPearson( var1 );

      test1.Evaluate();

      Console.WriteLine( "Z value = " + test1.Z );
      Console.WriteLine( "p-value = " + test1.PValue );
      Console.WriteLine( test1.ToString() );

    }
  }
}
