using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 30;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer ClosetRenderer;
    public GameObject GameOverUI;
    public Sprite ClosedCloset;
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            if (GameObject.Find("Closet").GetComponent<SpriteRenderer>().sprite == ClosedCloset || GameObject.Find("Closet2").GetComponent<SpriteRenderer>().sprite == ClosedCloset)
            {
                timeRemaining = 30;
                spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
            }
            else
            {
                timeRemaining -= Time.deltaTime;
                if (timeRemaining == 60) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
              /*  else if (timeRemaining < 60 && timeRemaining > 50) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
                else if (timeRemaining <= 50 && timeRemaining > 40) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
                else if (timeRemaining <= 40 && timeRemaining > 30) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
                else if (timeRemaining <= 30 && timeRemaining > 20) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }*/
                else if (timeRemaining <= 30 && timeRemaining > 25) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
                else if (timeRemaining <= 25 && timeRemaining > 20) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
                else if (timeRemaining <= 20 && timeRemaining > 15) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.1f); }
                else if (timeRemaining <= 15 && timeRemaining > 10) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
                else if (timeRemaining <= 10 && timeRemaining > 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.3f); }
                else if (timeRemaining == 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 1f); }
            }
            /* timeRemaining -= Time.deltaTime;
             if (timeRemaining == 60) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
             *//*else if (timeRemaining < 60 && timeRemaining > 50) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
             else if (timeRemaining <= 50 && timeRemaining > 40) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
             else if (timeRemaining <= 40 && timeRemaining > 30) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
             else if (timeRemaining <= 30 && timeRemaining > 20) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }*//*
             else if (timeRemaining <= 30 && timeRemaining > 25) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
             else if (timeRemaining <= 25 && timeRemaining > 20) { spriteRenderer.color = new Color(1f, 1f, 1f, 0f); }
             else if (timeRemaining <= 20 && timeRemaining > 15) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.1f); }
             else if (timeRemaining <= 15 && timeRemaining > 10) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.2f); }
             else if (timeRemaining <= 10 && timeRemaining > 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 0.3f); }
             else if (timeRemaining == 0) { spriteRenderer.color = new Color(1f, 1f, 1f, 1f); }*/
        }
        else
        {
            GameOverUI.SetActive(true);
            //Time.timeScale = 0f;
        }

    }
}
