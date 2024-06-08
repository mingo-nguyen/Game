using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SphereCollider))]
[RequireComponent (typeof(Rigidbody))]
public class BulletImpart : BulletAbstract
{

    [SerializeField] protected SphereCollider sphere;
    [SerializeField] protected Rigidbody rigibody;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadSphere();
        LoadRigi();
    }

    protected virtual void LoadSphere()
    {
        if (sphere != null) return;
        sphere = GetComponent<SphereCollider>();
        sphere.isTrigger = true;
        sphere.radius = 0.05f;

    }

    protected virtual void LoadRigi()
    {
        if (rigibody != null) return;
        rigibody = GetComponent<Rigidbody>();
        rigibody.isKinematic = true;

    }

    protected virtual void OnTriggerEnter(Collider orther)
    {
        this.bullCtrl.DamageSender.Send(orther.transform);
        //createImpact(orther);
    }

    //protected virtual void createImpact(Collider orther)
    //{
    //    string fxName = GetImpact();

    //    Vector3 hitPos = transform.position;
    //    Quaternion hitRot = transform.rotation;
    //  Transform fxImpact =  ExplosionSpawn.Instance.Spawn(fxName, hitPos, hitRot);
    //    fxImpact.gameObject.SetActive(true);

    //}

    //protected virtual string GetImpact()
    //{
    //   return ExplosionSpawn.Impact1;
    //}
}
