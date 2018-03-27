using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 5.0f;
    private float zMax = 3f;
    private float zMin = -3f; //starting position
    private float angle = 20f;
    
    private int direction = 1; //positive to start 
    
    // Update is called once per frame
    void Update()
    {
        //float zNew = transform.localPosition.z + direction * speed * Time.deltaTime;
        float zNew = transform.localPosition.z + direction * speed * Time.deltaTime * Mathf.Sin(20);
        float xNew = transform.localPosition.x + speed * Time.deltaTime * Mathf.Sin(angle);

        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1; //Changes the direction of movement to negative
            angle = angle * -1;
        }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
        }
      


        transform.localPosition = new Vector3(xNew, .06f, zNew);
    }
}
