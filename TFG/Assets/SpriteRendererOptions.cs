using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererOptions : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer render;
    void Start()
    {
        render = gameObject.GetComponent<SpriteRenderer>();
        render.receiveShadows = true;
        render.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.TwoSided;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
