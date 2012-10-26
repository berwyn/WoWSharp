using System.Collections.Generic;
using WowDotNetAPI;
using WowDotNetAPI.Models;

namespace WoWSharp_API
{
    public static class Api
    {
        public const string ThumbnailUrlBase = "http://{0}.battle.net/static-render/{0}/{1}";

        private static WowExplorer ApiClient { get; set; }
        private static List<Character> Characters { get; set; }
        private static List<Guild> Guilds { get; set; } 

        static Api()
        {
            ApiClient = new WowExplorer();
            Characters = new List<Character>();
            Guilds = new List<Guild>();
        }

        #region Characters
        public static Character GetCharacter(string realm, string name)
        {
            Character character = Characters.Exists(c => (c.Name == name) && (c.Realm == realm))
                                      ? Characters.Find(c => (c.Name == name) && (c.Realm == realm))
                                      : ApiClient.GetCharacter(realm, name);
            return character;
        }

        public static Character GetCharacter(string realm, string name, CharacterOptions options)
        {
            Character character = Characters.Exists(c => (c.Name == name) && (c.Realm == realm))
                                      ? Characters.Find(c => (c.Name == name) && (c.Realm == realm))
                                      : ApiClient.GetCharacter(realm, name, options);
            return character;
        }
        #endregion

        #region Guilds
        public static Guild GetGuild(string realm, string name)
        {
            Guild guild = Guilds.Exists(g => (g.Name == name) && (g.Realm == realm))
                              ? Guilds.Find(g => (g.Name == name) && (g.Realm == realm))
                              : ApiClient.GetGuild(realm, name);
            return guild;
        }

        public static Guild GetGuild(string realm, string name, GuildOptions options)
        {
            Guild guild = Guilds.Exists(g => (g.Name == name) && (g.Realm == realm))
                              ? Guilds.Find(g => (g.Name == name) && (g.Realm == realm))
                              : ApiClient.GetGuild(realm, name, options);
            return guild;
        }
        #endregion

        #region CRUD
        public static void StoreCharacter(Character character)
        {
            Characters.Add(character);
        }

        public static void StoreGuild(Guild guild)
        {
            Guilds.Add(guild);
        }
        #endregion
    }
}