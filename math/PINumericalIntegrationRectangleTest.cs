using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for <see cref="pi.science.math.PINumericalIntegrationRectangle"/>.
  /// </summary>

  [TestClass]
  public class PINumericalIntegrationRectangleTest {

    [TestMethod]
    public void TestMethod() {

      PIDebug.TitleBig( "Numeric integration - Rectangle method" );

      PIDebug.TitleBig( "Sin(x)^2 from 0..PI" );

      #pragma warning disable IDE0017 // Simplify object initialization
      PINumericalIntegrationRectangle integration = new PINumericalIntegrationRectangle( 0, Math.PI );
      #pragma warning restore IDE0017 // Simplify object initialization

      integration.Expression = (x) => { return Math.Pow( Math.Sin( x ), 2 ); };  
      integration.SetStepsCount( 100 );

      double value = integration.Calc();
      Assert.AreEqual( 1.5707, value, 0.0001 );
      Console.WriteLine( value );
     
      /* ----------------------- */

      /* Source: 6J6 */

      PIDebug.TitleBig( "Sqrt(x^2 + 1 ) from 0..1", true );

      integration.Expression = (x) => { return Math.Sqrt( x*x + 1 ); };  

      integration.A = 0;
      integration.B = 1;
      integration.Step = 0.125;

      value = integration.Calc();
      Assert.AreEqual( 1.1473, value, 0.0001 );
      Console.WriteLine( value );

      PIDebug.Blank();
      Console.WriteLine( "X starting interval positions: " + integration.VarX.AsString( 3 ) );
      Console.WriteLine( "Y values: " + integration.VarY.AsString( 3 ) );
      Console.WriteLine( "Y values cumulative: " + integration.VarYCumulative.AsString( 3 ) );

    }
  }
}
