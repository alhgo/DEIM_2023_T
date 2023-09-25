using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform naveTransform;
    [SerializeField] float offsetY = 2f; 
    [SerializeField] float offsetZ = 4f;

    //public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.LookAt(naveTransform.position);
        transform.position = naveTransform.position + new Vector3(0f, offsetY, -offsetZ);    
        */
        // Define a target position above and behind the target transform
        //Vector3 targetPosition = naveTransform.TransformPoint(new Vector3(0, offsetY, -offsetZ));
        Vector3 targetPosition = naveTransform.position + new Vector3(0f, offsetY, -offsetZ);
        //https://docs.unity3d.com/ScriptReference/Vector3.SmoothDamp.html

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
