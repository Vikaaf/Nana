using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveofchild : MonoBehaviour
{
    public float speed;

    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))//���� ����� ������ ������� D
        {
            transform.Translate(-transform.right * speed * Time.deltaTime); //����� ��������� � ������ ������� �� ��� �
        }

        if (Input.GetKey(KeyCode.A))//���� ����� ������ ������� A
        {
            transform.Translate(transform.right * speed * Time.deltaTime); //����� ��������� � ������ ������� �� ��� �
        }
        if (Input.GetKey(KeyCode.W))//���� ����� ������ ������� W
        {
            transform.Translate(-transform.up * speed * Time.deltaTime); //����� ��������� � ������ ������� �� ��� y
        }

        if (Input.GetKey(KeyCode.S))//���� ����� ������ ������� S
        {
            transform.Translate(transform.up * speed * Time.deltaTime); //����� ��������� � ������ ������� �� ��� y
        }
    }
}
