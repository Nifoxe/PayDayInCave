using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Delete", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Delete()
    {
        Destroy(gameObject);
    }
}
