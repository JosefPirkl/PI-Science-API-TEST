using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.smoothing.PIExponentialSmoothing;
using static pi.science.smoothing.PIMovingAverageSmoothing;

namespace pi.science.smoothing.test {

  /// <summary>
  /// Test class for pi.science.smoothing.PISimpleExponentialSmoothing (<see cref="pi.science.smoothing.PISimpleExponentialSmoothing"/>).
  /// </summary>

  [TestClass]
  public class PISimpleExponentialSmoothingTest {

    [TestMethod]
    public void TestMethod() {

      /*
       * SIMPLE EXPONENTIAL SMOOTHING.
       * 
       * Source 4H, 60.
       * 
       */

      PIDebug.TitleBig( "2. - Simple exponential smoothing (Cipra 4h,60) - 1. Part" );

      /* - prepare variable for source data */

      PIVariable var1 = new PIVariable();
      Assert.IsNotNull( var1 );

      var1.AddValues( new double[] { 29.9, 28.9, 29.9, 28.7, 29.6 } );
      var1.AddValues( new double[] { 31.6, 28.0, 29.3, 26.4, 27.9 } );
      var1.AddValues( new double[] { 30.1, 28.9, 29.4, 29.6, 27.5 } );
      var1.AddValues( new double[] { 30.2, 28.3, 29.2, 28.6, 30.7 } );
      var1.AddValues( new double[] { 29.0, 28.1 } );

      /* - calc simple exponential smoothing, alpha=0.78 */

      PISimpleExponentialSmoothing smoothing1 = new PISimpleExponentialSmoothing( var1 );

      /* use first 6 values for mean...and use it as the first value */
      smoothing1.SetFirstValueCalcType( FirstValueCalcType.MEAN_WINDOWLENGTH );
      smoothing1.SetWindowLength( 6 );

      smoothing1.SetAlpha( 0.78 );
      Console.WriteLine( " New ALPHA = " + smoothing1.GetAlpha() );

      smoothing1.Calc();

      /* - show results */

      PIDebug.Blank();
      Console.WriteLine( "After smoothing = " + smoothing1.GetOutputVariable().AsString( 2 ) );
      Assert.AreEqual( 29.80, (double)smoothing1.GetOutputVariable().GetValue( 0 ), 0.01 );
      Assert.AreEqual( 29.6, (double)smoothing1.GetOutputVariable().GetValue( 1 ), 0.01 );
      Assert.AreEqual( 29.67, (double)smoothing1.GetOutputVariable().GetValue( 2 ), 0.01 );

      Console.WriteLine( "Errors = " + smoothing1.GetErrors().AsString( 2 ) );
      /* ... */

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + smoothing1.GetSSE() );
      Assert.AreEqual( 33.43, (double)smoothing1.GetSSE(), 0.1 );

      Console.WriteLine( "MSE = " + smoothing1.GetMSE() );
      Assert.AreEqual( 1.519, (double)smoothing1.GetMSE(), 0.001 );
      Console.WriteLine( "MSE-1 = " + smoothing1.GetErrors().GetSum2() / ( smoothing1.GetSourceVariable().Count() - 1 ) );

      /*
       * SIMPLE EXPONENTIAL SMOOTHING.
       * 
       * Source 4H, 60.
       * 
       */

      PIDebug.TitleBig( "2. - Simple exponential smoothing (Cipra 4h,61) - 2. Part", true );

      /* - calc simple exponential smoothing, alpha=0.9 */

      /* takes mean for first value */
      smoothing1.SetFirstValueCalcType( FirstValueCalcType.MEAN );

      smoothing1.SetAlpha( 0.9 );
      Console.WriteLine( "New ALPHA = " + smoothing1.GetAlpha() );

      smoothing1.Calc();

      /* - show results */

      PIDebug.Blank();
      Console.WriteLine( "After smoothing = " + smoothing1.GetOutputVariable().AsString( 2 ) );
      //Assert.AreEqual(29.80, (double) smoothing1.destVariable.getValue(0), 0.01);
      //Assert.AreEqual(29.6, (double) smoothing1.destVariable.getValue(1), 0.01);
      //Assert.AreEqual(29.67, (double) smoothing1.destVariable.getValue(2), 0.01);

      Console.WriteLine( "Errors = " + smoothing1.GetErrors().AsString( 2 ) );
      /* ... */

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + smoothing1.GetSSE() );
      //Assert.AreEqual(33.43, (double) smoothing1.getSSE(), 0.1);

      Console.WriteLine( "MSE = " + smoothing1.GetMSE() );
      //Assert.AreEqual(1.519, (double) smoothing1.getMSE(), 0.001);
      Console.WriteLine( "MSE-1 = " + smoothing1.GetErrors().GetSum2() / ( smoothing1.GetSourceVariable().Count() - 1 ) );
    }

  }

}
