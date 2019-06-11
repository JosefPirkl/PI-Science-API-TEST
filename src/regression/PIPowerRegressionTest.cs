using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PIPowerRegression (<see cref="pi.science.regression.PIPowerRegression"/>).
  /// </summary>

  [TestClass]
  public class PIPowerRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 3f */

      PIDebug.TitleBig( "Power regression" );

      /* change decimal places count in formulas */
      PIConfiguration.REGRESSION_DECIMAL_PLACES = 6;

      /* - prepare X data for regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddValues( new double[] { 17.6, 26.0, 31.9, 38.9, 45.8 } );
      X.AddValues( new double[] { 51.2, 58.1, 64.7, 66.7, 80.8, 82.9 } );

      /* - prepare Y data for regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new double[] { 159.9, 206.9, 236.8, 269.9, 300.6 } );
      Y.AddValues( new double[] { 323.6, 351.7, 377.6, 384.1, 437.2, 444.7 } );

      /* - create and compute regression */

      PIPowerRegression regression = new PIPowerRegression( X, Y );
      Assert.IsNotNull( regression );

      regression.Calc();

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)24.129, (double)regression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.659, (double)regression.Get_B(), 0.001 );

      /* - calc prediction for X = 3.5 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=40 : " + regression.CalcPredictedY( 40.0 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( regression.GetErrors().AsString( 5 ) );

      PIDebug.Blank();
      Console.WriteLine( "R2 = " + regression.GetXYR2() );

    }

  }

}
