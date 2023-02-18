using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // 1
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    // 2
    private float vInput;
    private float hInput;

    void Update()
    {
        // 3 Ловим изменение вертикальной оси (-1 0 1) и умножаем на скорость
        // Ось - это Axes из системы ввода (W-S), а не вектор направления!!!
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        
        // 4 Ловим горизонтальное ВРАЩЕНИЕ !!! (-1 0 1) и умножаем на скорость
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        Debug.Log($"vInput: {vInput}, hInput: {hInput}");

        // 5 Translate перемещает относительно ориентации !(относительно своей локальной оси Z)
        //  Vector3.forward = Vector3(0, 0, 1)	- норммализованный вектор по Z
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        // 6
        // Vector3.up = Vector3(0, 1, 0) Вращение происходит ВОКРУГ указанной оси
        // Был бы Translate для Vector3.up, то прыгнул бы
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }
}
