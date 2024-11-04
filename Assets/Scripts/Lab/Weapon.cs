using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected string IShootable;
    [SerializeField] private int damage;
    //damage get set
    public int Damage
    {
        get {
            return damage;
        }
        set {
            damage = value;
        }
    }
    //abstract
    public abstract void OnHitWith(Character character);
    public abstract void Move();
    public int GetShootDirection()
    {
        return 1;
    }
    
}

