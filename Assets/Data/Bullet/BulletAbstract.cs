using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbstract : Main
{
    [SerializeField] protected BulletCtrl bullCtrl;
    public BulletCtrl BullCtrl { get=> bullCtrl;}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadDamegeRecei();
    }

    protected virtual void LoadDamegeRecei()
    {
        if (this.bullCtrl != null) return;
        this.bullCtrl = transform.parent.GetComponent<BulletCtrl>();

       
    }
}
