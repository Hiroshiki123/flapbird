using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour
{
    public Text txtPontos;
    // Start is called before the first frame update
    void Start()
    {
        MainScript.pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = MainScript.pontos.ToString();
    }
}
