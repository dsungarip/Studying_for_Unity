using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [클래스설계]
// ResourcesManager : 에셋을 Load, 에셋을 검색해 리턴, 프로젝트 전역에서 사용할수 있어야한다.
// 즉 싱글톤으로 제작해야한다.
// 종류에 따른 리스트(플레이어 캐릭터, 몬스터, NPC)
public class ResourceManagerTest : MonoBehaviour
{
    private List<GameObject> rcPlayerList;
    private List<GameObject> rcMonsterList;
    private List<GameObject> rcNpcList;
	const string rcPlayerFolder = "/Player";
	const string rcMonsterFolder = "/Monster";
	const string rcNpcFolder = "/Npc";

	private void Awake()
	{
		LoadrcPlayer();
		LoadrcMonster();
		LoadrcNpc();
	}

	//foreach문보다 for가 더 빠르다. for를 이용하자
	void LoadrcPlayer()
	{
		rcPlayerList = new List<GameObject>();
		GameObject[] tmp = Resources.LoadAll<GameObject>(rcPlayerFolder);

		for (int i = 0; i < tmp.Length; i++) { rcPlayerList.Add(tmp[i]); }
	}
	void LoadrcMonster()
	{
		rcMonsterList = new List<GameObject>();
		GameObject[] tmp = Resources.LoadAll<GameObject>(rcMonsterFolder);

		for (int i = 0; i < tmp.Length; i++) { rcMonsterList.Add(tmp[i]); }
	}
	void LoadrcNpc()
	{
		rcNpcList = new List<GameObject>();
		GameObject[] tmp = Resources.LoadAll<GameObject>(rcNpcFolder);

		for (int i = 0; i < tmp.Length; i++) { rcNpcList.Add(tmp[i]); }
	}

	public GameObject GetrcPlayer(string name)
	{
		return rcPlayerList.Find(o => (o.name.Equals(name)));
	}
	public GameObject GetrcMonster(string name)
	{
		return rcMonsterList.Find(o => (o.name.Equals(name)));
	}
	public GameObject GetrcNpc(string name)
	{
		return rcNpcList.Find(o => (o.name.Equals(name)));
	}

}
