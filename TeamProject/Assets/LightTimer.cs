using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    float Alpha = 1f;
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public float timeRemaining = 60;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining == 60) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
            else if (timeRemaining < 60 && timeRemaining > 50) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
            else if (timeRemaining <= 50 && timeRemaining > 40) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
            else if (timeRemaining <= 40 && timeRemaining > 30) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.35f); }
            else if (timeRemaining <= 20 && timeRemaining > 10) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.60f); }
            else if (timeRemaining <= 10 && timeRemaining > 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.75f); }
            else if (timeRemaining >= 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 1f); }
        }
    }
}
