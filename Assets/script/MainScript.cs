using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class MainScript : MonoBehaviour
{
    public static bool jogando;
    public static int pontos;
    public GameObject getready;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogando == true)
        {
            getready.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameover.SetActive(true);
    }
}
