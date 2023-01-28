using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugly_Zombie : Zombie
{
    public Weapon weapon;

    public Ugly_Zombie(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;   
    }
}