using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            //Memuevo un metro a la derecha en cada fotograma
            transform.position += Vector3.right * 2;
            Instantiate(obstacle, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
