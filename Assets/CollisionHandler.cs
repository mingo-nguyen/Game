using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionHandler : MonoBehaviour
{
    // Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the "Stone" object
        if (collision.gameObject.name == "Stone")
        {
            // Perform game over logic here
            Debug.Log("Game over!");
        }
    }
    
}