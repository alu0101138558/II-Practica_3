using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_B : MonoBehaviour
{
    private int counter;
    private Renderer colorPlayer;
    // Start is called before the first frame update
    void Start()
    {
        colorPlayer = GetComponent<Renderer>();
        SceneController.colorB += changeColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increaseCounter ()
    {
        counter++;
        Debug.Log("El valor actual del contador es: " + counter);
    }

    public void changeColor ()
    {
        colorPlayer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
