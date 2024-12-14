using UnityEngine;                                             

public class Colider_Triger : MonoBehaviour                     
{
    // �����, ���������� ��� ������������ � ������ ��������
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("������ � " + collision.gameObject.name);     // ����� � ������� ����� �������, � ������� ��������� ������������
        Destroy(collision.gameObject);                          // ����������� �������, � ������� ��������� ������������
    }

    // �����, ���������� ��� ����� � ���������� ���� ������� �������
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("������ � " + other.gameObject.name);         // ����� � ������� ����� �������, ������� ����� � ���������� ����
        DestroyImmediate(other.gameObject);                     // ����������� ����������� �������, ������� ����� � ���������� ����
    }
}

