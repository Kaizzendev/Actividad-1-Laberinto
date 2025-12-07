using System;
using UnityEngine;

public class TextureStrectch : MonoBehaviour
{
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        Vector3 scale = transform.localScale;
        renderer.material.mainTextureScale = new Vector2(scale.x, scale.y);
    }

}
