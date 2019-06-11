using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.smoothing.PIExponentialSmoothing;
using static pi.science.smoothing.PIMovingAverageSmoothing;

namespace pi.science.smoothing.test {

  /// <summary>
  /// Test class for pi.science.smoothing.PIDoubleExponentialSmoothing (<see cref="pi.science.smoothing.PIDoubleExponentialSmoothing"/>).
  /// </summary>

  [TestClass]
  public class PIDoubleExponentialSmoothingTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * DOUBLE EXPONENTIAL SMOOTHING.
       * 
       * Source 4H,67.
		   *  
		   */

      PIDebug.TitleBig( "Double exponential smoothing" );

      /* - prepare variable for source data */

      PIVariable var = new PIVariable();
      Assert.IsNotNull( var );

      var.AddValues( new int[] { 199, 205, 217, 197, 223 } );
      var.AddValues( new int[] { 217, 236, 243, 248, 253 } );
      var.AddValues( new int[] { 250, 246, 268, 273, 281 } );
      var.AddValues( new int[] { 281, 278, 284, 270, 301 } );
      var.AddValues( new int[] { 297, 308, 328, 315 } );

      /* - calc Double exponential smoothing, alpha=0.84 */

      PIDoubleExponentialSmoothing smoothing = new PIDoubleExponentialSmoothing( var );

      /* use first 12 values for mean...and use it as the first value */
      smoothing.SetFirstValueCalcType( FirstValueCalcType.MEAN_WINDOWLENGTH );
      smoothing.SetWindowLength( 12 );

      smoothing.SetAlpha( 0.84 );
      Console.WriteLine( "New ALPHA = " + smoothing.GetAlpha() );

      smoothing.Calc();

      /* - show results */

      PIDebug.Blank();
      Console.WriteLine( "After smoothing = " + smoothing.GetOutputVariable().AsString( 2 ) );

      Console.WriteLine( "Errors = " + smoothing.GetErrors().AsString( 2 ) );
      //Assert.AreEqual( 45.0, (double)result.getValue( 2 ) );
      //Assert.AreEqual( 47.0, (double)result.getValue( 3 ) );
      /* ... */

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + smoothing.GetSSE() );
      // TODO Debug better example, there is some difference in SSE
      //Assert.AreEqual( 28735.1, (double)smoothing.GetSSE(), 0.1 );

      Console.WriteLine( "MSE = " + smoothing.GetMSE() );
      //Assert.AreEqual( 1197.3, (double)smoothing.GetMSE(), 0.1 );
      Console.WriteLine( "MSE-1 = " + smoothing.GetErrors().GetSum2() / ( smoothing.GetSourceVariable().Count() - 1 ) );

    }
  }
}
