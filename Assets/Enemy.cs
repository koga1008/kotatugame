using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool _isRendered = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isRendered)
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }

    private void OnWillRenderObject()
    {
        if (Camera.current.tag == "MainCamera")
        {
            _isRendered = true;
        }
    }
}
