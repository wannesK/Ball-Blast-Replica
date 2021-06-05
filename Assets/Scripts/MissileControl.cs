using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour
{
    public GameObject missile;

    public float delay = 0.3f;
    private float fireTime;

    void Update()
    {
        FireMissile();
    }

    private void FireMissile()
    {
        fireTime += Time.deltaTime;

        if (fireTime >= delay)
        {
            Instantiate(missile, transform.position, Quaternion.identity, transform);
            fireTime = 0f;
        }
    }   
}
