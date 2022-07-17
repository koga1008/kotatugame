using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wooa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.up * 0.3f);
    }
}
