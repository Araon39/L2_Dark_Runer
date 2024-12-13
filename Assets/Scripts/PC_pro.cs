using UnityEngine; // Подключение пространства имен UnityEngine

public class PC_pro : MonoBehaviour // Объявление класса PC_pro, наследующего MonoBehaviour
{
    private int speed = 20;             // Скорость движения объекта
    private int rotationSpeed = 80;     // Скорость вращения объекта
    private float horizontal;           // Переменная для хранения горизонтального ввода
    private float vertical;             // Переменная для хранения вертикального ввода

    void Update() // Метод Update, вызываемый каждый кадр
    {
        horizontal = Input.GetAxis("Horizontal");   // Получение горизонтального ввода
        vertical = Input.GetAxis("Vertical");       // Получение вертикального ввода

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);       // Перемещение объекта вперед/назад
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);     // Вращение объекта вокруг вертикальной оси
    }
}

