using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.smoothing.PIMovingAverageSmoothing;

namespace pi.science.smoothing.test {

  /// <summary>
  /// Test class for pi.science.smoothing.PIMedianSmoothing (<see cref="pi.science.smoothing.PIMedianSmoothing"/>).
  /// </summary>

  [TestClass]
  public class PIMedianSmoothingTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * MEDIAN SMOOTHING.
       * 
       * Source 4k.
		   *  
		   */

      PIDebug.TitleBig( "Median smoothing" );

      /* - prepare variable for source data */

      PIVariable var = new PIVariable();
      Assert.IsNotNull( var );

      var.AddValues( new int[] { 37, 45, 39, 48, 47, 57, 52, 49, 56, 59, 62 } );

      /* - calc median smoothing, length = 3 */

      PIMedianSmoothing medianSmoothing = new PIMedianSmoothing( var );
      medianSmoothing.SetWindowLength( 3 );
      //medianSmoothing.setOuterValuesNull( true );
      medianSmoothing.Calc();

      /* - show results */

      Console.WriteLine( medianSmoothing.GetOutputVariable().AsString( 2 ) );

      Assert.AreEqual( 39.0, (double)medianSmoothing.GetOutputVariable().GetValue( 1 ) );
      Assert.AreEqual( 45.0, (double)medianSmoothing.GetOutputVariable().GetValue( 2 ) );
      Assert.AreEqual( 47.0, (double)medianSmoothing.GetOutputVariable().GetValue( 3 ) );
      /* ... */

    }
  }
}
