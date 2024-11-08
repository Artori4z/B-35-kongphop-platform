using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    [SerializeField] public Slider HpSlider;
    private float hp;
    private float MaxHp;

    private void Awake()
    {
        MaxHp = 100f;
        hp = MaxHp;
    }
}
