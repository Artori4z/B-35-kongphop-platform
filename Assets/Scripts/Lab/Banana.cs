using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    private float speed;
    
    public override void Move()
    {
        Debug.Log(" ");
    }
    public override void OnHitWith(Character character)
    {

    }
    private void Start()
    {
        Damage = 30;
        speed = 4;

    }
}
