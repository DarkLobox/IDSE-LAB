using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonLigeroController : MonoBehaviour
{
    public GameObject balaLigera;
    public float delayInicial = 1f;
    public float delayEntreObjetos = 1f;
    private float fuerza = 400f;
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
        var balaDelTanque = Instantiate(balaLigera, transform.position, transform.rotation);
        var rb = balaDelTanque.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * fuerza);
    }
}
