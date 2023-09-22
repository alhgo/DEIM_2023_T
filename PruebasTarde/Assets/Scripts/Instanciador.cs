using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 10f);
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
