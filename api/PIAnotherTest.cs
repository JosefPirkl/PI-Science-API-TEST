using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using pi.science.statistic;
using System;
using static pi.science.statistic.PIVariable;

namespace pi.science.api {

  /// <summary>
  /// Test class for common tests for pi.science (<see cref="pi.science"/>).
  /// </summary>

  [TestClass]
  public class PIAnotherTest {

    [TestMethod]
    public void TestMethod() {

      /* -- testing versions */

      PIDebug.Title( "Version" );

      Console.WriteLine( PIConfiguration.Version_isStable() );

      /* -- testing getPartialSums() */

      PIDebug.Title( "Partial sums", true );

      PIVariable variable = new PIVariable();

      variable.AddValues( new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } );

      PIVariable[] varArray = variable.GetPartsForPartialSum( 3, CutStyleForPartialSum.START );

      if( varArray != null ) {
        Console.WriteLine( varArray.Length );
        PIDebug.Blank();

        if( varArray.Length >= 1 )
          Console.WriteLine( varArray[ 0 ].AsString( 0 ) );
        if( varArray.Length >= 2 )
          Console.WriteLine( varArray[ 1 ].AsString( 0 ) );
        if( varArray.Length >= 3 )
          Console.WriteLine( varArray[ 2 ].AsString( 0 ) );
      }

      PIDebug.Blank();
      varArray = variable.GetPartsForPartialSum( 3, CutStyleForPartialSum.END );

      if( varArray != null ) {
        if( varArray.Length >= 1 )
          Console.WriteLine( varArray[ 0 ].AsString( 0 ) );
        if( varArray.Length >= 2 )
          Console.WriteLine( varArray[ 1 ].AsString( 0 ) );
        if( varArray.Length >= 3 )
          Console.WriteLine( varArray[ 2 ].AsString( 0 ) );
      }

      /* -- testing order */

      PIDebug.Title( "Order in variable", true );

      PIVariable varA = new PIVariable();

      varA.AddValue( 175 );
      varA.AddValue( 166 );
      varA.AddValue( 170 );
      varA.AddValue( 169 );
      varA.AddValue( 188 );
      varA.AddValue( 175 );
      varA.AddValue( 176 );
      varA.AddValue( 171 );
      varA.AddValue( 173 );
      varA.AddValue( 175 );
      varA.AddValue( 173 );
      varA.AddValue( 174 );
      varA.AddValue( 169 );

      PIVariable uniqueOrderedA = varA.GetUniqueOrdered();

      Console.WriteLine( "1) varA - unique list with frequency and order" );
      PIDebug.Blank();

      for( int i = 0; i < uniqueOrderedA.Count(); i++ ) {
        Console.WriteLine( String.Format( "value = {0:f2} , frequency = {1:d}, order = {2:f2}",
                            uniqueOrderedA.GetValue( i ), uniqueOrderedA.Get( i ).GetFrequency(), uniqueOrderedA.Get( i ).GetOrder() ) );
      }

      PIDebug.Blank();
      Console.WriteLine( "1a) varA - frequency and order" );
      PIDebug.Blank();

      for( int i = 0; i < varA.Count(); i++ ) {
        Console.WriteLine( String.Format( "value = {0:f2} , frequency = {1:d}, order = {2:f2}",
                            varA.GetValue( i ), varA.Get( i ).GetFrequency(), varA.Get( i ).GetOrder() ) );
      }

      PIVariable varB = new PIVariable();

      varB.AddValue( 69 );
      varB.AddValue( 55 );
      varB.AddValue( 67 );
      varB.AddValue( 52 );
      varB.AddValue( 90 );
      varB.AddValue( 53 );
      varB.AddValue( 57 );
      varB.AddValue( 57 );
      varB.AddValue( 68 );
      varB.AddValue( 73 );
      varB.AddValue( 62 );
      varB.AddValue( 90 );
      varB.AddValue( 63 );

      varB.GetUniqueOrdered();

      PIDebug.Blank();
      Console.WriteLine( "2a) varB - frequency and order" );
      PIDebug.Blank();

      for( int i = 0; i < varB.Count(); i++ ) {
        Console.WriteLine( String.Format( "value = {0:f2} , frequency = {1:d}, order = {2:f2}",
                            varB.GetValue( i ), varB.Get( i ).GetFrequency(), varB.Get( i ).GetOrder() ) );
      }

      PIDebug.Blank();
      Console.WriteLine( "-> order`s difference" );
      PIDebug.Blank();

      PITwoVariables varAB = new PITwoVariables( varA, varB );

      Console.WriteLine( "Sum of order`s differences = " + varAB.GetSumOrderDiff2() );

    }
  }
}
