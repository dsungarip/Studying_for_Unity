using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_6_PracticeManager : MonoBehaviour
{
    void Awake()
    {
        _10_6_InstanceManager.instance.Initialize();
        _10_6_InstanceManager.instance.CreatePlayer("TrollGiant");
        _10_6_InstanceManager.instance.CreateMonster("TrollGiant");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
