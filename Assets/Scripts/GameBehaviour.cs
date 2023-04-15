using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private int _itemCollected = 0; // кол-во поднятых предметов

    public int Items
    {
        get { return _itemCollected; }
        set
        {
            _itemCollected = value;
            Debug.LogFormat("Предметы: {0}", _itemCollected);
        }
    }

    private int _playerHP = 10; // здоровье героя
    public int HP
    {
        get { return _playerHP; }
        set 
        {
            _playerHP = value;
            Debug.LogFormat("Жизни: {0}", _playerHP);
        }
    
    }


}
