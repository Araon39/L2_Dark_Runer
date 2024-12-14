using UnityEngine;                                             

public class Colider_Triger : MonoBehaviour                     
{
    // Метод, вызываемый при столкновении с другим объектом
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("колизи с " + collision.gameObject.name);     // Вывод в консоль имени объекта, с которым произошло столкновение
        Destroy(collision.gameObject);                          // Уничтожение объекта, с которым произошло столкновение
    }

    // Метод, вызываемый при входе в триггерную зону другого объекта
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("тригер с " + other.gameObject.name);         // Вывод в консоль имени объекта, который вошел в триггерную зону
        DestroyImmediate(other.gameObject);                     // Немедленное уничтожение объекта, который вошел в триггерную зону
    }
}

