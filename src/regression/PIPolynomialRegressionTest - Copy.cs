using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PIPolynomialRegression (<see cref="pi.science.regression.PIPolynomialRegression"/>).
  /// </summary>

  [TestClass]
  public class PIPolynomialRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 3b/5 */

      PIDebug.TitleBig( "Polynomial regression" );

      /* change decimal places count in formulas */
      PIConfiguration.REGRESSION_DECIMAL_PLACES = 6;

      /* - prepare X data for regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddMoreValues( 50.0, 3 );
      X.AddMoreValues( 70.0, 3 );
      X.AddMoreValues( 80.0, 3 );
      X.AddMoreValues( 90.0, 3 );
      X.AddMoreValues( 100.0, 3 );

      /* - prepare Y data for regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new Double[] { 3.3, 2.8, 2.9, 2.3, 2.6, 2.1, 2.5, 2.9, 2.4, 3.0, 3.1, 2.8, 3.3, 3.5, 3.0 } );

      /* - create and compute regression */

      PIPolynomialRegression polynomialRegression = new PIPolynomialRegression( X, Y, 2 );
      Assert.IsNotNull( polynomialRegression );

      /* show degree */
      Console.WriteLine( "degree = " + polynomialRegression.Get_degree() );
      PIDebug.Blank();

      /* calculate */
      polynomialRegression.Calc();

      /* - show results */

      Console.WriteLine( polynomialRegression.GetTextFormula() );
      Console.WriteLine( polynomialRegression.GetTextFormulaFilled() );

      PIDebug.Blank();
      Console.WriteLine( polynomialRegression.Get_coefficients().AsString( 3 ) );

      Assert.AreEqual( (double)7.960, (double)polynomialRegression.Get_coefficients().GetValue( 0 ), 0.001 );
      Assert.AreEqual( (double)-0.154, (double)polynomialRegression.Get_coefficients().GetValue( 1 ), 0.001 );
      Assert.AreEqual( (double)0.001, (double)polynomialRegression.Get_coefficients().GetValue( 2 ), 0.001 );

      /* - calc prediction for X = 80 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=80 : " + polynomialRegression.CalcPredictedY( 80.0 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( polynomialRegression.GetErrors().AsString( 5 ) );
    }
  }
}
