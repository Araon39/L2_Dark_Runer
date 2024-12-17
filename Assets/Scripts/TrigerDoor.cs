using UnityEngine;

public class TrigerDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))            // Проверка, если столкнувшийся объект имеет тег "Door"
        {
            Debug.Log("-----GameOver------");                   // Вывод сообщения "-----GameOver------" в консоль
        }
    }
}
