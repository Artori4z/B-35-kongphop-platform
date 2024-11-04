using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField]private float speed;
    //override
    public override void Move()
    {
        Debug.Log("Banana moves with constant speed using Transform");
    }
    public override void OnHitWith(Character character)
    {

    }
    //start
    private void Update()
    {
        Move();
    }
}
