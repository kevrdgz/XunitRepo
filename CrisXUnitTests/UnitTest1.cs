using System;
using System.Diagnostics;
using Xunit;

namespace CrisXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int val = 2;
            // si los numeros son diferentes =  funciona
            // si los numeros son iguales = falla
            Debug.Assert(val != 2, "Value should not be 2.");
        
        }
    }
}
