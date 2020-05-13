using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Animator animator;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.position += new Vector3(1.0f * speed, 0.0f, 0.0f) * Time.deltaTime;
            animator.SetTrigger("WALK");
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
        }
        else if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-1.0f * speed, 0.0f, 0.0f) * Time.deltaTime;
            animator.SetTrigger("WALK");
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));

        }
        else
        {
            animator.SetTrigger("IDLE");    
        }
    }
}
