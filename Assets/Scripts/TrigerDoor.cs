using UnityEngine;

public class TrigerDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))            // ��������, ���� ������������� ������ ����� ��� "Door"
        {
            Debug.Log("-----GameOver------");                   // ����� ��������� "-----GameOver------" � �������
        }
    }
}
