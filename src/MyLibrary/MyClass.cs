namespace MyLibrary
{
    public class MyClass : IMyClass
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public bool IsEven(int number)
        {
            return (number % 2) == 0;
        }

        public bool IsItEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}