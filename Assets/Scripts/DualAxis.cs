using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxis : MonoBehaviour
{
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float yPos = v * range;

        transform.position = new Vector3(xPos, yPos, 0);
        Debug.Log("Horizontal: " + h.ToString("F2") +"\nVertical: " + v.ToString("F2"));
    }
}
