﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehaviour gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();


    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player") 
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Здоровье получено!");

            gameManager.Items += 1;

        }

       



    }
    


}
