using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Arrow : MonoBehaviour


{
    public float speed = 4.5f;
    public float delai = 2f;
    public ParticleSystem effetDeParticule;


    void Start()
    {
        Destroy(gameObject, delai);
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * -1 * Time.deltaTime * speed;
    }

    private void OnDestroy()
    {
        Instantiate(effetDeParticule, transform.position, transform.rotation);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Untagged ")
        {

            Destroy(gameObject);
        }

    }
       
}