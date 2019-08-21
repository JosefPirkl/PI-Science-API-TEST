using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.hypothesistesting.test {

  /// <summary>
  /// Test class <see cref="pi.science.hypothesistesting.PIJarqueBera"/>.
  /// </summary>

  [TestClass]
  public class PIJarqueBeraTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 9D8. */

      PIDebug.TitleBig( "Jarque-Bera test of normality, 9D8" );

      PIVariable var = new PIVariable();
      var.AddValues( new int[] { 56, 58, 60, 64, 54, 52, 50, 40, 57, 53,
                                 65, 50, 53, 52, 66, 45, 55, 54, 65, 56, 
                                 55, 57, 48, 63, 51, 55, 44, 58, 54, 60 } );
      //var.SaveToFile( @"c:\\tmp\var.txt" );

      PIJarqueBera test = new PIJarqueBera( var );    

      test.Evaluate();

      Console.WriteLine( "Z value = " + test.Z );
      Console.WriteLine( "p-value = " + test.PValue );
      Console.WriteLine( test.ToString() );

      Assert.AreEqual( 0.2487, test.Z, 0.001 );                       
            
    }
  }
}
