using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosArco : MonoBehaviour
{
    public List<GameObject> objetos = new List<GameObject>();
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0;i<objetos.Count;i++)
        {
            if (objetos[i]==null)
            {
                objetos.RemoveAt(i);
            }
        }
        if (objetos.Count == 0)
        {
            texto.text = "GANASTE";
        }
    }
}
