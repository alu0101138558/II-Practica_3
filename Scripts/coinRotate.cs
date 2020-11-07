using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotate : MonoBehaviour
{
    public float rotateSpeed;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime * rotateSpeed;
        transform.rotation = Quaternion.Euler(y, 0, y);
    }
}
