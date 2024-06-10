using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAbstract : Main
{
    [SerializeField] protected Inventory inventory;
    public Inventory Inventory { get => inventory; }

    protected override void LoadComponent()
    {
        base.LoadComponent();
       LoadInventory();
    }

    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();


    }
}
