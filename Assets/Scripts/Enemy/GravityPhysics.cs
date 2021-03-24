using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GravityPhysics : MonoBehaviour
{
    public float weight;
    public float fallMultiplier;
    public float lowJumpMultiplier;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        FallSpeed();
    }

    void Update()
    {
        
    }

    public virtual void FallSpeed()
    {
        weight = 2;
    }
}
