using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{

    //0.0 Idle
    //1.0 Right
    //-1.0 Left
    float state;

    public float speed = 3.0f;
    float timer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        state = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0.0f)
        {
            if (Random.Range(0, 100) < 20)
            {
                state = 0.0f;
            }
            timer = 5.0f;
        }
        else
            timer -= Time.deltaTime;

        transform.position += new Vector3(state * speed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
            state = -1.0f;
        if (other.gameObject.layer == 9)
            state = 1.0f;
    }
}
