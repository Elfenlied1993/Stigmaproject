﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManagaer : MonoBehaviour {

    #region Singleton
    public static EquipmentManagaer instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    Equipment[] currentEquipment;
    void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlots];
    }

    public void Equip (Equipment newItem)
    {
        int slotIndex = (int)newItem.equipSlot;
        currentEquipment[slotIndex] = newItem;
    }
}
