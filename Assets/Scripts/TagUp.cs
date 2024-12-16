using UnityEngine;

public class TagUp : MonoBehaviour
{
    // ћетод, вызываемый при столкновении с другим объектом
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowUp"))
        {
            transform.localScale += new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);                          // ”ничтожение объекта, с которым произошло столкновение
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            transform.localScale -= new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);                          // ”ничтожение объекта, с которым произошло столкновение
        }
    }   
}
