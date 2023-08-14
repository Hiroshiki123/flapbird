using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cena : MonoBehaviour
{
    public string nomeCena;
    public void Ir()
    {
        SceneManager.LoadScene(nomeCena);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
