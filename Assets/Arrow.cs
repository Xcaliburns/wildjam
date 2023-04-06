using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 4.5f;



    void Start()
    {
        Invoke("DestroyObject", 4f);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        Instantiate(destroyEffect, objectToDestroy.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
