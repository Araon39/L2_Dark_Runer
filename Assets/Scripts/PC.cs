using TMPro;
using UnityEngine;

public class PC : MonoBehaviour
{
    public int speed = 20;



    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
    }

      
}

//Input � �������� ������� �����.
//GetKey � ����������� ������� �� �������.
//KeyCode.W � ���������� ������������� ��� �������.