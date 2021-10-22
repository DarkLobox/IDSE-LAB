using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + posicionInicial;
    }
}
