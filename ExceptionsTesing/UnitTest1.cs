using ExceptionsAssignment;

namespace ExceptionsTesing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void given_sad_should_return_sad()
        {
            //analyse
            string expected = "SAD";
            string message = "Im in Sad mood";
            MoodAnalyser analyser = new MoodAnalyser(message);

            //act
           string actual= analyser.analyse_mood();

            //assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}