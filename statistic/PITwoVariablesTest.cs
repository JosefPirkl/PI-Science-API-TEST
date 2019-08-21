using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.statistic.test {

  /// <summary>
  /// Test class for pi.science.statistic.PITwoVariables (<see cref="PITwoVariables"/>).
  /// </summary>

  [TestClass]
  public class PITwoVariableTest {

    [TestMethod]
    public void TestMethod() {

      /* -- source 2a, 566 */

      PIDebug.Title( "Two variables" );

      /* - prepare X data  */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddValues( new int[] { 2, 3, 3, 3, 4, 4, 5, 5, 5, 6 } );

      /* - prepare Y data  */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new double[] { 28.7, 24.8, 26.0, 30.5, 23.8, 24.6, 23.8, 20.4, 21.6, 22.1 } );

      /* - input data, show R and R2 */

      PITwoVariables twoVariables = new PITwoVariables( X, Y );

      Console.WriteLine( "Correlation coefficient = " + twoVariables.GetR() );
      Console.WriteLine( "Coefficient of determination = " + twoVariables.GetR2() );

      PIDebug.Blank();

      Assert.AreEqual( -0.818, twoVariables.GetR(), 0.001 );
      Assert.AreEqual( 0.670, twoVariables.GetR2(), 0.001 );

      /* ------------------------ covariance, source 2i ---------------------------- */

      PIDebug.Title( "X, Y covariance" );

      /* - prepare X data  */

      PIVariable X1 = new PIVariable();
      Assert.IsNotNull( X1 );

      X1.AddValues( new Double[] { 1.1, 1.7, 2.1, 1.4, 0.2 } );

      /* - prepare Y data  */

      PIVariable Y1 = new PIVariable();
      Assert.IsNotNull( Y1 );

      Y1.AddValues( new double[] { 3.0, 4.2, 4.9, 4.1, 2.5 } );

      /* - X, Y */

      PITwoVariables twoVariables1 = new PITwoVariables( X1, Y1 );

      Console.WriteLine( "Population covariance = " + twoVariables1.GetPopulationCovariance() );
      Console.WriteLine( "Sample covariance = " + twoVariables1.GetSampleCovariance() );

      PIDebug.Blank();

      Assert.AreEqual( 0.532, twoVariables1.GetPopulationCovariance(), 0.001 );
      Assert.AreEqual( 0.665, twoVariables1.GetSampleCovariance(), 0.001 );

      /* -- source 2n */

      PIDebug.Title( "Pearson correlation coefficient" );

      PIVariable varX = new PIVariable();
      PIVariable varY = new PIVariable();
      Assert.IsNotNull( varX );
      Assert.IsNotNull( varY );

      PITwoVariables varXY = new PITwoVariables( varX, varY );
      Assert.IsNotNull( varXY );

      varXY.AddXY( 175, 69 );
      varXY.AddXY( 166, 55 );
      varXY.AddXY( 170, 67 );
      varXY.AddXY( 169, 52 );
      varXY.AddXY( 188, 90 );
      varXY.AddXY( 175, 53 );
      varXY.AddXY( 176, 57 );
      varXY.AddXY( 171, 57 );
      varXY.AddXY( 173, 68 );
      varXY.AddXY( 175, 73 );
      varXY.AddXY( 173, 62 );
      varXY.AddXY( 174, 90 );
      varXY.AddXY( 169, 63 );

      Console.WriteLine( "R = " + varXY.GetR() );
      Console.WriteLine( "Pearson`s correlation coeffiecient = " + varXY.GetPearsonCorrelationCoefficient() );

      Assert.AreEqual( 0.639, varXY.GetPearsonCorrelationCoefficient(), 0.001 );

      Console.WriteLine( "Spearman`s rank correlation coeffiecient = " + varXY.GetSpearmanCorrelationCoefficient() );

      Assert.AreEqual( 0.475, varXY.GetSpearmanCorrelationCoefficient(), 0.001 );

      //Console.Write( string.Format( "{0,3}", "Test") + "x" );

    }
  }
}
