using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.statistic.PIVariable;

namespace pi.science.statistic.test {

  /// <summary>
  /// Test class for pi.science.statistic.PIVariable (<see cref="PIVariable"/>).
  /// </summary>

  [TestClass]
  public class PIVariableTest {
  
    [TestMethod]
    public void TestMethod() {

      /* --------------------------------- */

      PIDebug.TitleBig( "Variable" );

      /* check variable */

      PIVariable var = new PIVariable();
      Assert.IsNotNull( var );
      
      /* clear variable */

      var.Clear();
      System.Console.WriteLine( "Alter clear()" );
      Assert.AreEqual( 0, var.Count() );

      /* add values */

      var.AddValue( (double)10 );
      var.AddValue( (double)20 );
      var.AddValue( (double)30 );

      /* set value */

      PIDebug.Blank();
      PIDebug.Title( "set" );
      var.SetValue( 1, 25.0 );
      Assert.AreEqual( 25.0, (double)var.GetValue( 1 ), 0.01 );

      Console.WriteLine( var.AsString( 0 ) );

      var.SetValue( 1, 20.0 );

      PIDebug.Blank();

      /* median - odd */

      double median = var.GetMedian();
      Console.WriteLine( "median (odd) = " + median );
      Assert.AreEqual( 20.0, (double)median, 0.001 );

      /* check count */

      Console.WriteLine( "count() = " + var.Count() );
      Assert.AreEqual( 3, var.Count() );

      /* check sum */

      Console.WriteLine( "sum() = " + var.GetSum() );
      Assert.AreEqual( 60.0, var.GetSum() );

      /* --------------------------------- */

      PIDebug.Blank();
      PIDebug.TitleBig( "Variable - another" );

      /* add values (source 2a/40) */

      var.Clear();
      var.Set_alwaysRecalc( true );

      var.AddValue( 1.90 );
      var.AddValue( 3.00 );
      var.AddValue( 2.53 );
      var.AddValue( 3.71 );
      var.AddValue( 2.12 );
      var.AddValue( 1.76 );
      var.AddValue( 2.71 );
      var.AddValue( 1.39 );
      var.AddValue( 4.00 );
      var.AddValue( 3.33 );

      Double sampleMean = var.GetSampleMean();
      Console.WriteLine( "sampleMean = " + sampleMean );

      Assert.AreEqual( 2.645, (double)sampleMean, 0.0001 );

      /* min */

      double min = var.GetMin();
      Console.WriteLine( "min = " + min );

      Assert.AreEqual( 1.39, min, 0.001 );

      /* max */

      double max = var.GetMax();
      Console.WriteLine( "max = " + max );

      Assert.AreEqual( 4.00, max, 0.001 );

      /* asstring */

      Console.WriteLine( "Items list" );
      Console.WriteLine( var.AsString( 2 ) );

      /* sorted list */

      PIVariable sorted = var.GetSorted();
      Console.WriteLine( "Sorted items list" );
      Console.WriteLine( sorted.AsString( 2 ) );

      /* median - even (source 2a/45) */

      median = var.GetMedian();
      Console.WriteLine( "median (even) = " + median );
      Assert.AreEqual( 2.62, median, 0.001 );

      /* sample standard deviation */

      double std = var.GetSampleStandardDeviation();
      Console.WriteLine( "sample standard deviation = " + std );
      Assert.AreEqual( 0.8674, std, 0.001 );

      /* Z score (source 2a/78) */

      double ZScore = var.GetZScore( 0 );
      Console.WriteLine( "Z score = " + ZScore );
      Assert.AreEqual( -0.8589, ZScore, 0.001 );

      ZScore = var.GetZScore( 1 );
      Console.WriteLine( "Z score = " + ZScore );
      Assert.AreEqual( 0.4093, ZScore, 0.001 );

      /* --------------------------------- */

      /* -- source 2d/68 */

      PIDebug.Blank();
      PIDebug.Title( "Example with VAR1 and VAR2" );

      PIVariable var1 = new PIVariable();
      PIVariable var2 = new PIVariable();
      Assert.IsNotNull( var1 );
      Assert.IsNotNull( var2 );

      var1.AddMoreValues( 4.0, 3 );
      var1.AddMoreValues( 6.0, 4 );
      var1.AddMoreValues( 7.0, 2 );
      var1.AddMoreValues( 9.0, 4 );
      var1.AddMoreValues( 10.0, 10 );
      var1.AddMoreValues( 11.0, 5 );
      var1.AddMoreValues( 11.5, 2 );
      var1.AddMoreValues( 12.0, 13 );
      var1.AddMoreValues( 13.0, 4 );
      var1.AddMoreValues( 14.0, 2 );
      var1.AddMoreValues( 15.0, 2 );
      var1.AddMoreValues( 16.0, 4 );
      var1.AddMoreValues( 17.0, 6 );
      var1.AddMoreValues( 18.0, 2 );
      var1.AddMoreValues( 19.0, 2 );
      var1.AddMoreValues( 20.0, 6 );
      var1.AddMoreValues( 22.0, 2 );

      Console.WriteLine( "count = " + var1.Count() );
      Assert.AreEqual( 73, var1.Count(), 0.001 );

      Console.WriteLine( "mean = " + var1.GetSampleMean() );
      Assert.AreEqual( 12.79, var1.GetSampleMean(), 0.01 );

      Console.WriteLine( "geometric mean = " + var1.GetGeometricMean() );
      Assert.AreEqual( 11.95, var1.GetGeometricMean(), 0.01 );

      Console.WriteLine( "mode = " + var1.GetMode() );
      Assert.AreEqual( 12.00, var1.GetMode(), 0.01 );

      Console.WriteLine( "median = " + var1.GetMedian() );
      Assert.AreEqual( 12.00, var1.GetMedian(), 0.01 );

      Console.WriteLine( "population variance = " + var1.GetPopulationVariance() );
      Assert.AreEqual( 19.44, var1.GetPopulationVariance(), 0.01 );

      Console.WriteLine( "population standard deviation = " + var1.GetPopulationStandardDeviation() );
      Assert.AreEqual( 4.41, var1.GetPopulationStandardDeviation(), 0.01 );

      Console.WriteLine( "sample variance = " + var1.GetSampleVariance() );
      Assert.AreEqual( 19.71, var1.GetSampleVariance(), 0.01 );

      Console.WriteLine( "sample standard deviation = " + var1.GetSampleStandardDeviation() );
      Assert.AreEqual( 4.44, var1.GetSampleStandardDeviation(), 0.01 );

      Console.WriteLine( "min = " + var1.GetMin() );
      Assert.AreEqual( 4.00, var1.GetMin(), 0.01 );

      Console.WriteLine( "max = " + var1.GetMax() );
      Assert.AreEqual( 22.00, var1.GetMax(), 0.01 );

      Console.WriteLine( "range = " + var1.GetRange() );
      Assert.AreEqual( 18.00, var1.GetRange(), 0.01 );

      Console.WriteLine( "quartile1 = " + var1.GetQuartile1() );
      Assert.AreEqual( 10.00, var1.GetQuartile1(), 0.01 );

      Console.WriteLine( "quartile3 = " + var1.GetQuartile3() );
      Assert.AreEqual( 16.00, var1.GetQuartile3(), 0.01 );

      Console.WriteLine( "interquartile range = " + var1.GetInterquartileRange() );
      Assert.AreEqual( 6.00, var1.GetInterquartileRange(), 0.01 );

      Console.WriteLine( "skewness = " + var1.GetSkewness() );
      Assert.AreEqual( 0.16, var1.GetSkewness(), 0.01 );

      Console.WriteLine( "kurtosis = " + var1.GetKurtosis() );

      /* -- 1.0.6. --------------------------------------------- */

      /* -- LAG -- */

      PIDebug.Blank();
      PIDebug.Title( "LAG -2" );

      PIVariable varLAGSource = new PIVariable();
      varLAGSource.AddMoreValuesRange( 1, 10 );

      Console.WriteLine( "Source = " + varLAGSource.AsString( 0 ) );

      /* -2 */
      PIVariable varLAGMinus2 = new PIVariable();
      varLAGMinus2.MakeLag( varLAGSource, -2, false );

      /* LAG -2 = 3;4;5;6;7;8;9;10;<null>;<null> */
      Console.WriteLine( "LAG -2 = " + varLAGMinus2.AsString( 0 ) );

      Assert.AreEqual( 3.0, (double)varLAGMinus2.GetValue( 0 ), 0.1 );
      Assert.AreEqual( null, varLAGMinus2.GetValue( 8 ) );
      Assert.AreEqual( null, varLAGMinus2.GetValue( 9 ) );

      /* +2 */
      PIVariable varLAGPlus2 = new PIVariable();
      varLAGPlus2.MakeLag( varLAGSource, +2, false );

      /* LAG +2 = <null>;<null>;1;2;3;4;5;6;7;8 */
      Console.WriteLine( "LAG +2 = " + varLAGPlus2.AsString( 0 ) );

      Assert.AreEqual( null, varLAGPlus2.GetValue( 0 ) );
      Assert.AreEqual( null, varLAGPlus2.GetValue( 1 ) );
      Assert.AreEqual( 1.0, (double)varLAGPlus2.GetValue( 2 ), 0.1 );

      /* -- 1.0.9. --------------------------------------------- */

      /* -- standardize -- */

      PIDebug.Blank();
      PIDebug.Title( "Standardize data (with Z-SCORE method)" );

      PIVariable varStandardize = new PIVariable();

      varStandardize.AddValues( new int[] { 10, 20, 25, 17, 13, 16 } );

      Console.WriteLine( varStandardize.AsString( 0 ) );
      varStandardize.Standardize( StandardizeMethod.Z_SCORE );
      Console.WriteLine( varStandardize.AsString( 2 ) );

      PIDebug.Blank();
      PIDebug.Title( "Standardize data (with SCALING 0-1 method)" );

      PIVariable varStandardize1 = new PIVariable();

      varStandardize1.AddValues( new int[] { 10, 20, 25, 17, 13, 16 } );

      Console.WriteLine( varStandardize1.AsString( 0 ) );
      varStandardize1.Standardize( StandardizeMethod.SCALING_0_1 );
      Console.WriteLine( varStandardize1.AsString( 2 ) );

      /* -- 1.2.4 - verifing against Kubanova`s (source 3A,42) skewness - if the result is same as in the book */

      PIDebug.Title( "Verifing Kubanova`s skewness", true );

      PIVariable varSkewness = new PIVariable();

      varSkewness.AddMoreValues( 1, 21 );
      varSkewness.AddMoreValues( 2, 43 );
      varSkewness.AddMoreValues( 3, 37 );
      varSkewness.AddMoreValues( 4, 9 );
      varSkewness.AddMoreValues( 5, 2 );

      Console.WriteLine( "mean = " + varSkewness.GetSampleMean() );
      Assert.AreEqual( 2.357, (double)varSkewness.GetSampleMean(), 0.001 );

      Console.WriteLine( "population variance = " + varSkewness.GetPopulationVariance() );
      Assert.AreEqual( 0.872, (double)varSkewness.GetPopulationVariance(), 0.001 );

      Console.WriteLine( "population sd = " + varSkewness.GetPopulationStandardDeviation() );
      Assert.AreEqual( 0.934, (double)varSkewness.GetPopulationStandardDeviation(), 0.001 );

      Console.WriteLine( "mode = " + varSkewness.GetMode() );
      Assert.AreEqual( 2.0, (double)varSkewness.GetMode(), 0.001 );

      Console.WriteLine( "median = " + varSkewness.GetMedian() );
      Assert.AreEqual( 2.0, (double)varSkewness.GetMedian(), 0.001 );

      Console.WriteLine( "skewness = " + varSkewness.GetSkewness() );
      Assert.AreEqual( 0.353, (double)varSkewness.GetSkewness(), 0.001 );

      Console.WriteLine( "kurtosis = " + varSkewness.GetKurtosis() );
      Assert.AreEqual( -0.168, (double)varSkewness.GetKurtosis(), 0.001 );

      Console.WriteLine( "range = " + varSkewness.GetRange() );
      Assert.AreEqual( 4.0, (double)varSkewness.GetRange(), 0.001 );
    }

  }
}
