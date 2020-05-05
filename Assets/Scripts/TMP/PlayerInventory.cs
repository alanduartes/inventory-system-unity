using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : IInventory
{

    private List<GameObject> inventory;

    public PlayerInventory()
    {
        inventory = new List<GameObject>();
    }

    public List<GameObject> GetInventory()
    {
        return inventory;
    }

    public void AddItem(GameObject item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(GameObject item)
    {
        inventory.Remove(item);
    }
}
