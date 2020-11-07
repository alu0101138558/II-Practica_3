using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_A : MonoBehaviour
{
    private float distanceMedium;
    private int displacement;
    public GameObject objetA;
    // Start is called before the first frame update
    void Start()
    {
        SceneController.transformA += actuateObject;
        displacement = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saySomething ()
    {
        Debug.Log("Ayyy que daño!!!");
    }

   private void actuateObject (float positionX, float positionZ, float distanceMedium)
    {
        if (mediumDistance(positionX, positionZ, distanceMedium))
        {
            this.transform.position = new Vector3(this.transform.position.x + displacement, this.transform.position.y, 
                                                  this.transform.position.z + displacement);
        } else
        {

            if (this != null)
            {
                Destroy(this.gameObject);
            }
        }
    }


    public bool mediumDistance (float positionX, float positionZ, float distanceMedium)
    {
        float distance = Mathf.Sqrt(Mathf.Pow((positionX - this.transform.position.x), 2) + Mathf.Pow((positionZ - this.transform.position.z), 2));
        if (distance >= distanceMedium)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
