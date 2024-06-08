using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ExplosionSpawn : Spawner
{

    public static int score;
    private static ExplosionSpawn instance;
    ExplosionSpawn explosionSpawn = ExplosionSpawn.Instance;
    void HandleExplosionSpawn()
    {
        // Increment the score (you can adjust the value as needed)
        score += 10; // Increase by 10 points for each explosion
    }
    public static ExplosionSpawn Instance { get => instance; }

    public static string Exp1 = "Explosion";
    public static string Impact1 = "Impact";
    protected override void Awake()
    {
        base.Awake();
        if (ExplosionSpawn.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
        ExplosionSpawn.instance = this;
    }


}
