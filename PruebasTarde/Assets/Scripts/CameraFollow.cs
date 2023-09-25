using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform naveTransform;
    [SerializeField] float offsetY = 2f; 
    [SerializeField] float offsetZ = 4f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(naveTransform.position);
        transform.position = naveTransform.position + new Vector3(0f, offsetY, -offsetZ);    
    }
}
