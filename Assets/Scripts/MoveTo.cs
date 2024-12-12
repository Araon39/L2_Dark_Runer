using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public int speed = 20;

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime* speed);
    }   
}

    // public int speed � ����������, ������� �������� �� �������� ������������ ������ ������.
    // transform.Translate � ����� ��� ����������� ������.
    // new Vector3(0, 0, 1) � ����������� ������������.
    // ime.deltaTime� ��������, ������� ��������� ��� �� FPS.