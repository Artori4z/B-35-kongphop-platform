using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb;
    private Vector2 force;
   
    public override void Move()
    {
        Debug.Log(" ");
    }
    public override void OnHitWith(Character character)
    {
 
    }
}
