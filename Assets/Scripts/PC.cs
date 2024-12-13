using UnityEngine;                      // ѕодключение пространства имен UnityEngine

public class PC : MonoBehaviour         // ќбъ€вление класса PC, наследующего MonoBehaviour
{
    public int speed = 20;              // ѕублична€ переменна€ дл€ скорости движени€ объекта

    void Update()                       // ћетод Update, вызываемый каждый кадр
    {
        if (Input.GetKey(KeyCode.W))    // ѕроверка, нажата ли клавиша "W"
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed); // ѕеремещение объекта вперед
        }
    }
}


//Input Ч получает событие ввода.
//GetKey Ч отслеживает нажатие на клавишу.
//KeyCode.W Ч возвращает универсальный код клавиши.