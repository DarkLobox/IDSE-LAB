using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Controller : MonoBehaviour
{
    public Text estado;
    public Text mensaje;
    public Text tiempo;
    private int segundos = 180;
    private bool win = false;
    private bool lose = false;

    private float playerSpeed = 5f;
    public Rigidbody rgb;
    private float jumpPower = 6.5f;
    private bool jump = false;
    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;
    private bool shoot = false;
    private int vida = 5;
 
    public Transform pistola;
    public GameObject bala;
    private float fuerza = 1200f;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        estado.text = "Vida: " + vida;
        Invoke("timer", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (segundos<=0 || vida<=0)
        {
            lose = true;
            mensaje.text = "PERDISTE XD";
        }

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
            //jump = true;
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
            //disparar();
            shoot = false;
        }
    }

    void disparar()
    {
        var balaDelJugador = Instantiate(bala, pistola.position, pistola.rotation);
        var rb = balaDelJugador.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * fuerza);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "objectVida")
        {
            vida++;
            estado.text = "Vida: " + vida;
        }
        if (collision.gameObject.tag == "objectDaño")
        {
            vida--;
            estado.text = "Vida: " + vida;
        }
        if (collision.gameObject.tag == "objectInicio")
        {
            transform.position = new Vector3(0, 0.5f, -17);
        }
        if (collision.gameObject.tag == "objectMeta")
        {
            win = true;
            transform.position = new Vector3(0, 0.5f, -17);
            mensaje.text = "¡GANASTE!";
        }

        if (collision.gameObject.tag == "balaLigera")
        {
            vida = vida - 1;
        }
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void timer()
    {
        if (segundos > 0 && (!win || !lose) )
        {
            segundos--;
            int m = segundos / 60;
            int s = segundos % 60;
            if (m<10 && s<10)
            {
                tiempo.text = "0" + m + ":0" + s;
            }
            else if (m<10)
            {
                tiempo.text = "0" + m + ":" + s;
            }
            else if (s<10)
            {
                tiempo.text = m + ":0" + s;
            }
            Invoke("timer", 1f);
        }
    }
}
