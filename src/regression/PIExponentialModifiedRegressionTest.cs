using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PIExponetialModifiedRegression 
  /// (<see cref="pi.science.regression.PIExponentialModifiedRegression"/>).
  /// </summary>

  [TestClass]
  public class PIExponentialModifiedRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 3d/19 */

      PIDebug.TitleBig( "Exponential modified regression" );

      /* change decimal places count in formulas */
      PIConfiguration.REGRESSION_DECIMAL_PLACES = 6;

      /* - prepare X data for exponential modified regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddValues( new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } );

      /* - prepare Y data for exponential modified regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new double[] { 57.2, 62.8, 72.2, 81.5, 91.6, 97.1, 99.9, 100.4, 100.6 } );

      /* - create and compute regression */

      PIExponentialModifiedRegression regression = new PIExponentialModifiedRegression( X, Y );
      Assert.IsNotNull( regression );

      regression.Calc();

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)106.941, (double)regression.Get_gama(), 0.001 );
      Assert.AreEqual( (double)-77.322, (double)regression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.732, (double)regression.Get_B(), 0.001 );

      /* - calc prediction for X = 5 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=5 : " + regression.CalcPredictedY( 5.0 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( regression.GetErrors().AsString( 5 ) );

    }

  }

}
