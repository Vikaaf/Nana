using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveofchild : MonoBehaviour
{
    public float speed;

    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))//если игрок вводит клавишу D
        {
            transform.Translate(-transform.right * speed * Time.deltaTime); //можно применить к любому объекту по оси х
        }

        if (Input.GetKey(KeyCode.A))//если игрок вводит клавишу A
        {
            transform.Translate(transform.right * speed * Time.deltaTime); //можно применить к любому объекту по оси х
        }
        if (Input.GetKey(KeyCode.W))//если игрок вводит клавишу W
        {
            transform.Translate(-transform.up * speed * Time.deltaTime); //можно применить к любому объекту по оси y
        }

        if (Input.GetKey(KeyCode.S))//если игрок вводит клавишу S
        {
            transform.Translate(transform.up * speed * Time.deltaTime); //можно применить к любому объекту по оси y
        }
    }
}
