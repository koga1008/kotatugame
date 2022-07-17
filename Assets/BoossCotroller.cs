using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoossCotroller : MonoBehaviour
{
    public GameObject bosscotroller;
    public GameObject fuckyou;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(fuckyou.gameObject, bosscotroller.transform.position, bosscotroller.transform.rotation); 
    }
}
