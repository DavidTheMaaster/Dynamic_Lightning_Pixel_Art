using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.position += new Vector3(1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
        }
    }
}
