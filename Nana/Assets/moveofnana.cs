using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveofnana : MonoBehaviour
{
    public GameObject child;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, child.transform.position, Time.deltaTime);
    }
}
