using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoWSharp_API;
using WowDotNetAPI;
using WowDotNetAPI.Models;

namespace WoWSharp_API_Tests
{
    [TestClass]
    public class CharacterTests
    {
        private const string TestCharacterName = "Cuifen";
        private const string TestCharacterRealm = "Shadow Council";
        private const CharacterRace TestCharacterRace = CharacterRace.PANDAREN_HORDE;
        private const CharacterClass TestCharacterClass = CharacterClass.MONK;

        [TestMethod]
        public void TestCharacterFetch()
        {
            var testCharacter = Api.GetCharacter(TestCharacterRealm, TestCharacterName);
            Assert.IsNotNull(testCharacter);
            Assert.AreEqual(TestCharacterName, testCharacter.Name);
            Assert.AreEqual(TestCharacterRealm, testCharacter.Realm);
            Assert.AreEqual(TestCharacterRace, testCharacter.Race);
            Assert.AreEqual(TestCharacterClass, testCharacter.Class);
        }

        [TestMethod]
        public void TestCharacterFetchWithOptions()
        {
            var testCharacter = Api.GetCharacter(TestCharacterRealm, TestCharacterName,
                                                       CharacterOptions.GetEverything);
            Assert.IsNotNull(testCharacter);
            Assert.AreEqual(TestCharacterName, testCharacter.Name);
            Assert.AreEqual(TestCharacterRealm, testCharacter.Realm);
            Assert.AreEqual(TestCharacterRace, testCharacter.Race);
            Assert.AreEqual(TestCharacterClass, testCharacter.Class);
            Assert.IsTrue(testCharacter.Stats.Health > 100);
        }
    }
}