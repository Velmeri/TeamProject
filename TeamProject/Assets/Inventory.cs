using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryUI;
    // Start is called before the first frame update
    void Start()
    {
        InventoryUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (InventoryUI.activeSelf)
            {
                InventoryUI.SetActive(false);
            }
            else
            {
                InventoryUI.SetActive(true);
            }
        }
    }
}
