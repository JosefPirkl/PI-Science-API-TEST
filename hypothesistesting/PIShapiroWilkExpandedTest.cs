using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.hypothesistesting.test {

  /// <summary>
  /// Test class <see cref="pi.science.hypothesistesting.PIShapiroWilkExpanded"/>.
  /// </summary>

  [TestClass]
  public class PIShapiroWilkExpandedTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 9D4/1. */

      PIDebug.TitleBig( "Shapiro-Wilk (expanded) test, 9D4,1" );

      PIVariable var = new PIVariable();
      var.AddValues( new int[] { 65, 61, 63, 86, 70, 55, 74, 35, 72, 68, 45, 58 } );

      PIShapiroWilkExpanded test = new PIShapiroWilkExpanded( var );    

      test.Evaluate();

      Console.WriteLine( "W value = " + test.W );
      Console.WriteLine( "Z value = " + test.Z );
      Console.WriteLine( "p-value = " + test.PValue );
      Console.WriteLine( test.ToString() );

      Assert.AreEqual( 0.9216, test.PValue, 0.001 );      

      /* Source 9D4/2. */

      PIDebug.TitleBig( "Shapiro-Wilk (expanded) test, 9D4,2", true );

      PIVariable var1 = new PIVariable();
      var1.AddValues( new int[] { 12, 27, 18, 23, 72, 27, 27, 53, 3, 45, 53, 125, 50 } );

      PIShapiroWilkExpanded test1 = new PIShapiroWilkExpanded( var1 );    

      test1.Evaluate();

      Console.WriteLine( "W value = " + test1.W );
      Console.WriteLine( "Z value = " + test1.Z );
      Console.WriteLine( "p-value = " + test1.PValue );
      Console.WriteLine( test1.ToString() );

      Assert.AreEqual( 0.0440, test1.PValue, 0.001 );      
      


    }
  }
}
