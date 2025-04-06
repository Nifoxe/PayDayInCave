using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFly : MonoBehaviour
{
    private bool posible = true;
    private float speed = 1;
    void Start()
    {
        Invoke("End", 12f);
    }
    void End()
    {
        Destroy(gameObject);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        if (speed < 50f)
        {
            speed = speed * 1.01f;
        }
        else
        {
            speed = speed * 1.002f;
        }
    }
}
