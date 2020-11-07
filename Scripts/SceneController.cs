using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate bool detectShoot();
public delegate void modificObjectA(float positionX, float positionZ, float distanceMedium);
public delegate bool detectColisionB();
public delegate void decreasePow();
public delegate void changeColorB();
public delegate int coinsRecolected();
public delegate void numberToCoinsOpen(int coins);
public class SceneController : MonoBehaviour
{
    public static SceneController controller;
    public static event detectShoot shootPlayer;
    public static event modificObjectA transformA;
    public static event detectColisionB detectB;
    public static event decreasePow powerLowerPlayer;
    public static event changeColorB colorB;
    public static event coinsRecolected coinsPlayer;
    public static event numberToCoinsOpen coinsToOpen;
    public GameObject player;
    public float distanceMedium;
    // Start is called before the first frame update
    void Start()
    {
        distanceMedium = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootPlayer())
        {
            transformA(player.transform.position.x, player.transform.position.z, distanceMedium);
        } else if (detectB())
        {
            colorB();
            powerLowerPlayer();
        }
        coinsToOpen(coinsPlayer());
    }

    private void Awake()
    {
        if (controller == null)
        {
            controller = this;
            DontDestroyOnLoad(this);
        } else if (controller != this)
        {
            Destroy(gameObject);
        }
    }
}
