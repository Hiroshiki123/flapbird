using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapScript : MonoBehaviour
{
    public float impulso;
    public AudioClip[] clips;
    bool impulcionar;
    Rigidbody2D rb;
    AudioSource audioSouce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
        audioSouce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            impulcionar = true;
            audioSouce.clip = clips[0];
            audioSouce.Play();
            if (!MainScript.jogando)
            {
                rb.gravityScale = 1.0f;

            }
        }
        transform.Rotate(Vector3.forward * (rb.velocity.y * 0.05f));
    }
    private void FixedUpdate()
    {
        if (impulcionar)
        {
            rb.velocity = new Vector2(rb.velocity.x, impulso);
            impulcionar=false;
            MainScript.jogando = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<AudioSource>().Play() ;
        MainScript.pontos += 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSouce.clip = clips[1];
        audioSouce.Play();
        
        Destroy(this);
    }
}
