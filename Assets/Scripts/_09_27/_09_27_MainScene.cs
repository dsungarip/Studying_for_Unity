using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _09_27_MainScene : MonoBehaviour
{
    List<GameObject> characterList;
	void Awake()
	{
        characterList = new List<GameObject>();
        CreateInstance("TrollGiant"); 
    }

    public void CreateInstance(string _name)
	{
        GameObject rcobj = ResourceManager.instance.GetCharacterRc("TrollGiant");

        for (int i = 0; i<10; i++) 
		{
            if (rcobj != null)
            {
                GameObject instance = Instantiate(rcobj, Vector3.zero, Quaternion.identity);
                instance.name = "TrollGiant_" + i.ToString();
                characterList.Add(instance);
            }
        }

    }
}
