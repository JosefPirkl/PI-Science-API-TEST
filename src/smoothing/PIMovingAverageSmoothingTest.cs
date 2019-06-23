using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.smoothing.PIMovingAverageSmoothing;

namespace pi.science.smoothing.test {

  /// <summary>
  /// Test class for pi.science.smoothing.PIMovingAverageSmoothing (<see cref="pi.science.smoothing.PIMovingAverageSmoothing"/>).
  /// </summary>

  [TestClass]
  public class PIMovingAverageSmoothingTest {

    [TestMethod]
    public void TestMethod() {

      /* 
       * SIMPLE CENTERED MOVING AVERAGE
       * 
       * Source 4i.
       *  
       */

      PIDebug.TitleBig( "Moving average - SIMPLE CENTERED (4)" );

      /* - prepare variable for source data */

      PIVariable var = new PIVariable();
      Assert.IsNotNull( var );

      var.AddValues( new int[] { 9, 8, 9, 12, 9, 12, 11 } );

      /* - calc CENTERED moving average, length = 4 */

      PIMovingAverageSmoothing MA = new PIMovingAverageSmoothing( var );
      MA.SetCalculationType( CalculationType.SIMPLE_CENTERED );
      MA.SetWindowLength( 4 );
      MA.Calc();

      /* - show results */

      Console.WriteLine( MA.GetOutputVariable().AsString( 2 ) );

      Assert.AreEqual( 9.5, (double)MA.GetOutputVariable().GetValue( 2 ) );
      Assert.AreEqual( 10.0, (double)MA.GetOutputVariable().GetValue( 3 ) );
      Assert.AreEqual( 10.75, (double)MA.GetOutputVariable().GetValue( 4 ) );

      /* 
       * SIMPLE MOVING AVERAGE.
       * 
       * Source 4P - correction 1.1.4.
       *  
       */

      PIDebug.TitleBig( "Moving average - SIMPLE (3)", true );

      /* - calc SIMPLE moving average, length = 3 */

      PIVariable var1 = new PIVariable();
      Assert.IsNotNull( var1 );

      var1.AddValues( new int[] { 3, 5, 9, 20, 12, 17, 22, 23, 51, 41, 56, 75, 60, 75, 88 } );

      PIMovingAverageSmoothing MA1 = new PIMovingAverageSmoothing( var1 );
      MA1.SetCalculationType( CalculationType.SIMPLE );
      MA1.SetWindowLength( 3 );
      MA1.Calc();

      /* - show results (3) */

      Console.WriteLine( MA1.GetOutputVariable().AsString( 2 ) );

      Console.WriteLine( "MAE = " + MA1.GetMAE() );
      Console.WriteLine( "MSE = " + MA1.GetMSE() );
    
      Assert.AreEqual( 5.67, (double)MA1.GetOutputVariable().GetValue( 3 ), 0.01 );
      Assert.AreEqual( 11.33, (double)MA1.GetOutputVariable().GetValue( 4 ), 0.01 );
      Assert.AreEqual( 13.67, (double)MA1.GetOutputVariable().GetValue( 5 ), 0.01 );      

    }
  }
}
