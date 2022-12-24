using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    public string name;
    public int exp = 0;

    public Zombie(string name) // ����������� 
    {
        this.name = name;
    }
    
    public Zombie() // ����������� 
    {
        name = "� �� ����, ��� �" ;
    }


    public void PrintStatus()
    {
        Debug.Log($"��� �����: {name} , ���� {exp} �������");
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
        Debug.LogFormat("������: {0} - {1} �����", name, damage);
    }

}

