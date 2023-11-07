using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Sprite GarbageNoKey;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == GarbageNoKey)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }
}
