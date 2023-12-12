using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBoxPuzzle : MonoBehaviour
{
    string code = "41623";
    public int BoxCount = 6;
    public GameObject FixedBox;
    public GameObject Gates;
    public Sprite BoxFalse;
    public Sprite BoxTrue;
    bool CollisionHappening;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer FixedBox2;
    public SpriteRenderer FixedBox3;
    public SpriteRenderer FixedBox4;   
    public SpriteRenderer FixedBox5;
    public SpriteRenderer FixedBox6;
    public GameObject FixedBox2GO;
    public GameObject FixedBox3GO;
    public GameObject FixedBox4GO;
    public GameObject FixedBox5GO;
    public GameObject FixedBox6GO;
    public Sprite DoorOpen;
    public SpriteRenderer DoorSpriteRenderer;

    public bool Assigned=false;
    public bool ifCanCheck;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = FixedBox.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CollisionHappening==true && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = BoxTrue;
            if (CheckBoxNumber() == 1) { FixedBox.tag = "FB1"; Assigned = true; };
            if (CheckBoxNumber() == 2) { FixedBox.tag = "FB2"; Assigned = true; };
            if (CheckBoxNumber() == 3) { FixedBox.tag = "FB3"; Assigned = true; };
            if (CheckBoxNumber() == 4) { FixedBox.tag = "FB4"; Assigned = true; };
            if (CheckBoxNumber() == 5) { FixedBox.tag = "FB5"; Assigned = true; };
            if (CheckBoxNumber() == 6) { FixedBox.tag = "FB6"; Assigned = true; };
            if (ifCanCheck)
            {
                if(FixedBox.tag=="FB2" && FixedBox2GO.tag == "FB4" && FixedBox3GO.tag == "FB5" && FixedBox4GO.tag == "FB1" && FixedBox6GO.tag == "FB3")
                {
                    GameObject.Find("Door").GetComponent<SpriteRenderer>().sprite = DoorOpen;
                    DoorSpriteRenderer.sprite= DoorOpen;
                }
                else
                {
                    if(CheckBoxNumber() == 6)
                    {
                        FixedBox.tag = "Untagged";
                        FixedBox2GO.tag = "Untagged";
                        FixedBox3GO.tag = "Untagged";
                        FixedBox4GO.tag = "Untagged";
                        FixedBox6GO.tag = "Untagged";
                        spriteRenderer.sprite = BoxFalse;
                        FixedBox2.sprite = BoxFalse;
                        FixedBox3.sprite = BoxFalse;
                        FixedBox4.sprite = BoxFalse;
                        FixedBox5.sprite = BoxFalse;
                        FixedBox6.sprite = BoxFalse;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        CollisionHappening = true;
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        CollisionHappening = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        CollisionHappening = false;
    }
    public int CheckBoxNumber()
    {
        int Number = 0;
        if (FixedBox2.sprite == BoxTrue) { Number++; };
        if (FixedBox3.sprite == BoxTrue) { Number++; };
        if (FixedBox4.sprite == BoxTrue) { Number++; };
        if (FixedBox5.sprite == BoxTrue) { Number++; };
        if (FixedBox6.sprite == BoxTrue) { Number++; };
        return Number+1;
    }
}
