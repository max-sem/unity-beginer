using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Класс содержит примеры языка C#
/// MonoBehavior означает, что этот класс может быть присоединен к GameObject в сцене Unity
/// </summary>
public class Learn : MonoBehaviour
{
    public string firstName = "Максим";
    public string secondName = "Семичастнов";
    public float pi = 3.14f;
    public bool isDie = false;    
    private Transform camTransform;


    /// <summary>
    /// Содержит вызовы всех методов с примерами
    /// </summary>
    void Start()
    {
        // CalcAge();
        // Debug.Log($"Меня зовут {GetName(firstName, secondName)}");
        // IfExample();
        // SwitchExample();
        // ArrayExample();
        // ListExample();
        // DictionaryExample();
        // ForExample();
        // ForeachExample();
        // WhileExample();
        // Test003();
        // OOPExamle();
        OOPAccess();
    }

    /// <summary>
    /// Пример метода с 2-мя параметрами, который возвращает склеенную строку
    /// </summary>                            
    string GetName(string fn, string ln)
    {
        return fn + " " + ln;
    }

    /// <summary>
    /// Пример метода с использованием строковой интерполяции и параметров
    /// </summary>    
    void CalcAge()
    {
        Debug.Log("Возраст героя {age} лет");
        Debug.Log($"Меня зовут {firstName} {secondName}");
        Debug.LogFormat("Меня зовут {0} {1}", firstName, secondName);
    }
    void IfExample()
    {
        bool haveKey = false;
        if (haveKey)
        {
            Debug.Log("Сундук открыт");
            haveKey = false;
        }
        else
        {
            Debug.Log("Найти ключ");
        }
    }
    void SwitchExample()
    {
        string heroAction = "Go";

        switch (heroAction)
        {
            case "Heal":
                Debug.Log("Здоровье восстановлено");
                break;
            case "Attack":
                Debug.Log("Хозяина, меня убивают!");
                break;
            case "Go":
            case "Run":
                Debug.Log("Я иду или бегу!");
                break;
            default:
                Debug.Log("Что-то непонятное творится вокруг...");
                break;
        }
    }
    void ArrayExample()   
    {
        int myZombie = 1;
        string[] arrayZombie = new string[3];
        arrayZombie[0] = "зомби Вася";
        arrayZombie[1] = "зомби Петя";
        arrayZombie[2] = "зомби Стас";
        Debug.Log($"{arrayZombie[0]}, {arrayZombie[1]}, {arrayZombie[2]}");
        
        Debug.Log(string.Join(",", arrayZombie));

        int[] arrayScores = {115, 144, 47};

        Debug.Log($"Наш {arrayZombie[myZombie]} съел {arrayScores[myZombie]} котенка");
    }
    void ListExample()
    {
        List<string> listZombie = new List<string>() 
        {"зомби Вася", "зомби Петя"};
             
        listZombie.Add("зомби Стас");
        Debug.Log(string.Join(",", listZombie));

        listZombie.Insert(1, "зомби Никодим");

        Debug.Log(string.Join(",", listZombie));

        listZombie.RemoveAt(2);
        listZombie.RemoveAt(2);
        Debug.Log(string.Join(",", listZombie));
    }
    void DictionaryExample()
    {
        Dictionary<string, int> dictZombie = new Dictionary<string, int>
        {
            { "зомби Вася", 115},
            { "зомби Петя", 144},
        };

        Debug.Log($"зомби Вася съел {dictZombie["зомби Вася"]} котиков");
        
        dictZombie["зомби Вася"] += 1;
        Debug.Log($"зомби Вася съел {dictZombie["зомби Вася"]} котиков");

        dictZombie.Add("зомби Стаc", 47);
        Debug.Log($"зомби Стас съел {dictZombie["зомби Стаc"]} котиков");

        dictZombie["зомби Никодим"] = 1;
        Debug.Log($"Новый зомби Никодим съел {dictZombie["зомби Никодим"]} котика");
    }
    void ForExample()
    {
        List<string> listZombie = new List<string>()
        {"зомби Вася", "зомби Петя",  "зомби Стас", "зомби Никодим" };

        /// Пример метода с for (initializer; condition; iterator)
        for (int i = 0; i < listZombie.Count; i++ )
        {
            Debug.Log(listZombie[i]);
            if (listZombie[i] == "зомби Стас")
            {
                Debug.Log("Ты просто супер, Стас");
            }                
        }
    }
    void ForeachExample()
    {
        Dictionary<string, int> dictZombie = new Dictionary<string, int>
        {
            { "зомби Вася", 115},
            { "зомби Петя", 144},
            { "зомби Стас", 47},
            { "зомби Никодим", 3}
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
        Debug.Log($"Самый мелкий {kidZombieName} съел {dictZombie[kidZombieName]} котика");
        Debug.Log($"Самый толстый {fatZombieName} съел {dictZombie[fatZombieName]} котика");

    }
    void WhileExample()
    {
        int countCats = 1000;
        int countHamster = 1000;

        while (countCats > 500)
        {
            Debug.Log($"На планете живет {countCats} котиков. Зомби не существует");
            countCats--; 
        }

        while (countCats > 100)
        {
            Debug.Log($"Зомби видели в Монголии! В мире осталось {countCats} котиков.");
            countCats--;
        }

        while (countCats > 10)
        {
            Debug.Log($"Зомби на улице! В мире осталось {countCats} котиков.");
            countCats--;
        }

        while (countCats >= 0)
        {
            Debug.Log($"В мире осталось {countCats} котиков. Зомби доедают последних");
            countCats--;
        }
        

        Debug.Log($"В мире не осталось котиков. На планете живет {countHamster} хомячков. Зомби не существует!");





    }
    void Test001()
    {
        // Количество положительных чисел в массиве { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
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
        // -------------- Пример ссылочного типа (класс)

        var kalash = new Weapon("АК-74", 144);

        var zombie = new Ugly_Zombie("Афанасий", kalash);
        zombie.PrintStatus();




        /*
     
        
        var zombie = new Zombie("Никодим");
        var zombie_2 = new Zombie();
        
        zombie_2.PrintStatus();
        */

        /*
        // -------------- Пример типа - значения (структура)

       var bow = new Weapon("Лук боевой", 144);
       var gun = bow;

       gun.name = "Ружье";
       gun.damage = 4000;

       bow.PrintWeaponStatus();
       gun.PrintWeaponStatus();
       */


        // -------------- Инкапсуляция
        // zombie.Reset(); // закрытый метод не может быть вызван из другого объекта



    }

    void OOPAccess()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log($"Позиция: {camTransform.localPosition}" );
        Debug.Log($"Позиция: {camTransform.localRotation}");




    }




}
