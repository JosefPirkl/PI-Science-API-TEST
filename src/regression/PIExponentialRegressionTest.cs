using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PIExponetialRegression (<see cref="pi.science.regression.PIExponentialRegression"/>).
  /// </summary>

  [TestClass]
  public class PIExponentialRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 3a/113 */

      PIDebug.TitleBig( "Exponential regression" );

      /* change decimal places count in formulas */
      PIConfiguration.REGRESSION_DECIMAL_PLACES = 6;

      /* - prepare X data for exponential regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddValues( new int[] { 0, 1, 2, 3, 4, 5 } );

      /* - prepare Y data for exponential regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new int[] { 3, 7, 10, 24, 50, 95 } );

      /* - create and compute regression */

      PIExponentialRegression ExponentialRegression = new PIExponentialRegression( X, Y );
      Assert.IsNotNull( ExponentialRegression );

      ExponentialRegression.Calc();

      Console.WriteLine( ExponentialRegression.GetTextFormula() );
      Console.WriteLine( ExponentialRegression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)3.046, (double)ExponentialRegression.Get_A(), 0.001 );
      Assert.AreEqual( (double)1.988, (double)ExponentialRegression.Get_B(), 0.001 );

      /* - calc prediction for X = 3.5 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=3.5 : " + ExponentialRegression.CalcPredictedY( 3.5 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( ExponentialRegression.GetErrors().AsString( 5 ) );

    }
  }
}
