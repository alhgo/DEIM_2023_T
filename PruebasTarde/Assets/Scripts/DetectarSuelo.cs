using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarSuelo : MonoBehaviour
{

    [SerializeField] bool isGrounded = false;

    CharacterController characterController;

    [SerializeField] Vector3 despl;
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        despl.z = Input.GetAxis("Vertical") * speed;
        despl.x = Input.GetAxis("Horizontal") * speed;

        isGrounded = characterController.isGrounded;

        characterController.SimpleMove(despl);
        
        /*
        if(!isGrounded )
         characterController.SimpleMove(Vector3.down * 9.8f);
        */
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    void Saltar()
    {
        print("Saltar");
        despl.y += 100f;
    }


    void Gravity()
    {
        despl.y -= 9.8f * Time.deltaTime;
        
        if(characterController.isGrounded && despl.y < 0)
        {
            despl.y = 0;
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6) {
            isGrounded = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }
    */
}
