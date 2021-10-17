using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonPesadoController : MonoBehaviour
{
    public GameObject balaPesada;
    public float delayInicial = 1f;
    public float delayEntreObjetos = 1f;
    private float fuerza = 800f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("crearBalaTanque", delayInicial, delayEntreObjetos);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void crearBalaTanque()
    {
        var balaDelTanque = Instantiate(balaPesada, transform.position, transform.rotation);
        var rb = balaDelTanque.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * fuerza);
    }
}
