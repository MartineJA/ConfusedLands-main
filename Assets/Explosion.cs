using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    [SerializeField] GameObject explosion = null;
    GameObject boom = null;
    [SerializeField] GameObject bombDropped;

    int score = 0;

    private void Start()
    {
        
        
        
    }
    // Update is called once per frame
    void Update()
    {
        if (score == 1)
        {
            Destroy(gameObject);
            boom = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(boom, 0.5f);
            Instantiate(bombDropped, transform.position, transform.rotation);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("Bullet");
        Destroy(other);
        score++;
    }
}
