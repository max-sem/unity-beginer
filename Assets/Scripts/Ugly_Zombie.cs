using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugly_Zombie : Zombie // ��������� ����� - ��������� ������ �����
{
    public Weapon weapon; // ���������� - � ����� ����������  ������ ����� (��� ���������)

    public Ugly_Zombie(string name, Weapon weapon) : base(name) // ����� ������������� ������������ 
    {
        // ����������� Ugly_Zombie �������� �������� name � ����������� Zombie

        // �������� weapon - ��� ����������� Ugly_Zombie
        this.weapon = weapon;
    }
    public override void PrintStatus()
    {        
        Debug.Log($"��� �����: {name} , ������� {weapon.name}");
    }

}


