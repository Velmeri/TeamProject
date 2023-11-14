using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FixedBox;
    public GameObject FixedBox2GO;
    public GameObject FixedBox3GO;
    public GameObject FixedBox4GO;
    public GameObject FixedBox5GO;
    public GameObject FixedBox6GO;
    public GameObject GatesGO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FixedBox.tag == "FB2" && FixedBox2GO.tag == "FB4" && FixedBox3GO.tag == "FB5" && FixedBox4GO.tag == "FB1" && FixedBox6GO.tag == "FB3")
        {
            GatesGO.SetActive(false);
        }
    }
}
