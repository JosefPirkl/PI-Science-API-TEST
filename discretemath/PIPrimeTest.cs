using Microsoft.VisualStudio.TestTools.UnitTesting;
using pi.science.api;
using System;

namespace pi.science.discretemath.test {

  /// <summary>
  /// Test class for <see cref="pi.science.discretemath.PIPrime"/>.
  /// </summary>

  [TestClass]
  public class PIPrimeTest {

    [TestMethod]
    public void TestMethod() {

      /* Source 6G. */

      PIDebug.TitleBig( "Prime" );

      //Console.WriteLine( 3 % 100 );

      /* -- Simple */

      PIDebug.Title( "Simple method" );

      Console.WriteLine( "1 : " + PIPrime.IsPrime_Simple( 1 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Simple( 1 ) );

      Console.WriteLine( "99 : " + PIPrime.IsPrime_Simple( 99 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Simple( 99 ) );

      Console.WriteLine( "101 : " + PIPrime.IsPrime_Simple( 101 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Simple( 101 ) );

      Console.WriteLine( "221 : " + PIPrime.IsPrime_Simple( 221 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Simple( 221 ) );

      Console.WriteLine( "9973 : " + PIPrime.IsPrime_Simple( 9973 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Simple( 9973 ) );

      Console.WriteLine( "10001261 : " + PIPrime.IsPrime_Simple( 10001261 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Simple( 10001261 ) );

      Console.WriteLine( "9007199254740880 : " + PIPrime.IsPrime_Simple( 9007199254740880 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Simple( 9007199254740880 ) );

      Console.WriteLine( "9007199254740881 : " + PIPrime.IsPrime_Simple( 9007199254740881 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Simple( 9007199254740881 ) );

      /* -- Fermat */

      PIDebug.Title( "Fermat test", true );

      Console.WriteLine( "1 : " + PIPrime.IsPrime_Fermat( 1, 3 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Fermat( 1, 3 ) );

      Console.WriteLine( "99 : " + PIPrime.IsPrime_Fermat( 99, 3 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Fermat( 99, 3 ) );

      Console.WriteLine( "101 : " + PIPrime.IsPrime_Fermat( 101, 3 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Fermat( 101, 3 ) );

      Console.WriteLine( "221 : " + PIPrime.IsPrime_Fermat( 221, 3 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Fermat( 221, 3 ) );

      Console.WriteLine( "9973 : " + PIPrime.IsPrime_Fermat( 9973, 3 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Fermat( 9973, 3 ) );

      Console.WriteLine( "10001261 : " + PIPrime.IsPrime_Fermat( 10001261, 3 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_Fermat( 10001261, 3 ) );

      Console.WriteLine( "9007199254740880 : " + PIPrime.IsPrime_Fermat( 9007199254740880, 3 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_Fermat( 9007199254740880, 3 ) );

     //Console.WriteLine( "9007199254740881 : " + PIPrime.IsPrime_Fermat( 9007199254740881 ) );
      //Assert.AreEqual( true, PIPrime.IsPrime_Fermat( 9007199254740881 ) );
      
      /* -- Miller-Rabin */

      PIDebug.Title( "Miller-Rabin test", true );

      Console.WriteLine( "221 : "  + PIPrime.IsPrime_MillerRabin( 221, 5 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_MillerRabin( 221, 5 ) );

      Console.WriteLine( "5 :" + PIPrime.IsPrime_MillerRabin( 5, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 5, 5 ) );

      Console.WriteLine( "97 : " + PIPrime.IsPrime_MillerRabin( 97, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 97, 5 ) );

      Console.WriteLine( "99: " + PIPrime.IsPrime_MillerRabin( 99, 5 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_MillerRabin( 99, 5 ) );

      Console.WriteLine( "101 : " + PIPrime.IsPrime_MillerRabin( 101, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 101, 5 ) );

      Console.WriteLine( "102 : " + PIPrime.IsPrime_MillerRabin( 102, 5 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_MillerRabin( 102, 5 ) );

      Console.WriteLine( "983 : " + PIPrime.IsPrime_MillerRabin( 983, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 983, 5 ) );

      Console.WriteLine( "985 : " + PIPrime.IsPrime_MillerRabin( 985, 5 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_MillerRabin( 985, 5 ) );

      Console.WriteLine( "9973 : " + PIPrime.IsPrime_MillerRabin( 9973, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 9973, 5 ) );
      
      Console.WriteLine( "10001261 : " + PIPrime.IsPrime_MillerRabin( 10001261, 5 ) );
      Assert.AreEqual( true, PIPrime.IsPrime_MillerRabin( 10001261, 5 ) );

      Console.WriteLine( "9007199254740880 : " + PIPrime.IsPrime_MillerRabin( 9007199254740880, 5 ) );
      Assert.AreEqual( false, PIPrime.IsPrime_MillerRabin( 9007199254740880, 5 ) );

      
      //Console.WriteLine( "900719925474000 : " + PIPrime.IsPrime_MillerRabin( 900719925474000, 5 ) );

      //Console.WriteLine( "9007199254740880 : " + PIPrime.IsPrime_MillerRabin(  9007199254740880, 5 ) );

    }
  }
}
