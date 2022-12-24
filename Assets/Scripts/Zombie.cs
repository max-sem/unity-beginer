using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    public string name;
    public int exp = 0;

    public Zombie(string name) // конструктор 
    {
        this.name = name;
    }
    
    public Zombie() // конструктор 
    {
        name = "Я не знаю, кто я" ;
    }


    public void PrintStatus()
    {
        Debug.Log($"Имя зомби: {name} , съел {exp} котиков");
    }

}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStatus()
    {
        Debug.LogFormat("Оружие: {0} - {1} урона", name, damage);
    }

}


