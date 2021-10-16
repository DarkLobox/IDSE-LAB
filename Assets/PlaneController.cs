using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float mouseX;
    public float mouseY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(mouseX,mouseY,0) * Time.deltaTime;
    }
}
