using UnityEngine;

public class TagUp : MonoBehaviour
{
    // �����, ���������� ��� ������������ � ������ ��������
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowUp"))
        {
            transform.localScale += new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);                          // ����������� �������, � ������� ��������� ������������
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            transform.localScale -= new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);                          // ����������� �������, � ������� ��������� ������������
        }
    }   
}
