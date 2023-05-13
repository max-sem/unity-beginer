using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    private int _itemCollected = 0; 

    public int Items 
    {
        get 
        {
            return _itemCollected;
        }
        set 
        {
            _itemCollected = value;
            Debug.LogFormat("Собрано предметов: {0}", _itemCollected);

        }    
    }
     
    private int _playerHP = 10;
    public int HP
    {
        get 
        { 
            return _playerHP; 
        }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Осталось жизней: {0}, ", _playerHP);
        }    
    }    
}
