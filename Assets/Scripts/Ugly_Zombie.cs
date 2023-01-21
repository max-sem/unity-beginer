using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugly_Zombie : Zombie // Уродливый зомби - наследник класса Зомби
{
    public Weapon weapon; // Композиция - в класс запихиваем  другой класс (или структуру)

    public Ugly_Zombie(string name, Weapon weapon) : base(name) // вызов родительского конструктора 
    {
        // Конструктор Ugly_Zombie передает параметр name в конструктор Zombie

        // параметр weapon - уже собственный Ugly_Zombie
        this.weapon = weapon;
    }
    public override void PrintStatus()
    {        
        Debug.Log($"Имя зомби: {name} , получил {weapon.name}");
    }

}


