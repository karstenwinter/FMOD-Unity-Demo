using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            new Vector3
            (
                Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical")
            ) * speed);
    }
}
