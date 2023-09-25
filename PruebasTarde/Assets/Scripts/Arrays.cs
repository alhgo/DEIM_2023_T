using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField] string[] saludos;

    // Start is called before the first frame update
    void Start()
    {
        //print(saludos.Length);
        //Bucle por los elementos del array
        for(int n = 0; n < saludos.Length; n++)
        {
            print(saludos[n]);
        }

        int i = Random.Range(0,saludos.Length);
        //Elemento al azar
        print("Al azar: " + saludos[i]);

        //print(saludos[]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
