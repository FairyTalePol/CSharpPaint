using FinalPaint.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTests
{
    public class ValidatorTests
    {
        [TestCase("egorusdnepr@gmail.com", true)]
        [TestCase("andreyzaycev12041961@gmail.com", true)]
        [TestCase("3266880@gmail.com", true)]
        [TestCase("Skochmen@gmail.comiii", false)]
        [TestCase("Step.nst@gmail.com", true)]
        [TestCase("brovko.sasha2002@gmail.com", true)]
        [TestCase("mashayakovenk...o7@gmail.com", false)]
        [TestCase("murashko.konst.andr@gmail.com", true)]
        [TestCase(".murashko.konst.andr@gmail.com", false)]
        [TestCase("murashko.konst.andr.@gmail.com", false)]
        [TestCase("murashko.kons$#t.andr@gmail.com", false)]
        [TestCase("aloe2152@gmail.com",true)]

        public void EmailCheckTests_CheckIfEmailIsValid(string actualEmail, bool expected)
        {
            bool actual = Validator.CheckEmail(actualEmail);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void EmailCheckTests_ShouldReturnArgumentNullException(string actualEmail)
        {
            Assert.Throws<ArgumentNullException>(() => Validator.CheckEmail(actualEmail));
        }

        [TestCase("Yehor", true)]
        [TestCase("andreyzaycev", true)]
        [TestCase("3266880", false)]
        [TestCase("Skochmen.", false)]
        [TestCase("Step", true)]
        [TestCase("sasha", true)]
        [TestCase("mash,,,a", false)]
        [TestCase("konst", true)]
        [TestCase("..konst.", false)]
        [TestCase("kons$#t", false)]
        [TestCase("aloe", true)]
        [TestCase("mashamashamashamashamashamasha", false)]
        [TestCase("Yakovenko",true)]

        public void FirstOrLastNameCheckTests_CheckIfNameOrLastNameIsValid(string actualName, bool expected)
        {
            bool actual = Validator.CheckFirst_or_LastName(actualName);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void FirstNameCheckTests_ShouldReturnArgumentNullException(string actualName)
        {
            Assert.Throws<ArgumentNullException>(() => Validator.CheckFirst_or_LastName(actualName));
        }

        [TestCase("Yehor", false)]
        [TestCase("andreyzaycev", true)]
        [TestCase("3266880", true)]
        [TestCase("Skochmen.", true)]
        [TestCase("Step", false)]
        [TestCase("sasha", false)]
        [TestCase("mash,,,a", true)]
        [TestCase("konst", false)]
        [TestCase("..konst.", true)]
        [TestCase("kons$#t", true)]
        [TestCase("aloe", false)]
        [TestCase("mashamashamashamashamashamasha", true)]
        [TestCase("mashamashamashamashamashamashamasha", false)]
        [TestCase("Yakovenko", true)]

        public void PasswordCheckTests_CheckIfPasswordIsValid(string actualPassword, bool expected)
        {
            bool actual = Validator.CheckPassword(actualPassword);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void PasswordCheckTests_ShouldReturnArgumentNullException(string actualPassword)
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckPassword(actualPassword));
        }
    }
}
