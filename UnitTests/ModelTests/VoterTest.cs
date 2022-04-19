using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingSystem.Model;
using VotingSystem.Utils;

namespace UnitTests.ModelTests
{
    [TestClass]
    public class VoterTest
    {
        [TestMethod]
        public void VoterBuilderSuccess()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("jdoe16")
                .WithPassword("Abc$900")
                .WithFirstName("Jane")
                .WithLastName("Doe")
                .WithSerialNumber("A12345678")
                .Build();

            Assert.AreEqual("jdoe16", voter.Username);
            Assert.AreEqual("Abc$900", voter.Password);
            Assert.AreEqual("Jane", voter.FirstName);
            Assert.AreEqual("Doe", voter.LastName);
            Assert.AreEqual("A12345678", voter.SerialNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter w/out first name was allowed")]
        public void VoterBuilderFailureNullUsername()
        {
            Voter voter = new VoterBuilder()
                .WithPassword("abc/900")
                .WithFirstName("Jane")
                .WithLastName("Doe")
                .WithSerialNumber("A12345678")
                .Build();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter w/out first name was allowed")]
        public void VoterBuilderFailureNullPassword()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("jdoe16")
                .WithFirstName("Jane")
                .WithLastName("Doe")
                .WithSerialNumber("A12345678")
                .Build();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter w/out first name was allowed")]
        public void VoterBuilderFailureNullFirst()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("afet001")
                .WithPassword("000zTef!")
                .WithLastName("F")
                .WithSerialNumber("Z98765432")
                .Build();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter w/out last name was allowed")]
        public void VoterBuilderFailureNullLast()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("alex1")
                .WithPassword("xyZ6&r")
                .WithFirstName("Alex")
                .WithSerialNumber("T90000123")
                .Build();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter w/out serial num. was allowed")]
        public void VoterBuilderFailureNullSerial()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("afet001")
                .WithPassword("000zteF!")
                .WithFirstName("Alex")
                .WithLastName("F")
                .Build();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter with invalid first name was allowed")]
        public void VoterBuilderFailureBadFirstName()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("jdoe88")
                .WithPassword("&defG12")
                .WithFirstName("Jane1")
                .WithLastName("Doe")
                .WithSerialNumber("A12345678")
                .Build();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter with invalid first name was allowed")]
        public void VoterBuilderFailureBadLastName()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("aDeerNoADoeOhDear")
                .WithPassword("123#Asdfg")
                .WithFirstName("Jane")
                .WithLastName("Doe?")
                .WithSerialNumber("A12345678")
                .Build();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuilderParameterException), "Voter with invalid serial number was allowed")]
        public void VoterBuilderFailureBadSerial()
        {
            Voter voter = new VoterBuilder()
                .WithUsername("NoThoughts")
                .WithPassword("Head3mpty@")
                .WithFirstName("Jane")
                .WithLastName("Doe")
                .WithSerialNumber("T-1000")
                .Build();

        }
    }
}
