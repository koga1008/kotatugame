using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightgeneretor : MonoBehaviour
{
    public GameObject fuckyou;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("getabako");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1));
    }
    IEnumerator getabako()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(fuckyou, this.transform.position, this.transform.rotation);
        }
       
    }
    }
