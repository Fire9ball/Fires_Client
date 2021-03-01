//All of these values have been simplified, if you would like a full function for something (i.e. Extras.ChangeAvatar) ask and i will give you the function

//This is formated like this:
//What the function does
//Usage example (sometimes i dont have an example so its not there)

//Script also has a slightly modified RubyButtonAPI to allow it working with tabs

namespace ClientCore
{
  public static class Extras
  {
    //Returns current menu from social menu selection
    //var PlayerName = GetUserPageInfo.field_Public_APIUser_0.displayName;
    PageUserInfo GetUserPageInfo;
    //Returns selected world from World Menu
    //var WorldName = GetWorldInfo.field_Private_ApiWorld_0.name;
    PageWorldInfo GetWorldInfo;    
    //Returns local user (you)
    //var DisplayName = GetLocalUser.displayName;
    VRCPlayerApi GetLocalUser;
    
    //Returns...i honestly dont know, havent tested, i guess avatar info, it changes your avatar to the id ok
    //ChangeAvatar("avtr_adcd988e-82a0-4d79-a5df-230cd933b503");
    PageAvatar ChangeAvatar(string AvatarID);    
    
    //Returns the user by using a id
    //var Fire9Ball_Player = GetPlayerByID("usr_b789f625-1783-478a-b49f-8805689d131a");
    Player GetPlayerByID(string id);    
    //Same as above GetPlayerByID but with player
    Player PlayerByID(this APIUser apiUser);
    //same as GetPlayerByID but looks for locally loaded users instead of PlayerManager
    //var Fire9Ball_Player = GetPlayerByID("usr_b789f625-1783-478a-b49f-8805689d131a");
    Player PlayerByID(string ID);    
    //Reloads a certain player
    void ReloadPlayer(this Player player);
    
    //Gets the user you select in the quickmenu
    //APIUser user = GetSelectedUser;
    APIUser GetSelectedUser;    
    //Same as GetUserPageInfo but automatically returns the apiuser
    //var PlayerName = GetPageUser.displayName;
    APIUser GetPageUser;    
    //Reloads the apiUser
    //GetPageUser.ReloadPlayer();
    void ReloadPlayer(this APIUser apiUser);
    
    //Gets the current api world
    //var worldInstance = GetApiWorld
    ApiWorldInstance GetApiWorld;
    
    //Converts a Il2CppArrayBase to a Collections.List
    List<T> ToList<T>(this UnhollowerBaseLib.Il2CppArrayBase<T> input);
    
    //Gets a Il2CppSystem.Type out of System.Type
    //typeof(string).GetIl2CppType();
    Il2CppSystem.Type GetIl2CppType<T>(this T input);
    
    //Loads a texture from FilePath (WIP)
    Texture2D LoadTexture(string FilePath);
  }
}
