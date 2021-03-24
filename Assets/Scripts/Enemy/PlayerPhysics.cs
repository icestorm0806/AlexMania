using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : GravityPhysics
{
    // Start is called before the first frame update
    void Start()
    {
        FallSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void FallSpeed()
    {
        base.FallSpeed();
        weight = 67;
    }
}
