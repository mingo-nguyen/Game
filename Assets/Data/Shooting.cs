using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected bool isShooting = false;
    //[SerializeField] protected Transform bullet;
    [SerializeField] protected float Delay = 2.0f;
    [SerializeField] protected float time=0f;
    
    private void Update()
    {
        IsShooting();
        Shoot();
    }

    protected virtual void Shoot()
    {
        if (!isShooting) return;

        time += Time.fixedDeltaTime;
        if (time < Delay) return;
        time = 0f;
        UnityEngine.Vector3 spawnPos = transform.position;
        UnityEngine.Quaternion spawnRot = transform.parent.rotation;
        //spawnRot.z = 90;
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bulletOne, spawnPos, spawnRot);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
    }

    protected virtual bool IsShooting()
    {
        this.isShooting = SingletonMouse.Instance.Onfight == 1;
        return this.isShooting;
    }

}
