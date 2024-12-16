using UnityEngine;

public class TagUp : MonoBehaviour
{
    // Метод, вызываемый при столкновении с другим объектом
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.CompareTag("ArrowUp"))         // Проверка, если столкнувшийся объект имеет тег "ArrowUp"
        {           
            transform.localScale += new Vector3(1f, 1f, 1f);    // Увеличение размера объекта на 1 единицу по всем осям           
            Destroy(collision.gameObject);                      // Уничтожение объекта, с которым произошло столкновение
        }
               
        if (collision.gameObject.CompareTag("Obstacle"))        // Проверка, если столкнувшийся объект имеет тег "Obstacle"
        {            
            transform.localScale -= new Vector3(1f, 1f, 1f);    // Уменьшение размера объекта на 1 единицу по всем осям            
            Destroy(collision.gameObject);                      // Уничтожение объекта, с которым произошло столкновение
        }
               
        if (collision.gameObject.CompareTag("Door"))            // Проверка, если столкнувшийся объект имеет тег "Door"
        {            
            Debug.Log("-----GameOver------");                   // Вывод сообщения "-----GameOver------" в консоль
        }
    }
}

