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

    // 7 
    // содержит информацию о компоненте Rigidbody капсулы
    private Rigidbody _rb;

    // 8
    void Start()
    {
        // 9  Получаем компонент объекта по типу 
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // 3 Ловим изменение вертикальной оси (-1 0 1) и умножаем на скорость
        // Ось - это Axes из системы ввода (W-S), а не вектор направления!!!
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        
        // 4 Ловим горизонтальное ВРАЩЕНИЕ !!! (-1 0 1) и умножаем на скорость
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;


        /* 10 Закомментировали вызовы Transform и Rotate с прошлого урока
         
        // 5 Translate перемещает относительно ориентации !(относительно своей локальной оси Z)
        //  Vector3.forward = Vector3(0, 0, 1)	- норммализованный вектор по Z
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        // 6
        // Vector3.up = Vector3(0, 1, 0) Вращение происходит ВОКРУГ указанной оси
        // Был бы Translate для Vector3.up, то прыгнул бы
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */
    }


    private void FixedUpdate() // 11 Специальный Update для физики
    {
        // 12 Переменная для хранения вращения 
        Vector3 rotation = Vector3.up * hInput;

        // 13 На вход - Vector3, на выход - значение поворота в углах Эйлера
        // Преобразование в тип вращения, который нужен для MoveRotation
        // fixedDeltaTime - аналогичная бодяга deltaTime
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        
        // 14
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);

        // 5
        _rb.MoveRotation(_rb.rotation * angleRot);

    }

}
