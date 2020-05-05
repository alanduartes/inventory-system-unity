using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private GameObject inventory;

    void OnMouseDown()
    {
        inventory = GameObject.Find("Inventory");
        inventory.GetComponent<Inventory>().Add(gameObject);
    }
}
