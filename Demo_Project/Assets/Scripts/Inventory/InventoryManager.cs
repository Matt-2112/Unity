using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{

    [Header("Inventory Info")]
    public PlayerInventory playerInventory;
    //[SerializeField] private GameObject Slot;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private GameObject useButton;

    public void SetTextAndButton(string description, bool active)
    {
        descriptionText.text = description;
        if (active)
        {
            useButton.SetActive(true);
        }
        else
        {
            useButton.SetActive(false);
        }
    }

    /*void MakeInventorySlot()
    {
        if (playerInventory)
        {
            for(int i = 0; i <playerInventory.myInventory.Count; i++)
            {
                InventorySlot newSlot = Instantiate(Slot, transform.position, transform.rotation).GetComponent<Slot>();
                newSlot.transform.SetParent(inventoryPanel.transform);
                newSlot.Setup(playerInventory.myInventory[i], this);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetTextAndButton("", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
