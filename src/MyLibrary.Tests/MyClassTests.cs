using Xunit;

namespace MyLibrary.Tests
{
    public class MyClassTest
    {
        readonly IMyClass _myClass;
        public MyClassTest()
        {
            _myClass = new MyClass();
        }

        [Fact]
        public void Sum_Of_Two_Values()
        {
            var myClass = new MyClass();
            var result = myClass.Sum(1, 1);
            Assert.Equal(2, result);
        }
    }
}
