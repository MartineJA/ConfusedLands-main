using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PV_Wall : MonoBehaviour
{
    int score;
    [SerializeField] GameObject explosionDoor;
    


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 2)
        {

            Destroy(gameObject);
            GameObject boom = Instantiate(explosionDoor, transform.position, transform.rotation);
            Destroy(boom, 0.5f);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.CompareTag("Bomb");
        score++;
        Debug.Log(score + "wall");


        other.CompareTag("Projectile");
        Destroy(other.gameObject);


    }
}
