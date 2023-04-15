using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    public float jumpVelocity = 10f;
    public float distanceToGround = 0.1f;
    public LayerMask GroundLayer;

    public GameObject bullet; //свойство появится у игрока. Не забыть связать с префабом Bullet!
    public float bulletSpeed = 100f;

    private float vInput;
    private float hInput;
    private Rigidbody _rb;
    private CapsuleCollider _col;

  
    private void Start()
    {
        _rb  = this.GetComponent<Rigidbody>();
        _col = this.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        // Ловим изменение вертикальной оси (-1 0 1) и умножаем на скорость
        // Ось - это Axes из системы ввода (W-S), а не вектор направления!!!
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        // 4 Ловим горизонтальное ВРАЩЕНИЕ !!! (-1 0 1) и умножаем на скорость
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        
        /* 10 Закомментировали вызовы Transform и Rotate с прошлого урока

        // 5 Translate перемещает относительно ориентации !(относительно своей локальной оси Z)
        //  Vector3.forward = Vector3(0, 0, 1)	- норммализованный вектор по Z
            this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        // Vector3.up = Vector3(0, 1, 0) Вращение происходит ВОКРУГ указанной оси
        // Был бы Translate для Vector3.up, то прыгнул бы
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */


        if (IsGrounded() && (Input.GetKeyDown(KeyCode.Q)))
        {            
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate - создать экземпляр. Создаем пулю на левую кнопку мыши
            GameObject newBullet = Instantiate(bullet, 
                this.transform.position + new Vector3(1, 0, 0),
                this.transform.rotation) as GameObject;

            Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>(); // получаем в переменную Rigidbody для новой пули
            bulletRB.velocity = this.transform.forward * bulletSpeed; // скорость пули по направлению игрока. Если использовать AddForce пули будут тянуться к земле (физика, блин)

        }
                

    }
    private void FixedUpdate()
    {
        // Переменная для хранения вращения 
        Vector3 rotation = Vector3.up * hInput;

        // На вход - Vector3, на выход - значение поворота в углах Эйлера
        // Преобразование в тип вращения, который нужен для MoveRotation
        // fixedDeltaTime - аналогичная бодяга deltaTime
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position  + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);        
    }

    /// <summary>
    /// Если коллайдер игрока моприкасается с землей, возвращает true
    /// </summary>
    /// <returns></returns>
    private bool IsGrounded() 
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z );
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, distanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }

}