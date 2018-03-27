using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed = 5.0f;
    private float zMax = 7.8f;
    private float zMin = -7.8f; //starting position
    private int direction = 1; //positive to start 
    
	// Update is called once per frame
	void Update ()
    {
        float zNew = transform.localPosition.z + direction * speed * Time.deltaTime;

        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1; //Changes the direction of movement to negative
        }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
        }

        transform.localPosition = new Vector3(14.45f, .06f, zNew);
	}
}
