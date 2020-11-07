using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDoor : MonoBehaviour
{
    // Start is called before the first frame update
    private float highDoor;
    private bool firstTry;
    public int numerCoinsToOpen;
    void Start()
    {
        firstTry = true;
        highDoor = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        SceneController.coinsToOpen += moveToUp;
    }

    private void moveToUp (int coins)
    {
        if (numerCoinsToOpen == coins && firstTry == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + highDoor, transform.position.z);
            firstTry = false;
        }
    }
}
