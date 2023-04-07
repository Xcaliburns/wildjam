using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject projectile;
    public Transform positionDeDepart;
    public float intervalle = 2.0f;

    void Start()
    {
        InvokeRepeating("SpawnFleche", 2.0f, intervalle);
    }

    void SpawnFleche()
    {
        Vector3 positionRelative = positionDeDepart.localPosition;
        Vector3 positionAbsolue = positionDeDepart.parent.TransformPoint(positionRelative);
        Instantiate(projectile, positionAbsolue, Quaternion.identity);
    }
}
