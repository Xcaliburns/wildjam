using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject projectile;
    public Transform positionDeDepart;
    public float intervalle = 2.0f;
    public ParticleSystem Particles;

    void Start()
    {
        
        InvokeRepeating("SpawnFleche", 2.0f, intervalle);
    }

    void SpawnFleche()
    {
        Instantiate(Particles, transform.position, transform.rotation);
        Vector3 positionRelative = positionDeDepart.localPosition;
        Vector3 positionAbsolue = positionDeDepart.parent.TransformPoint(positionRelative);
        Instantiate(projectile, positionAbsolue, Quaternion.identity);
    }
}
