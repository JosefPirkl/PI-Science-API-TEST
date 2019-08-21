using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;
using static pi.science.math.PIMatrix;

namespace pi.science.math.test {

  /// <summary>
  /// Test class for pi.science.math.PIMatrix (<see cref="pi.science.math.PIMatrix"/>).
  /// </summary>

  [TestClass]
  public class PIMatrixTest {

    [TestMethod]
    public void TestMethod() {

      PIDebug.TitleBig( "Matrices" );

      /* -- transpose matrix */

      PIDebug.Title( "Transpose" );

      PIMatrix matrixTransposeA = new PIMatrix( 3, 3 );
      Assert.IsNotNull( matrixTransposeA );
      matrixTransposeA.AddValues( new int[] { 1, 3, 5, 2, 4, 7, 0, 2, 1 } );
      Console.WriteLine( matrixTransposeA.AsString( 0 ) );

      PIDebug.Blank();

      PIMatrix matrixTranspose = matrixTransposeA.Transpose();
      Assert.IsNotNull( matrixTranspose );

      Console.WriteLine( matrixTranspose.AsString( 0 ) );

      Assert.AreEqual( 1.0, (double)matrixTranspose.GetValue( 1, 1 ) );
      Assert.AreEqual( 2.0, (double)matrixTranspose.GetValue( 1, 2 ) );
      Assert.AreEqual( 0.0, (double)matrixTranspose.GetValue( 1, 3 ) );
      Assert.AreEqual( 3.0, (double)matrixTranspose.GetValue( 2, 1 ) );
      Assert.AreEqual( 4.0, (double)matrixTranspose.GetValue( 2, 2 ) );
      Assert.AreEqual( 2.0, (double)matrixTranspose.GetValue( 2, 3 ) );
      Assert.AreEqual( 5.0, (double)matrixTranspose.GetValue( 3, 1 ) );
      Assert.AreEqual( 7.0, (double)matrixTranspose.GetValue( 3, 2 ) );
      Assert.AreEqual( 1.0, (double)matrixTranspose.GetValue( 3, 3 ) );

      /* -- addition - new data */

      PIMatrix matrixAdditionA = new PIMatrix( 2, 3 );
      PIMatrix matrixAdditionB = new PIMatrix( 2, 3 );
      Assert.IsNotNull( matrixAdditionA );
      Assert.IsNotNull( matrixAdditionB );

      matrixAdditionA.AddValues( new double[] { 3.0, 2.0, 0.0, -1.0, 0.0, 4.0 } );
      matrixAdditionB.AddValues( new double[] { 1.0, -5.0, 2.0, 3.0, 4.0, 7.0 } );

      /* addition - show data */

      PIDebug.Title( "MatrixAdditionA", true );
      Console.WriteLine( matrixAdditionA.AsString( 0 ) );

      PIDebug.Title( "MatrixAdditionB", true );
      Console.WriteLine( matrixAdditionB.AsString( 0 ) );

      /* addition */

      PIDebug.Title( "Addition", true );

      PIMatrix matrixAddition = matrixAdditionA.Addition( matrixAdditionB );
      Assert.IsNotNull( matrixAddition );

      //Console.WriteLine( matrixAddition.asString( 0 ) );

      Assert.AreEqual( 4.0, (double)matrixAddition.GetValue( 1, 1 ) );
      Assert.AreEqual( -3.0, (double)matrixAddition.GetValue( 1, 2 ) );
      Assert.AreEqual( 2.0, (double)matrixAddition.GetValue( 1, 3 ) );
      Assert.AreEqual( 2.0, (double)matrixAddition.GetValue( 2, 1 ) );
      Assert.AreEqual( 4.0, (double)matrixAddition.GetValue( 2, 2 ) );
      Assert.AreEqual( 11.0, (double)matrixAddition.GetValue( 2, 3 ) );

      /* subtraction (1a/1) */

      PIDebug.Title( "Subtraction" );

      PIMatrix matrixSubtractionA = new PIMatrix( 2, 3 );
      PIMatrix matrixSubtractionB = new PIMatrix( 2, 3 );
      Assert.IsNotNull( matrixSubtractionA );
      Assert.IsNotNull( matrixSubtractionB );

      matrixSubtractionA.AddValues( new int[] { 8, 4, 2, 6, 1, 5 } );
      matrixSubtractionB.AddValues( new int[] { 3, 10, 4, 5, 6, 1 } );

      PIMatrix matrixSubtraction = matrixSubtractionA.Subtraction( matrixSubtractionB );

      Console.WriteLine( matrixSubtraction.AsString( 0 ) );

      Assert.AreEqual( 5.0, (double)matrixSubtraction.GetValue( 1, 1 ) );
      Assert.AreEqual( -6.0, (double)matrixSubtraction.GetValue( 1, 2 ) );
      Assert.AreEqual( -2.0, (double)matrixSubtraction.GetValue( 1, 3 ) );
      Assert.AreEqual( 1.0, (double)matrixSubtraction.GetValue( 2, 1 ) );
      Assert.AreEqual( -5.0, (double)matrixSubtraction.GetValue( 2, 2 ) );
      Assert.AreEqual( 4.0, (double)matrixSubtraction.GetValue( 2, 3 ) );

      /* multiplication */

      PIDebug.Title( "Multiplication", true );

      PIMatrix matrixMultiplicationA = new PIMatrix( 4, 3 );
      PIMatrix matrixMultiplicationB = new PIMatrix( 3, 2 );
      Assert.IsNotNull( matrixMultiplicationA );
      Assert.IsNotNull( matrixMultiplicationB );

      matrixMultiplicationA.AddValues( new int[] { 2, 0, 1, 3, 4, 2, 1, 1, 0, -1, -2, -3 } );
      matrixMultiplicationB.AddValues( new int[] { 1, -1, 2, 1, 3, -2 } );

      PIMatrix matrixMultiplication = matrixMultiplicationA.Multiply( matrixMultiplicationB );

      Console.WriteLine( matrixMultiplication.AsString( 0 ) );

      Assert.AreEqual( 5.0, (double)matrixMultiplication.GetValue( 1, 1 ) );
      Assert.AreEqual( -4.0, (double)matrixMultiplication.GetValue( 1, 2 ) );
      Assert.AreEqual( 17.0, (double)matrixMultiplication.GetValue( 2, 1 ) );
      Assert.AreEqual( -3.0, (double)matrixMultiplication.GetValue( 2, 2 ) );
      Assert.AreEqual( 3.0, (double)matrixMultiplication.GetValue( 3, 1 ) );
      Assert.AreEqual( 0.0, (double)matrixMultiplication.GetValue( 3, 2 ) );
      Assert.AreEqual( -14.0, (double)matrixMultiplication.GetValue( 4, 1 ) );
      Assert.AreEqual( 5.0, (double)matrixMultiplication.GetValue( 4, 2 ) );

      /* constant multiplication */

      PIDebug.Title( "Constant multiplication", true );

      PIMatrix matrixScalarMultiplicationA = new PIMatrix( 2, 3 );
      Assert.IsNotNull( matrixScalarMultiplicationA );

      matrixScalarMultiplicationA.AddValues( new Double[] { 1.0, -5.0, 2.0, 3.0, 4.0, 7.0 } );

      PIMatrix matrixScalarMultiplication = matrixAdditionB.ConstantOperation( 3, ScalarOperation.MULTIPLICATION );
      Assert.IsNotNull( matrixScalarMultiplication );

      Console.WriteLine( matrixScalarMultiplication.AsString( 0 ) );

      Assert.AreEqual( 3.0, (double)matrixScalarMultiplication.GetValue( 1, 1 ) );
      Assert.AreEqual( -15.0, (double)matrixScalarMultiplication.GetValue( 1, 2 ) );
      Assert.AreEqual( 6.0, (double)matrixScalarMultiplication.GetValue( 1, 3 ) );
      Assert.AreEqual( 9.0, (double)matrixScalarMultiplication.GetValue( 2, 1 ) );
      Assert.AreEqual( 12.0, (double)matrixScalarMultiplication.GetValue( 2, 2 ) );
      Assert.AreEqual( 21.0, (double)matrixScalarMultiplication.GetValue( 2, 3 ) );

      /* inversion */

      PIDebug.Title( "Inversion", true );

      PIMatrix matrixInverseA = new PIMatrix( 2, 2 );
      Assert.IsNotNull( matrixInverseA );

      matrixInverseA.AddValues( new int[] { 1, -2, -3, 8 } );
      Console.WriteLine( matrixInverseA.AsString( 1 ) );

      PIMatrix matrixInverse = matrixInverseA.Inverse();
      Assert.IsNotNull( matrixInverse );

      PIDebug.Blank();
      Console.WriteLine( matrixInverse.AsString( 1 ) );

      Assert.AreEqual( 4.0, (double)matrixInverse.GetValue( 1, 1 ) );
      Assert.AreEqual( 1.0, (double)matrixInverse.GetValue( 1, 2 ) );
      Assert.AreEqual( 1.5, (double)matrixInverse.GetValue( 2, 1 ) );
      Assert.AreEqual( 0.5, (double)matrixInverse.GetValue( 2, 2 ) );

      /* determinant 2x2 (source 1c) */

      PIDebug.Title( "Determinant 1x1", true );

      PIMatrix matrixDeterminant11 = new PIMatrix( 1, 1 );
      Assert.IsNotNull( matrixDeterminant11 );

      matrixDeterminant11.AddValues( new int[] { 10 } );

      double valueDeterminant11 = matrixDeterminant11.Determinant();

      Console.WriteLine( valueDeterminant11 );

      Assert.AreEqual( 10.0, valueDeterminant11 );

      /* determinant 2x2 (source 1c) */

      PIDebug.Title( "Determinant 2x2", true );

      PIMatrix matrixDeterminant22 = new PIMatrix( 2, 2 );
      Assert.IsNotNull( matrixDeterminant22 );

      matrixDeterminant22.AddValues( new int[] { 4, -3, 8, -5 } );

      double valueDeterminant22 = matrixDeterminant22.Determinant();

      Console.WriteLine( valueDeterminant22 );

      Assert.AreEqual( 4.0, valueDeterminant22 );

      /* determinant 3x3 (source 1c) */

      PIDebug.Title( "Determinant 3x3", true );

      PIMatrix matrixDeterminant33 = new PIMatrix( 3, 3 );
      Assert.IsNotNull( matrixDeterminant33 );

      matrixDeterminant33.AddValues( new int[] { 1, 2, 5, 3, 4, 7, 6, 8, 9 } );

      double valueDeterminant33 = matrixDeterminant33.Determinant();

      Console.WriteLine( valueDeterminant33 );

      Assert.AreEqual( 10.0, valueDeterminant33 );

      /* determinant 4x4 (source 1b/5) */

      PIDebug.Title( "Determinant 4x4", true );

      PIMatrix matrixDeterminant44 = new PIMatrix( 4, 4 );
      Assert.IsNotNull( matrixDeterminant44 );

      matrixDeterminant44.AddValues( new int[] { 1, 2, 1, 1, 2, 5, 1, 2, 3, 2, 2, 1, 1, 3, 2, 2 } );

      double valueDeterminant44 = matrixDeterminant44.Determinant();

      Console.WriteLine( valueDeterminant44 );

      Assert.AreEqual( -1.0, valueDeterminant44 );

      /* rank (source 1b/14) */

      PIDebug.Title( "rank", true );

      PIMatrix matrixRank = new PIMatrix( 3, 6 );
      Assert.IsNotNull( matrixRank );

      matrixRank.AddValues( new int[] { 3, 1, -8, 2, 1, 0, 2, -2, -3, -7, 2, 0, 1, -5, 2, -16, 3, 0 } );

      int valueRank = matrixRank.Rank();

      Console.WriteLine( valueRank );

      Assert.AreEqual( (int)2, (int)valueRank );

      /* rank (source 1d) */

      PIDebug.Title( "rank 2", true );

      PIMatrix matrixRank2 = new PIMatrix( 3, 3 );
      Assert.IsNotNull( matrixRank2 );

      matrixRank2.AddValues( new int[] { 1, 2, 1, 0, -1, -2, 1, 3, 3 } );

      int valueRank2 = matrixRank2.Rank();

      Console.WriteLine( valueRank2 );

      Assert.AreEqual( (int)2, (int)valueRank2 );

      /* rank (source 1d) */

      PIDebug.Title( "rank 3", true );

      PIMatrix matrixRank3 = new PIMatrix( 4, 4 );
      Assert.IsNotNull( matrixRank3 );

      matrixRank3.AddValues( new int[] { 7, 2, 5, 1, 1, 3, 5, -7, 4, -5, 1, 0, 2, 8, 10, -9 } );

      int valueRank3 = matrixRank3.Rank();

      Console.WriteLine( valueRank3 );

      Assert.AreEqual( (int)4, (int)valueRank3 );

    }
  }
}
