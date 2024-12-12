using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public int speed = 20;

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime* speed);
    }   
}

    // public int speed Ч переменна€, котора€ отвечает за скорость передвижени€ нашего игрока.
    // transform.Translate Ч метод дл€ перемещени€ игрока.
    // new Vector3(0, 0, 1) Ч направление передвижени€.
    // ime.deltaTimeЧ величина, котора€ избавл€ет нас от FPS.