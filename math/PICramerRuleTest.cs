using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for pi.science.math.PICramersRule (<see cref="pi.science.math.PICramersRule"/>).
  /// </summary>

  [TestClass]
  public class PICramersRuleTest {

    [TestMethod]
    public void TestMethod() {
      
      /* Cramers rule (Prachar II/15)
       * 
       * x1 + 2x2 - 3x3 = -9
       * 2x1 - 3x2 - 5x3 = -8
       * x1 + x2 + x3 = 4
       * 
       * */

      PIDebug.TitleBig( "Cramers Rule - (degree=3)" );

      PICramersRule cramersRule = new PICramersRule( 3 );
      Assert.IsNotNull( cramersRule );

      PIDebug.Title( "A" );

      cramersRule.Get_matrixA().AddValues( new int[] { 1, 2, -3, 2, -3, -5, 1, 1, 1 } );
      Console.WriteLine( cramersRule.Get_matrixA().AsString( 0 ) );

      PIDebug.Title( "B", true );

      cramersRule.Get_matrixB().AddValues( new int[] { -9, -8, 4 } );
      Console.WriteLine( cramersRule.Get_matrixB().AsString( 0 ) );

      PIDebug.Blank();

      int i = cramersRule.Calc();

      switch( i ) {
        case -1:
          Console.WriteLine( "Some error." );
          Assert.Fail( "Some error." );
          break;
        case 0:
          Console.WriteLine( "System of linear equitions has no solution." );
          break;
        case 1:
          Console.WriteLine( "Result = " + cramersRule.Get_results().AsString( 0 ) );

          Assert.AreEqual( 2.0, (double)cramersRule.Get_results().GetValue( 0 ) );
          Assert.AreEqual( -1.0, (double)cramersRule.Get_results().GetValue( 1 ) );
          Assert.AreEqual( 3.0, (double)cramersRule.Get_results().GetValue( 2 ) );
          break;             
      }

      /* Cramers rule - A (1c/16a)
		   * 
		   * x + 4y = 37
		   * 2x + 5y = 53
		   * 
		   * */

      PIDebug.TitleBig( "Cramers Rule - A - (degree=2)", true );

      PICramersRule cramersRuleA = new PICramersRule( 2 );
      Assert.IsNotNull( cramersRuleA );

      PIDebug.Title( "A" );

      cramersRuleA.Get_matrixA().AddValues( new int[] { 1, 4, 2, 5 } );
      Console.WriteLine( cramersRuleA.Get_matrixA().AsString( 0 ) );

      PIDebug.Title( "B", true );

      cramersRuleA.Get_matrixB().AddValues( new int[] { 37, 53 } );
      Console.WriteLine( cramersRuleA.Get_matrixB().AsString( 0 ) );

      PIDebug.Blank();

      i = cramersRuleA.Calc();

      switch( i ) {
        case -1:
          Console.WriteLine( "Some error." );
          Assert.Fail( "Some error." );
          break;
        case 0:
          Console.WriteLine( "System of linear equitions has not solution." );
          break;
        case 1:
          Console.WriteLine( "Result = " + cramersRuleA.Get_results().AsString( 0 ) );

          Assert.AreEqual( 9.0, (double)cramersRuleA.Get_results().GetValue( 0 ) );
          Assert.AreEqual( 7.0, (double)cramersRuleA.Get_results().GetValue( 1 ) );
          break;
      }

      /* Cramers rule - B (1c/16b)
		   * 
		   * 3x - 2y = 8
		   * -9x + 6y = 5
		   * 
		   * */

      PIDebug.TitleBig( "Cramers Rule - B - (degree=2)", true );

      PICramersRule cramersRuleB = new PICramersRule( 2 );
      Assert.IsNotNull( cramersRuleB );

      PIDebug.Title( "A" );

      cramersRuleB.Get_matrixA().AddValues( new int[] { 3, -2, -9, 6 } );
      Console.WriteLine( cramersRuleB.Get_matrixA().AsString( 0 ) );

      PIDebug.Title( "B" );

      cramersRuleB.Get_matrixB().AddValues( new int[] { 8, 5 } );
      Console.WriteLine( cramersRuleB.Get_matrixB().AsString( 0 ) );

      PIDebug.Blank();

      i = cramersRuleB.Calc();

      switch( i ) {
        case -1:
          Console.WriteLine( "Some error." );
          Assert.Fail( "Some error." );
          break;
        case 0:
          Console.WriteLine( "System of linear equitions has not solution." );
        break;
        case 1:
          Console.WriteLine( "Result = " + cramersRuleB.Get_results().AsString( 0 ) );
          break;
      }

      Assert.AreEqual( cramersRuleB.Get_results().Count(), 0 );

    }
  }
}
