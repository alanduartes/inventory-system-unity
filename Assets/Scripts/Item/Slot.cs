﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public void Remove()
    {
        Inventory.instance.Remove(gameObject);
    }
}
