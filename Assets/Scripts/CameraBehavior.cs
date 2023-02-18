using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // 1 Переменная для хранения расстояния между камерой и игроком
    // Можно сначала вручную установить, затем записать значения
    public Vector3 camOffset = new Vector3(0f, 1.2f, -2.6f);

    // 2 Переменная для хранения Transform игрока
    private Transform target;

    void Start()
    {
        // 3 Ищем игорока по имени и присваиваем target его transform
        // target - это ссылка. При изменении позиции игрока в target будут новые значения из transform
        target = GameObject.Find("Player").transform;
    }

    // 4 LateUpdate - встроенный метод, выполняется после Update
    void LateUpdate()
    {
        // 5 TransformPoint возвращает относительное положение в глобальном пространстве
        // Параметр camOffset - сдвиг от полученной позиции
        // this - это наша камера. ее позиция каждый кадр считывается с позиции  target ( = "Player")  + сдвиг
        this.transform.position = target.TransformPoint(camOffset);

        // 6 LookAt - Заставляет смотреть на цель. Попробовать без него для понимания
        // Поворачивает преобразование так, чтобы вектор указывал на позицию в объекта в параметре
        this.transform.LookAt(target);
    }
}
