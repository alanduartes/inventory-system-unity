using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInventory
{
    List<GameObject> GetInventory();
    void AddItem(GameObject item);
    void RemoveItem(GameObject item);
}
