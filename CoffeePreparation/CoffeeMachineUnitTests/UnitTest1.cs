using CoffeePreparation;

namespace CoffeeMachineUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Coffee coffee = new Coffee();
           bool  testvar = coffee.PrepareCoffee().ToString() == "CP" ? true : false;
            Assert.True(testvar, "test1 passed");
        }
    }
}