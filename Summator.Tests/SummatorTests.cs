using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class SummatorTests
    {
      

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {

            long result = Summator.Sum(new long[] { 5, 7 });
            Assert.That(result, Is.EqualTo(12));

        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {

            long result = Summator.Sum(new long[] { 5 });
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {

            long result = Summator.Sum(new long[] { -5, -7 });
            Assert.That(result, Is.EqualTo(-12));
        }
        [Test]
        public void Test_Sum_OneNegativeNumber()
        {

            long result = Summator.Sum(new long[] { -7 });
            Assert.That(result, Is.EqualTo(-7));
        }
        [Test]
        public void Test_Sum_OneNegativeandOnepositiveNumber()
        {

            long result = Summator.Sum(new long[] { -7, 9 });
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {

            long result = Summator.Sum(new long[] { });
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Test_Sum_BigValues()
        {

            long result = Summator.Sum(new long[] { 200000000000, 200000000000, 200000000000 });



            Assert.That(result, Is.EqualTo(600000000000));
        }
        [Test]
        public void Test_Sum_AverageValues()
        {

            int average = Summator.average(new int[] { 5, 7 });



            Assert.That(average, Is.EqualTo(6));
        }
    }
         

}
    

        
    
 

    