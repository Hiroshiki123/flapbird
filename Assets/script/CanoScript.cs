using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour
{
    public float speed;
    public float limitX;
    public float uplimit;
    public float downlimit;
    Vector2 initialPosition;

    private void Start()
    {
        //define a possição inicial como a posição do objeto
        initialPosition = transform.position;
        PipePosition(uplimit, downlimit);
    }
    void Update()
    {
        //move o cano pra esqueda
        transform.Translate(Vector2.left*speed*Time.deltaTime);
        if (transform.position.x < limitX)
        {
            //volta para a posição inicial
            PipePosition(uplimit, downlimit);
        } 
    }
    void PipePosition(float u, float d)
    {
        transform.position = initialPosition;
        transform.position = new Vector3(transform.position.x, Random.Range(u, d));
    }
}
