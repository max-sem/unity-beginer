using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Здесь пахнет человечиной");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Обед исчез :((");
        }
    }




}
