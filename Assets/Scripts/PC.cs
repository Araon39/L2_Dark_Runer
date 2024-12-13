using UnityEngine;                      // ����������� ������������ ���� UnityEngine

public class PC : MonoBehaviour         // ���������� ������ PC, ������������ MonoBehaviour
{
    public int speed = 20;              // ��������� ���������� ��� �������� �������� �������

    void Update()                       // ����� Update, ���������� ������ ����
    {
        if (Input.GetKey(KeyCode.W))    // ��������, ������ �� ������� "W"
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed); // ����������� ������� ������
        }
    }
}


//Input � �������� ������� �����.
//GetKey � ����������� ������� �� �������.
//KeyCode.W � ���������� ������������� ��� �������.