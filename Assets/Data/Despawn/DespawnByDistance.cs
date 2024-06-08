using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField ] protected float LimitDistance = 30f;
    [SerializeField] protected float countDistance = 0f;
    [SerializeField] protected Camera camera;


    protected virtual void FixedUpdate() 
        {
        this.Despawning();
        }

    protected override void LoadComponent()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.camera != null) return;
        this.camera = Transform.FindObjectOfType<Camera>();

    }

    protected virtual void Despawning()
    {
        if(!CanDespawn()) return;
        DespawnObject();
    }

    public virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }
    protected override bool CanDespawn()
    {
        this.countDistance = Vector3.Distance(transform.position, camera.transform.position);
        if (this.countDistance > LimitDistance) return true;
        return false;
    }
}
