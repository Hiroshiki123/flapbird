using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class complicação : MonoBehaviour
{
    public Button btinicial;

    private void Start()
    {
        Button bInicial = btinicial.GetComponent<Button>();
        bInicial.onClick.AddListener(Inicial);
    }

    private void Inicial()
    {
        GameObject.Find("mudarcena").GetComponent<Cena>().Ir();
    }
}
