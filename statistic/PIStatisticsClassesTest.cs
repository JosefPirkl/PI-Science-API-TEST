using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using static pi.science.statistic.PIStatisticsClasses;

namespace pi.science.statistic.test {

  /// <summary>
  /// Test class for pi.science.statistic.PIStatisticsClasses (<see cref="PIStatisticsClasses"/>).
  /// </summary>

  [TestClass]
  public class PIStatisticsClassesTest {

    [TestMethod]
    public void TestMethod() {
      
      /* -- prepare input variable */

      PIVariable var1 = new PIVariable();

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

      /* -- prepare classes */

      PIDebug.Title( "Statistics classes for variable" );

      PIStatisticsClasses statisticsClasses = new PIStatisticsClasses( var1 );
      Assert.IsNotNull( statisticsClasses );

      statisticsClasses.GenerateClasses( GeneratingMethod.FREEDMAN_DIACONISRULE );
      Assert.AreNotEqual( 0, statisticsClasses.Get_classes().Count );

      statisticsClasses.AsString();
    }
  }
}
