using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pruebas : MonoBehaviour
{
    bool alive = true;
    int lifes = 5;
    float shield = 100f; //Escudo de vida

    //Solo para valientes
    [SerializeField] float points = 0;
    float speed;


    // Start is called before the first frame update
    void Start()
    {

        UpdateUI();
        //Invoke("UpdateUI",4f);

        //Impacto();
        //Invoke("Impacto", 2f);

    }

    // Update is called once per frame
    void Update()
    {
        DetectarImpacto();
        SumarPuntos();  
        

    }

    void DetectarImpacto()
    {
        if (Input.GetKeyUp(KeyCode.Space) && alive == true)
        {
            Impacto();
        }
    }

    void SumarPuntos()
    {
        if (alive == true)
            points += Time.time;
    }

    void UpdateUI()
    {

        print("Vidas: " + lifes);
        print("Escudo: " + shield);
    }

    void Impacto()
    {
        float damage = Random.Range(5f,30f);

        shield -= damage;


        print("Me han impactado con un daño de " + damage);

        if(shield < 0)
        {
            RestarVida();
        }
        else if(shield <= 5)
        {
            print("Estás casi muerto");
            UpdateUI();
        }
        else
        {
            UpdateUI();
        }


    }

    void RestarVida()
    {
        //lifes = lifes - 1;
        lifes--;
        if (lifes <= 0)
        {
            Morir();
        }
        else
        {
            shield = 100f;
            UpdateUI();

            ResaltarVidas();

        }
        
    }

    void Morir()
    {
        print("GAME OVER");
        alive = false;  

    }

    void ResaltarVidas()
    {
        /*
        int n = lifes;
        while(n > 0)
        {
            n--;
        }
        */
        /*
        int n = 1;
        while (n <= lifes)
        {
            n++;
        }
        */

        for(int n = 1; n <= lifes; n++ )
        {
            print("Bucle por la vida " + n);
        }
    }

}
