using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.regression.PIGompertzRegression;
using static pi.science.statistic.PIVariable;

namespace pi.science.regression.test {

  /// <summary>
  /// Test class for pi.science.regression.PIGompertzRegression (<see cref="pi.science.regression.PIGompertzRegression"/>).
  /// </summary>

  [TestClass]
  public class PIGompertzRegressionTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       *  KUBANOVA example - Source 3i,35. **
       * 
       *  Values for partial sums are cutted from START.
       *  
       *  */

      PIDebug.TitleBig( "KUBANOVA, source 3i,36" );

      /* -- 1) PARTIAL_SUMS method */

      PIDebug.Title( "Regression 1-A (PARTIAL SUMS method)" );

      /* - prepare X data for regression */

      PIVariable X = new PIVariable();
      Assert.IsNotNull( X );

      X.AddMoreValuesRange( 1, 29 );

      /* - prepare Y data for regression */

      PIVariable Y = new PIVariable();
      Assert.IsNotNull( Y );

      Y.AddValues( new int[] { 3, 5, 7, 9, 14 } );
      Y.AddValues( new int[] { 17, 21, 27, 36, 40 } );
      Y.AddValues( new int[] { 47, 54, 65, 71, 78 } );
      Y.AddValues( new int[] { 84, 96, 102, 108, 113 } );
      Y.AddValues( new int[] { 125, 129, 132, 136, 145 } );
      Y.AddValues( new int[] { 146, 148, 149, 151 } );

      /* - create and compute regression */

      PIGompertzRegression regression = new PIGompertzRegression( X, Y );
      Assert.IsNotNull( regression );

      /* cut partial sums from START */
      regression.SetCutStyleForPartialSum( CutStyleForPartialSum.START );

      regression.Calc();

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)188.18, (double)regression.Get_gama(), 0.01 );
      Assert.AreEqual( (double)0.023, (double)regression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.894, (double)regression.Get_B(), 0.001 );

      /* - calc prediction for X = 15 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=15 : " + regression.CalcPredictedY( 55.0 ) );

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

      /* -- 2) PARTLY_AVERAGES method */

      PIDebug.Title( "Regression 1-B (PARTLY AVERAGES method)", true );

      regression.SetCalcMethod( CalcMethod.PARTIAL_AVERAGES );
      regression.Calc();

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

      Assert.AreEqual( (double)232.74, (double)regression.Get_gama(), 0.01 );
      Assert.AreEqual( (double)0.011, (double)regression.Get_A(), 0.001 );
      Assert.AreEqual( (double)0.91, (double)regression.Get_B(), 0.01 );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + regression.GetSSE() );
      Console.WriteLine( "ME = " + regression.GetME() );
      Console.WriteLine( "MSE = " + regression.GetMSE() );
      Console.WriteLine( "MAE = " + regression.GetMAE() );
      Console.WriteLine( "MAPE = " + regression.GetMAPE() );
      Console.WriteLine( "MPE = " + regression.GetMPE() );

      /* -- 3) SELECTED_POINTS method */

      PIDebug.Title( "Regression 1-C (SELECTED POINTS method)", true );

      regression.SetCalcMethod( CalcMethod.SELECTED_POINTS );
      regression.Calc();

      //Assert.AreEqual( (double)224.42, (double)regression.get_gama(), 0.01 );
      //Assert.AreEqual( (double)0.021, (double)regression.get_A(), 0.001 );
      //Assert.AreEqual( (double)0.905, (double)regression.get_B(), 0.01 ); 	

      Console.WriteLine( regression.GetTextFormula() );
      Console.WriteLine( regression.GetTextFormulaFilled() );

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

      /* 
       *  LINDA example - Source 3j. **
       * 
       *  Values for partial sums are cutted from END.
       *  
       *  */

      PIDebug.TitleBig( "LINDA, source 3j", true );

      /* -- 1) PARTIAL_SUMS method */

      PIDebug.Title( "Regression 1-A (PARTIAL SUMS method)" );

      /* - prepare X data for regression */

      PIVariable X1 = new PIVariable();
      Assert.IsNotNull( X1 );

      X1.AddMoreValuesRange( 1, 17 );

      /* - prepare Y data for regression */

      PIVariable Y1 = new PIVariable();
      Assert.IsNotNull( Y1 );

      Y1.AddValues( new int[] { 28, 66, 105, 236, 348 } );
      Y1.AddValues( new int[] { 496, 593, 696, 748, 825 } );
      Y1.AddValues( new int[] { 904, 894, 897, 953, 936 } );
      Y1.AddValues( new int[] { 1002, 951 } );

      /* - create and compute regression */

      PIGompertzRegression regression1 = new PIGompertzRegression( X1, Y1 );
      Assert.IsNotNull( regression1 );

      /* set cutting from end */
      regression1.SetCutStyleForPartialSum( CutStyleForPartialSum.END );

      regression1.Calc();

      Console.WriteLine( regression1.GetTextFormula() );
      Console.WriteLine( regression1.GetTextFormulaFilled() );

      //regression.Assert.AreEqual( (double)1.336, (double)regression.get_A(), 0.001 );
      //Assert.AreEqual( (double)0.00097, (double)regression.get_B(), 0.00001 );

      /* - calc prediction for X = 15 */

      PIDebug.Blank();

      Console.WriteLine( "Prediction for X=15 : " + regression1.CalcPredictedY( 55.0 ) );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( regression1.GetErrors().AsString( 5 ) );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + regression1.GetSSE() );
      Console.WriteLine( "ME = " + regression1.GetME() );
      Console.WriteLine( "MSE = " + regression1.GetMSE() );
      Console.WriteLine( "MAE = " + regression1.GetMAE() );
      Console.WriteLine( "MAPE = " + regression1.GetMAPE() );
      Console.WriteLine( "MPE = " + regression1.GetMPE() );

      /* -- 2) PARTLY_AVERAGES method */

      PIDebug.Title( "Regression 1-B (PARTLY AVERAGES method)", true );

      regression1.SetCalcMethod( CalcMethod.PARTIAL_AVERAGES );
      regression1.Calc();

      Console.WriteLine( regression1.GetTextFormula() );
      Console.WriteLine( regression1.GetTextFormulaFilled() );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + regression1.GetSSE() );
      Console.WriteLine( "ME = " + regression1.GetME() );
      Console.WriteLine( "MSE = " + regression1.GetMSE() );
      Console.WriteLine( "MAE = " + regression1.GetMAE() );
      Console.WriteLine( "MAPE = " + regression1.GetMAPE() );
      Console.WriteLine( "MPE = " + regression1.GetMPE() );

      /* -- 3) SELECTED_POINTS method */

      PIDebug.Title( "Regression 1-C (SELECTED POINTS method)", true );

      regression1.SetCalcMethod( CalcMethod.SELECTED_POINTS );
      regression1.Calc();

      Console.WriteLine( regression1.GetTextFormula() );
      Console.WriteLine( regression1.GetTextFormulaFilled() );

      PIDebug.Blank();
      Console.WriteLine( "Prediction errors:" );
      Console.WriteLine( regression1.GetErrors().AsString( 5 ) );

      PIDebug.Blank();
      Console.WriteLine( "SSE = " + regression1.GetSSE() );
      Console.WriteLine( "ME = " + regression1.GetME() );
      Console.WriteLine( "MSE = " + regression1.GetMSE() );
      Console.WriteLine( "MAE = " + regression1.GetMAE() );
      Console.WriteLine( "MAPE = " + regression1.GetMAPE() );
      Console.WriteLine( "MPE = " + regression1.GetMPE() );

    }
  }
}
