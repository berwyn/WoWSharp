using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoWSharp_API;
using WowDotNetAPI;

namespace WoWSharp_API_Tests
{
    [TestClass]
    public class GuildTests
    {
        private const string TestGuildName = "Solace";
        private const string TestGuildRealm = "Shadow Council";

        [TestMethod]
        public void TestGuildFetch()
        {
            var testGuild = Api.GetGuild(TestGuildRealm, TestGuildName);
            Assert.IsNotNull(testGuild);
            Assert.AreEqual(TestGuildName, testGuild.Name);
            Assert.AreEqual(TestGuildRealm, testGuild.Realm);
        }

        [TestMethod]
        public void TestGuildFetchWithOptions()
        {
            var testGuild = Api.GetGuild(TestGuildRealm, TestGuildName, GuildOptions.GetEverything);
            Assert.IsNotNull(testGuild);
            Assert.AreEqual(TestGuildName, testGuild.Name);
            Assert.AreEqual(TestGuildRealm, testGuild.Realm);
            Assert.IsNotNull(testGuild.News);
        }
    }
}
