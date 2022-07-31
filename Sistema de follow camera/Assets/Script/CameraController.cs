using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //el array camera de abajo me aparece una advertencia ¿¿ que es lo que significa ??
    [SerializeField] public GameObject[] camera = {};

    int a = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //con este codigo se puede cambiar todas las camaras del array, da igual cuantas camaras hay en el array.
        //no sé si hay otra mejor forma de hacerlo
        if (Input.GetKeyUp(KeyCode.F))
        {
            for(int i = 0; i < camera.Length; i++)
            {
                camera[i].SetActive(false);
            }
            camera[a].SetActive(true);
            if(a < camera.Length-1)
            {
                a++;
            }
            else
            {
                a = 0;
            }
        }
    }
}
