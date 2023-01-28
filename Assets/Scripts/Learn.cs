using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// ����� �������� ������� ����� C#
/// MonoBehavior ��������, ��� ���� ����� ����� ���� ����������� � GameObject � ����� Unity
/// </summary>
public class Learn : MonoBehaviour
{
    public string firstName = "������";
    public string secondName = "�����������";
    public float pi = 3.14f;
    public bool isDie = false;


    /// <summary>
    /// �������� ������ ���� ������� � ���������
    /// </summary>
    void Start()
    {
        // CalcAge();
        // Debug.Log($"���� ����� {GetName(firstName, secondName)}");
        // IfExample();
        // SwitchExample();
        // ArrayExample();
        // ListExample();
        // DictionaryExample();
        // ForExample();
        // ForeachExample();
        // WhileExample();
        // Test003();
        OOPExamle();



    }

    /// <summary>
    /// ������ ������ � 2-�� �����������, ������� ���������� ��������� ������
    /// </summary>                            
    string GetName(string fn, string ln)
    {
        return fn + " " + ln;
    }

    /// <summary>
    /// ������ ������ � �������������� ��������� ������������ � ����������
    /// </summary>    
    void CalcAge()
    {
        Debug.Log("������� ����� {age} ���");
        Debug.Log($"���� ����� {firstName} {secondName}");
        Debug.LogFormat("���� ����� {0} {1}", firstName, secondName);
    }
    void IfExample()
    {
        bool haveKey = false;
        if (haveKey)
        {
            Debug.Log("������ ������");
            haveKey = false;
        }
        else
        {
            Debug.Log("����� ����");
        }
    }
    void SwitchExample()
    {
        string heroAction = "Go";

        switch (heroAction)
        {
            case "Heal":
                Debug.Log("�������� �������������");
                break;
            case "Attack":
                Debug.Log("�������, ���� �������!");
                break;
            case "Go":
            case "Run":
                Debug.Log("� ��� ��� ����!");
                break;
            default:
                Debug.Log("���-�� ���������� �������� ������...");
                break;
        }
    }
    void ArrayExample()   
    {
        int myZombie = 1;
        string[] arrayZombie = new string[3];
        arrayZombie[0] = "����� ����";
        arrayZombie[1] = "����� ����";
        arrayZombie[2] = "����� ����";
        Debug.Log($"{arrayZombie[0]}, {arrayZombie[1]}, {arrayZombie[2]}");
        
        Debug.Log(string.Join(",", arrayZombie));

        int[] arrayScores = {115, 144, 47};

        Debug.Log($"��� {arrayZombie[myZombie]} ���� {arrayScores[myZombie]} �������");
    }
    void ListExample()
    {
        List<string> listZombie = new List<string>() 
        {"����� ����", "����� ����"};
             
        listZombie.Add("����� ����");
        Debug.Log(string.Join(",", listZombie));

        listZombie.Insert(1, "����� �������");

        Debug.Log(string.Join(",", listZombie));

        listZombie.RemoveAt(2);
        listZombie.RemoveAt(2);
        Debug.Log(string.Join(",", listZombie));
    }
    void DictionaryExample()
    {
        Dictionary<string, int> dictZombie = new Dictionary<string, int>
        {
            { "����� ����", 115},
            { "����� ����", 144},
        };

        Debug.Log($"����� ���� ���� {dictZombie["����� ����"]} �������");
        
        dictZombie["����� ����"] += 1;
        Debug.Log($"����� ���� ���� {dictZombie["����� ����"]} �������");

        dictZombie.Add("����� ���c", 47);
        Debug.Log($"����� ���� ���� {dictZombie["����� ���c"]} �������");

        dictZombie["����� �������"] = 1;
        Debug.Log($"����� ����� ������� ���� {dictZombie["����� �������"]} ������");
    }
    void ForExample()
    {
        List<string> listZombie = new List<string>()
        {"����� ����", "����� ����",  "����� ����", "����� �������" };

        /// ������ ������ � for (initializer; condition; iterator)
        for (int i = 0; i < listZombie.Count; i++ )
        {
            Debug.Log(listZombie[i]);
            if (listZombie[i] == "����� ����")
            {
                Debug.Log("�� ������ �����, ����");
            }                
        }
    }
    void ForeachExample()
    {
        Dictionary<string, int> dictZombie = new Dictionary<string, int>
        {
            { "����� ����", 115},
            { "����� ����", 144},
            { "����� ����", 47},
            { "����� �������", 3}
        };

        string kidZombieName = "";
        int kidZombieKill = int.MaxValue;

        string fatZombieName = "";
        int fatZombieKill = -1;


        foreach (KeyValuePair<string, int> zombie in dictZombie)
        {
            if (zombie.Value < kidZombieKill)
            {
                kidZombieName = zombie.Key;
                kidZombieKill = zombie.Value;
            }

            if (zombie.Value > fatZombieKill)
            {
                fatZombieName = zombie.Key;
                fatZombieKill = zombie.Value;
            }

        }
        Debug.Log($"����� ������ {kidZombieName} ���� {dictZombie[kidZombieName]} ������");
        Debug.Log($"����� ������� {fatZombieName} ���� {dictZombie[fatZombieName]} ������");

    }
    void WhileExample()
    {
        int countCats = 1000;
        int countHamster = 1000;

        while (countCats > 500)
        {
            Debug.Log($"�� ������� ����� {countCats} �������. ����� �� ����������");
            countCats--; 
        }

        while (countCats > 100)
        {
            Debug.Log($"����� ������ � ��������! � ���� �������� {countCats} �������.");
            countCats--;
        }

        while (countCats > 10)
        {
            Debug.Log($"����� �� �����! � ���� �������� {countCats} �������.");
            countCats--;
        }

        while (countCats >= 0)
        {
            Debug.Log($"� ���� �������� {countCats} �������. ����� ������� ���������");
            countCats--;
        }
        

        Debug.Log($"� ���� �� �������� �������. �� ������� ����� {countHamster} ��������. ����� �� ����������!");





    }
    void Test001()
    {
        // ���������� ������������� ����� � ������� { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int[] A = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int countPlus = 0;
        for (int i =0; i < A.Length; i++)
        {
            if (A[i] > 0)
            {
                countPlus++;
            }                
        }
        Debug.Log(countPlus);
    }
    void Test003()
    {
        int n = 7;
        n = n * n;
        n = n * n;
        Debug.Log(n);
    }
    void OOPExamle()
    {
        // -------------- ������ ���������� ���� (�����)

        var zombie = new Ugly_Zombie("��������");
        zombie.PrintStatus();





        /*
        var zombie = new Zombie("�������");
        var zombie_2 = new Zombie();

        
        zombie_2.PrintStatus();
        */

        /*
        // -------------- ������ ���� - �������� (���������)

       var bow = new Weapon("��� ������", 144);
       var gun = bow;

       gun.name = "�����";
       gun.damage = 4000;

       bow.PrintWeaponStatus();
       gun.PrintWeaponStatus();
       */


        // -------------- ������������
        // zombie.Reset(); // �������� ����� �� ����� ���� ������ �� ������� �������



    }





}
