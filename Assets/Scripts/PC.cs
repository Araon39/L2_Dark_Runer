using TMPro;
using UnityEngine;

public class PC : MonoBehaviour
{
    public int speed = 20;



    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
    }

      
}

//Input Ч получает событие ввода.
//GetKey Ч отслеживает нажатие на клавишу.
//KeyCode.W Ч возвращает универсальный код клавиши.