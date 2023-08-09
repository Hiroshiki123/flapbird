using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapScript : MonoBehaviour
{
    public float impulso;

    bool impulcionar;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            impulcionar = true;
        }
        transform.Rotate(Vector3.forward * (rb.velocity.y * 0.05f));
    }
    private void FixedUpdate()
    {
        if (impulcionar)
        {
            rb.velocity = new Vector2(rb.velocity.x, impulso);
            impulcionar=false;
        }
    }
}
