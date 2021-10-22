using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controller : MonoBehaviour
{
    private float playerSpeed = 5f;
    public Rigidbody rgb;
    private float jumpPower = 6.5f;
    private bool jump = false;
    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;
    private bool shoot = false;

    public Transform pistola;
    public GameObject bala;
    private float fuerza = 1200f;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            up = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            down = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            shoot = true;
        }
    }

    private void FixedUpdate()
    {
        if (up)
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
            up = false;
        }

        if (down)
        {
            transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
            down = false;
        }

        if (left)
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            transform.Rotate(Vector3.down * 2);
            left = false;
        }

        if (right)
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * 2);
            right = false;
        }

        if (jump)
        {
            rgb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            jump = false;
        }

        if (shoot)
        {
            disparar();
            shoot = false;
        }
    }

    void disparar()
    {
        var balaDelJugador = Instantiate(bala, pistola.position, pistola.rotation);
        var rb = balaDelJugador.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * fuerza);
    }

}
