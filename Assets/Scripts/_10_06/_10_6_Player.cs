using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_6_Player : _10_6_Character<CHARINFO>
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(info.name);
    }

    public override void oneSkill()
    {
        base.oneSkill();
    }
    public override void twoSkill()
    {
        base.twoSkill();
    }
    public override void threeSkill()
    {
        base.threeSkill();
    }
    public override void fourSkill()
    {
        base.fourSkill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
