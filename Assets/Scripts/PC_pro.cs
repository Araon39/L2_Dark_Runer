using UnityEngine; // ����������� ������������ ���� UnityEngine

public class PC_pro : MonoBehaviour // ���������� ������ PC_pro, ������������ MonoBehaviour
{
    private int speed = 20;             // �������� �������� �������
    private int rotationSpeed = 80;     // �������� �������� �������
    private float horizontal;           // ���������� ��� �������� ��������������� �����
    private float vertical;             // ���������� ��� �������� ������������� �����

    void Update() // ����� Update, ���������� ������ ����
    {
        horizontal = Input.GetAxis("Horizontal");   // ��������� ��������������� �����
        vertical = Input.GetAxis("Vertical");       // ��������� ������������� �����

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);       // ����������� ������� ������/�����
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);     // �������� ������� ������ ������������ ���
    }
}

