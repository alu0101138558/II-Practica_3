using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    private bool lightOn;
    public Light luz;
    // Start is called before the first frame update
    void Start()
    {
        lightOn = false;
        luz.enabled = lightOn;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            lightOn = !lightOn;
            if (lightOn)
            {
                luz.enabled = true;
            } else
            {
                luz.enabled = false;
            }
        }
    }
}
