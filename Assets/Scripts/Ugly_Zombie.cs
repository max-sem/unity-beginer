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
    public override void PrintStatus()
    {
    
        Debug.Log($"Имя зомби: {name} , съел {exp} котиков и таскает {weapon.name} урон которого {weapon.damage}");
    }

}