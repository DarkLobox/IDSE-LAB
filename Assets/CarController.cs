using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float playerSpeed = 2f;
    public Rigidbody rgb;
    private bool upKey = false;
    private bool downKey = false;

    public Transform SM_PolygonCity_Veh_Car_Small_Wheel_fl;
    public Transform SM_PolygonCity_Veh_Car_Small_Wheel_fr;
    public Transform SM_PolygonCity_Veh_Car_Small_Wheel_rl;
    public Transform SM_PolygonCity_Veh_Car_Small_Wheel_rr;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            upKey = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            downKey = true;
        }
    }

    private void FixedUpdate()
    {
        if (upKey)
        {
            transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
            SM_PolygonCity_Veh_Car_Small_Wheel_fl.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_fr.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_rl.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_rr.Rotate(Vector3.right * -5);
            upKey = false;
        }

        if (downKey)
        {
            transform.position += Vector3.back * playerSpeed * Time.deltaTime;
            SM_PolygonCity_Veh_Car_Small_Wheel_fl.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_fr.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_rl.Rotate(Vector3.right * -5);
            SM_PolygonCity_Veh_Car_Small_Wheel_rr.Rotate(Vector3.right * -5);
            downKey = false;
        }
    }
}
