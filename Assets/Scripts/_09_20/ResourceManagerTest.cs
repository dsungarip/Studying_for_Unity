using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Ŭ��������]
// ResourcesManager : ������ Load, ������ �˻��� ����, ������Ʈ �������� ����Ҽ� �־���Ѵ�.
// �� �̱������� �����ؾ��Ѵ�.
// ������ ���� ����Ʈ(�÷��̾� ĳ����, ����, NPC)
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

	//foreach������ for�� �� ������. for�� �̿�����
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
