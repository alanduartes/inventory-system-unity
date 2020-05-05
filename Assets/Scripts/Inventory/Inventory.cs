using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    private IInventory inventory;
    public GameObject slotsContainer;
    public GameObject slot;
    private bool isOpen = false;

    void Awake()
    {
        inventory = new PlayerInventory();
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            OpenInventory();
        }
    }


    public void Add(GameObject item)
    {
        inventory.AddItem(item);
        UpdateSlots();
    }

    public void Remove(GameObject item)
    {
        Debug.Log("Teste");
        inventory.RemoveItem(item);
        UpdateSlots();
    }
    public void OpenInventory()
    {
        if (isOpen) {
            isOpen = false;
            this.transform.Rotate(0f, 90f, 0f, Space.Self);
        } else {
            this.transform.Rotate(0f, -90f, 0f, Space.Self);
            isOpen = true;
        }
    }

    private void UpdateSlots()
    {
        List<GameObject> listItems = inventory.GetInventory();
        int idx = 0;

        Instantiate(slot, slotsContainer.transform, false);

        foreach (Transform slot in slotsContainer.transform) {
            slot.transform.GetChild(0).GetComponent<Image>().sprite = listItems[idx].GetComponent<SpriteRenderer>().sprite;
            idx++;
        }
    }
}
