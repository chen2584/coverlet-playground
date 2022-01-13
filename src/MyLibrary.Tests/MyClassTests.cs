using Xunit;

namespace MyLibrary.Tests
{
    public class MyClassTest
    {
        [Fact]
        public void Sum_Of_Two_Values()
        {
            var myClass = new MyClass();
            var result = myClass.Sum(1, 1);
            Assert.Equal(2, result);
        }

        // [Fact]
        // public void Verify_If_It_Is_Even_Number()
        // {
        //     var myClass = new MyClass();
        //     var result = myClass.IsEven(2);
        //     Assert.True(result);
            
        //     // result = myClass.IsEven(1);
        //     // Assert.True(result);
        // }
    }
}
