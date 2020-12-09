using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(spriteRenderer != null)
        {
            Color newColor = Color.Lerp(new Color(1f, 1f, 1f, 0.1f), new Color(1f, 1f, 1f, 0.6f), Mathf.PingPong(Time.time, 2));
            spriteRenderer.color = newColor;

        }
    }

}
