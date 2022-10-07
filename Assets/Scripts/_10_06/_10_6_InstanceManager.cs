using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public abstract class CharacterFactory
//{
//    virtual public void CreateCharacter() { }
//}
//public class KnightFactory : CharacterFactory
//{
//    public override void CreateCharacter()
//    {
//        base.CreateCharacter();
//    }
//}
//public class MagicianFactory : CharacterFactory
//{
//    public override void CreateCharacter()
//    {
//        base.CreateCharacter();
//    }
//}

public struct CHARINFO
{
    public string name { get; set; }
}
public class _10_6_InstanceManager : SingleTon<_10_6_InstanceManager>
{
    List<_10_6_Character<CHARINFO>> characterList;
    _10_6_Player player;
    public void Initialize()
    {
        characterList = new List<_10_6_Character<CHARINFO>>();
        _10_6_ResourceManager.instance.LoadrcCharacter();
    }
    public void CreatePlayer(string _name)
    {
        GameObject obj = _10_6_ResourceManager.instance.GetRcCharacter(_name);
        if(obj != null)
        {
            GameObject createdObj = GameObject.Instantiate<GameObject>(obj);
            player = createdObj.AddComponent<_10_6_Player>();
            player.gameObject.layer = LayerMask.NameToLayer("Player");
            Vector3? objPos = GeometryHelper.GetTerrainHeightPos(new Vector3(0,0,0));
            CHARINFO info = new CHARINFO();
            info.name = "zeronine";
            player.info = info;
            if (objPos.HasValue)
                player.transform.position = objPos.Value;
        }
    }
    public void CreateMonster(string _name)
    {
        GameObject obj = _10_6_ResourceManager.instance.GetRcCharacter(_name);
        if (obj != null)
        {
            GameObject createdObj = GameObject.Instantiate<GameObject>(obj);
            _10_6_Character<CHARINFO> addedScript = createdObj.AddComponent<_10_6_Monster>();
            CHARINFO info = new CHARINFO();
            info.name = "Goblin";
            addedScript.info = info;
            characterList.Add(addedScript);
        }
    }
}
