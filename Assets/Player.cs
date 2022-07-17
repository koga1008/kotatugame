using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rd;
    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.position += new Vector3(0.45f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1f, 1, 1);
            transform.position += new Vector3(-0.45f,0, 0);
        
        }

        if (Input.GetKeyDown(KeyCode.Space) && Grounded == true)
        {
            rd.AddForce(Vector2.up * 500);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Grounded = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "naifu")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
