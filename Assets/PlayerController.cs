using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;
    public Rigidbody rgb;
    public float jumpPower = 6.5f;
    private bool jump = false;
    private bool rightRotation = false;
    private bool leftRotation = false;
    private bool wKey = false;
    private bool sKey = false;
    private bool aKey = false;
    private bool dKey = false;

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
            wKey = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            sKey = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            aKey = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dKey = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightRotation = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftRotation = true;
        }
    } 

    void FixedUpdate()
    {
        if (wKey)
        {
            transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
            wKey = false;
        }

        if (sKey)
        {
            transform.position += Vector3.back * playerSpeed * Time.deltaTime;
            sKey = false;
        }

        if (aKey)
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            aKey = false;
        }

        if (dKey)
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
            dKey = false;
        }

        if (jump)
        {
            rgb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            jump = false;
        }

        if (rightRotation)
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * 20);
            rightRotation = false;
        }

        if (leftRotation)
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            transform.Rotate(Vector3.down * 20);
            leftRotation = false;
        }
    }

}
