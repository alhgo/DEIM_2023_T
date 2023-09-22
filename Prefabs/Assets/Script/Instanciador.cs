using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{

    [SerializeField] int amount = 10;
    
    Vector3 initPos = new Vector3(0f, 0f, 4f);
    Vector3 despl = new Vector3(2f, 2f, 2f);

    [SerializeField] GameObject nave;
    [SerializeField] Transform padre;
    




    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < amount; i++)
        {
            initPos = initPos + despl;
            Instantiate(nave, initPos, Quaternion.identity);
            print(initPos);
        }
        
    }


}
