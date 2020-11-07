using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public Object_A objetoA;
    public Object_B objetoB;
    private bool colisionWithB;
    private int power;
    private int counterCoins;
    // Start is called before the first frame update
    void Start()
    {
        SceneController.shootPlayer += shoot;
        SceneController.detectB += colisionB;
        SceneController.powerLowerPlayer += decreasePower;
        SceneController.coinsPlayer += coinsRecolected;
        power = 10;
        colisionWithB = false;
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ObjectA")
        {
            objetoB.increaseCounter();
        }
        else if (collision.gameObject.tag == "ObjectB")
        {
            objetoA.saySomething();
            colisionWithB = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            counterCoins++;
        }
    }

    private bool shoot ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            return true;
        } else
        {
            return false;
        }
    }

    private int coinsRecolected ()
    {
        return counterCoins;
    }

    private void decreasePower ()
    {
        if (power > 0)
        {
            power--;
            Debug.Log("El poder actual del jugador es: " + power);
        } else
        {
            Debug.Log("El poder del jugador no puede bajar más de " + power);
        }
    }
    
    private bool colisionB ()
    {
        if (colisionWithB)
        {
            colisionWithB = false;
            return true;
        } else
        {
            return false;
        }
    }
}
