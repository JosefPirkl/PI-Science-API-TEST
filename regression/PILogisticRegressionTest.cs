using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.regression.PIGompertzRegression;
using static pi.science.statistic.PIVariable;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PILogisticRegression (<see cref="pi.science.regression.PILogisticRegression"/>).
  /// </summary>

  [TestClass]
  public class PILogisticRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
		   *  Example - Source 2M, 103.
		   * 
		   *  Values for partial sums are cutted from START.
		   */

      PIDebug.TitleBig( "Logistic regression" );

      /* - prepare X data for regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddMoreValuesRange( 1, 19 );

      /* - prepare Y data for regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new int[] { 233, 241, 250, 266, 283 } );
      Y.AddValues( new int[] { 295, 309, 329, 339, 335 } );
      Y.AddValues( new int[] { 335, 345, 358, 363, 374 } );
      Y.AddValues( new int[] { 387, 399, 412, 424 } );

      /* - create and compute regression */

      PILogisticRegression regression = new PILogisticRegression( X, Y );
      Assert.IsNotNull( regression );

      /* cut partial sums from START */
      regression.SetCutStyleForPartialSum( CutStyleForPartialSum.START );

      regression.Calc();

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)474.527, (double)regression.Get_k(), 0.001 );
      Assert.AreEqual( (double)1.060, (double)regression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.900, (double)regression.Get_B(), 0.001 );

      /* - calc prediction for X = 26 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=26 : " + regression.CalcPredictedY( 26.0 ) );

      Assert.AreEqual( (double)444.124, (double)regression.CalcPredictedY( 26.0 ), 0.001 );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( regression.GetErrors().AsString( 5 ) );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + regression.GetSSE() );
      Console.WriteLine( "ME = " + regression.GetME() );
      Console.WriteLine( "MSE = " + regression.GetMSE() );
      Console.WriteLine( "MAE = " + regression.GetMAE() );
      Console.WriteLine( "MAPE = " + regression.GetMAPE() );
      Console.WriteLine( "MPE = " + regression.GetMPE() );
    }
  }
}
