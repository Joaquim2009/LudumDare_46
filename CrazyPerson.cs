using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyPerson : MonoBehaviour
{
    public float maxForce = 10;
    void OnCollisionEnter(Collision coll)
    {
        if(coll.relativeVelocity.magnitude >= maxForce && coll.gameObject.tag == "Ground")
        {
            GameManager.ReloadLevel();
        }

    }
}
