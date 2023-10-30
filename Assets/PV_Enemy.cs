using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PV_Enemy : MonoBehaviour
{
    int score;
    [SerializeField] GameObject explosionParticles;
    [SerializeField] GameObject bombDropped;




    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 5)
        {
            Debug.Log("enemy is dead");
            Destroy(gameObject);
            GameObject boom = Instantiate(explosionParticles, transform.position, transform.rotation);
            Destroy(boom, 0.5f);
            Instantiate(bombDropped);

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with enemy");
    }
    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("Bullet");
        
        Destroy(other.gameObject);
        
        score++;
        Debug.Log(score + "enemy");
    }
       

    


}
