using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Background : MonoBehaviour
{
    public Vector2 velocity;


    void LateUpdate()
    {
        GetComponent<Renderer>().material.mainTextureOffset = Time.time * velocity;
    }
}
