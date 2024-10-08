using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private int damage;
    //damage get set
  [SerializeField]public int Damage
    {
        get {
            return damage;
            }
        set {
            damage = value;
            }
    }
    public string IShootable;
    //abstract
    public abstract void  OnHitWith(Character character);
    public abstract void Move();
    public int GetShootDirection()
    {
        return 1;
    }
}
