using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PILinearRegression (<see cref="pi.science.regression.PILinearRegression"/>).
  /// </summary>

  [TestClass]
  public class PILinearRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 3a/113 */

      PIDebug.TitleBig( "Linear regression" );

      /* change decimal places count in formulas */
      PIConfiguration.REGRESSION_DECIMAL_PLACES = 6;

      /* - prepare X data for linear regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddValues( new Double[] { 0.0, 10.0, 25.0, 33.0, 40.0, 50.0, 60.0, 80.0, 100.00 } );

      /* - prepare Y data for linear regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new Double[] { 1.3329, 1.3440, 1.3612, 1.3693, 1.3761, 1.3881, 1.3970, 1.4142, 1.4291 } );

      /* - create and compute regression */

      PILinearRegression linearRegression = new PILinearRegression( X, Y );
      Assert.IsNotNull( linearRegression );

      linearRegression.Calc();

      Console.WriteLine( linearRegression.GetTextFormula() );
      Console.WriteLine( linearRegression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)1.336, (double)linearRegression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.00097, (double)linearRegression.Get_B(), 0.00001 );

      /* - calc prediction for X = 55 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=55 : " + linearRegression.CalcPredictedY( 55.0 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( linearRegression.GetErrors().AsString( 5 ) );

      /* ------------------------------------- */

      /* -- another example, source 2a, 566 */

      PIDebug.TitleBig( "Linear regression 1", true );

      /* - prepare X data for linear regression */

      PIVariable X1 = new PIVariable();
      Assert.IsNotNull( X1 );

      X1.AddValues( new int[] { 2, 3, 3, 3, 4, 4, 5, 5, 5, 6 } );

      /* - prepare Y data for linear regression */

      PIVariable Y1 = new PIVariable();
      Assert.IsNotNull( Y1 );

      Y1.AddValues( new double[] { 28.7, 24.8, 26.0, 30.5, 23.8, 24.6, 23.8, 20.4, 21.6, 22.1 } );

      /* - create and compute regression */

      PILinearRegression linearRegression1 = new PILinearRegression( X1, Y1 );
      Assert.IsNotNull( linearRegression1 );

      linearRegression1.Calc();

      Console.WriteLine( linearRegression1.GetTextFormula() );
      Console.WriteLine( linearRegression1.GetTextFormulaFilled() );

      /* - show predictions + errors */

      PIDebug.Blank();
      Console.WriteLine( "Predictions:" );
      Console.WriteLine( linearRegression1.GetPredicted().AsString( 5 ) );
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( linearRegression1.GetErrors().AsString( 5 ) );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + linearRegression1.GetSSE() );

      Assert.AreEqual( (double)28.946, (double)linearRegression1.GetSSE(), 0.001 );


      /* ------------------------------------- */

      /* -- another example, source 3e,4 */

      PIDebug.TitleBig( "Linear regression 2", true );

      /* - prepare X data for linear regression */

      PIVariable X2 = new PIVariable();
      Assert.IsNotNull( X2 );

      X2.AddValues( new int[] { 4, 4, 7, 7, 8, 9, 10, 10, 10, 11 } );
      X2.AddValues( new int[] { 11, 12, 12, 12, 12, 13, 13, 13, 13, 14 } );
      X2.AddValues( new int[] { 14, 14, 14, 15, 15, 15, 16, 16, 17, 17 } );
      X2.AddValues( new int[] { 17, 18, 18, 18, 18, 19, 19, 19, 20, 20 } );
      X2.AddValues( new int[] { 20, 20, 20, 22, 23, 24, 24, 24, 24, 25 } );

      /* - prepare Y data for linear regression */

      PIVariable Y2 = new PIVariable();
      Assert.IsNotNull( Y2 );

      Y2.AddValues( new int[] { 2, 10, 4, 22, 16, 10, 18, 26, 34, 17 } );
      Y2.AddValues( new int[] { 28, 14, 20, 24, 28, 26, 34, 34, 46, 26 } );
      Y2.AddValues( new int[] { 36, 60, 80, 20, 26, 54, 32, 40, 32, 40 } );
      Y2.AddValues( new int[] { 50, 42, 56, 76, 84, 36, 46, 68, 32, 48 } );
      Y2.AddValues( new int[] { 52, 56, 64, 66, 54, 70, 92, 93, 120, 85 } );

      /* - create and compute regression */

      PILinearRegression linearRegression2 = new PILinearRegression( X2, Y2 );
      Assert.IsNotNull( linearRegression2 );

      linearRegression2.Calc();

      Console.WriteLine( linearRegression2.GetTextFormula() );
      Console.WriteLine( linearRegression2.GetTextFormulaFilled() );

      /* - show predictions + errors */

      PIDebug.Blank();
      Console.WriteLine( "Predictions:" );
      Console.WriteLine( linearRegression2.GetPredicted().AsString( 5 ) );
      PIDebug.Blank();
      Console.WriteLine( "Prediction errors (residuals):" );
      Console.WriteLine( linearRegression2.GetErrors().AsString( 5 ) );

      PIDebug.Blank();

      Console.WriteLine( "Residuals min. = " + linearRegression2.GetErrors().GetMin() );
      Console.WriteLine( "Residuals max. = " + linearRegression2.GetErrors().GetMax() );

      Assert.AreEqual( (double)-29.069, (double)linearRegression2.GetErrors().GetMin(), 0.001 );
      Assert.AreEqual( (double)43.201, (double)linearRegression2.GetErrors().GetMax(), 0.001 );

      PIDebug.Blank();
      Console.WriteLine( "Errors sum = " + linearRegression2.GetErrors().GetSum() );
      Console.WriteLine( "SSE = " + linearRegression2.GetSSE() );

      PIDebug.Blank();
      Console.WriteLine( "R2 = " + linearRegression2.GetXYR2() );
      Console.WriteLine( "R2-adjusted = " + linearRegression2.GetXYR2Adj() );

      Assert.AreEqual( (double)0.6510, (double)linearRegression2.GetXYR2(), 0.001 );
      Assert.AreEqual( (double)0.6438, (double)linearRegression2.GetXYR2Adj(), 0.001 );

    }
  }
}
