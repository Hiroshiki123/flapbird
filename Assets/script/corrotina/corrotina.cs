using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corrotina : MonoBehaviour
{
    public Text texto1;
    public Text texto2;
    public Text texto3;
    float a = 0 ;
    float b = 0;
    float c = 0 ;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        texto1.text = a.ToString();
        a++;
    }
    private void FixedUpdate()
    {
        texto2.text = b.ToString();
        b++;
    }
    private void Start()
    {
        StartCoroutine(Contador());
    }
    IEnumerator Contador()
    {
        yield return new WaitForSeconds(1.0f);

    }
}
