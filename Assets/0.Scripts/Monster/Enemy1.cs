using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Monster
{
    void Start()
    {
        atkTime = 2f;
        power = 10;
        hp = 100;
    }
}
