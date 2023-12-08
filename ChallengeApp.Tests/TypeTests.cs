using ChalengeApp;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestInt()
        {
            // arrange
            var number1 = 2;
            var number2 = 2;

            // act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestFloat()
        {
            // arrange
            var number1 = 1.123456;
            var number2 = 1.123456;

            // act

            //assert
            Assert.AreEqual(number1, number2);
        }
        
        [Test]
        public void TestString()
        {
            // arrange
            var name1 = "Ola";
            var name2 = "Ola";

            // act

            //assert
            Assert.AreEqual(name1, name2);
        }
        
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Ola", "Jaśmin", 41);
            var employee2 = GetEmployee("Ola", "Jaśmin", 41);
            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);

        }
        
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
    
}