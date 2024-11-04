using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb;
    private Vector2 force;
   
    //override
    public override void Move()
    {
        Debug.Log("Rock move with Rigidbody : force");
    }
    public override void OnHitWith(Character character)
    {
 
    }
    //start
    public void Start()
    {
        Move();
    }
}
