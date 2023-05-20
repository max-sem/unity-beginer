using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public string labelText = "Собери все 4 предмета и получи свободу!";
    public int maxItems = 4; 
    
    
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
            if (_itemCollected >= maxItems)
            {
                labelText = " Ты нашел все предметы!";
            }
            else
            {
                labelText = "Предмет найден. Найди еще " + (maxItems - _itemCollected) + " предметов!";
            
            }
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

    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Жизнь: " + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Предметы: " + _itemCollected);
        GUI.Label( new Rect(20 , 80, 300, 50), labelText);
    }

        

}