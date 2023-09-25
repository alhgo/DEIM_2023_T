using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float speed;
    float moveY;
    float moveX;


    // Start is called before the first frame update
    void Start()
    {

        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        //Desplazar un GameObject
        transform.Translate(Vector3.up * Time.deltaTime * speed * moveY);
        transform.Translate(Vector3.right * Time.deltaTime * speed * moveX);

        //transform.position += Vector3.forward * Time.deltaTime * speed * moveY;
        //transform.position += Vector3.right * Time.deltaTime * speed * moveX;
    }
}
