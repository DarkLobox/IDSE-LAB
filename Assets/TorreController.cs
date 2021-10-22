using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreController : MonoBehaviour
{
    public TextMesh barraProgreso;
    private float porcentajeFloat = 0;
    private int porcentaje = 0;
    private int posesion = 0; // 0 = nadie tiene la bandera  1 = jugador 1 tiene bandera  2 = jugador 2 tiene bandera
    private bool c1, c2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void FixedUpdate()
    {
        if (!c1 && !c2)
        {
            porcentaje = 0;
            porcentajeFloat = 0.0f;
            posesion = 0;
            barraProgreso.color = Color.white;
        }
        else if (c1 && !c2)
        {
            //Jugador 1 capturando
            posesion = 1;
            porcentajeFloat += 0.05f;
            porcentaje = (int)porcentajeFloat;
            barraProgreso.color = Color.red;
        }
        else if (c2 && !c1)
        {
            //Jugador 2 capturando
            posesion = 2;
            porcentajeFloat += 0.05f;
            porcentaje = (int)porcentajeFloat;
            barraProgreso.color = Color.green;
        }
        barraProgreso.text = porcentaje + "%";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "jugador1")
        {
            c1 = true;
        }

        if (collision.gameObject.tag == "jugador2")
        {
            c2 = true;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "jugador1")
        {
            c1 = false;
        }

        if (collision.gameObject.tag == "jugador2")
        {
            c2 = false;
        }
    }
}
