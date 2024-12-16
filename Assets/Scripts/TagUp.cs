using UnityEngine;

public class TagUp : MonoBehaviour
{
    // �����, ���������� ��� ������������ � ������ ��������
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.CompareTag("ArrowUp"))         // ��������, ���� ������������� ������ ����� ��� "ArrowUp"
        {           
            transform.localScale += new Vector3(1f, 1f, 1f);    // ���������� ������� ������� �� 1 ������� �� ���� ����           
            Destroy(collision.gameObject);                      // ����������� �������, � ������� ��������� ������������
        }
               
        if (collision.gameObject.CompareTag("Obstacle"))        // ��������, ���� ������������� ������ ����� ��� "Obstacle"
        {            
            transform.localScale -= new Vector3(1f, 1f, 1f);    // ���������� ������� ������� �� 1 ������� �� ���� ����            
            Destroy(collision.gameObject);                      // ����������� �������, � ������� ��������� ������������
        }
               
        if (collision.gameObject.CompareTag("Door"))            // ��������, ���� ������������� ������ ����� ��� "Door"
        {            
            Debug.Log("-----GameOver------");                   // ����� ��������� "-----GameOver------" � �������
        }
    }
}

