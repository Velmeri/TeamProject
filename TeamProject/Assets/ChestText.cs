using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestText : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite ChestOpened;
    public Sprite ChestClosed;
    public Sprite ChestOpenedText;
    public Sprite ChestClosedText;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ChestOpened)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            GameObject.Find("ChestText").GetComponent<SpriteRenderer>().sprite = ChestOpenedText;
        }
        else if (GameObject.Find("Chest").GetComponent<SpriteRenderer>().sprite == ChestClosed)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            GameObject.Find("ChestText").GetComponent<SpriteRenderer>().sprite = ChestClosedText;
        }
    }
}
