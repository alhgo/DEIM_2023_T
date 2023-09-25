using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedRotation;
    float moveY;
    float moveX;

    //Valores para el suavizado en la rotacion
    [SerializeField] float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    Vector3 currentRot;

    // Start is called before the first frame update
    void Start()
    {

        speed = 5f;
        speedRotation = 360f;
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        //Desplazar un GameObject
        Vector3 despl = Vector3.up * Time.deltaTime * speed * moveY;
        transform.Translate(despl,Space.World);
        //transform.position += Vector3.forward * Time.deltaTime * speed * moveY;
        transform.position += Vector3.right * Time.deltaTime * speed * moveX;
        // transform.Translate(Vector3.right * Time.deltaTime * speed * moveX);

        //transform.Rotate(Vector3.forward * Time.deltaTime * -speedRotation * moveX);

        //transform.rotation = Quaternion.Euler(Vector3.forward * -60f * moveX);
        Vector3 vectorRot = Vector3.forward * -60f * moveX;
        currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref velocity, smoothTime);
        transform.eulerAngles = currentRot;

        
    }
}
