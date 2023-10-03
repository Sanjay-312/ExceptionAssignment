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

        [TestMethod]
        public void given_null_should_return_happy()
        {
            //analyse
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);

            //act
            string actual = analyser.analyse_mood();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void given_null_should_return_null_exception()
        {
            try
            {
                //analyse
                string expected = "HAPPY";
                string message = null;
                MoodAnalyser analyser = new MoodAnalyser(message);

                //act
                string actual = analyser.analyse_mood();

                

            }
            catch(Exception ex)
            {
                //assert
                Assert.AreEqual("Invalid mood", ex.Message);

            }
            

        }
    }
}