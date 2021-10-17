using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaController : MonoBehaviour
{
    public float vida = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balaPesada")
        {
            //Destroy(collision.gameObject);
            vida = vida - 3;
        }
        if (collision.gameObject.tag == "balaLigera")
        {
            //Destroy(collision.gameObject);
            vida = vida - 1;
        }
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
