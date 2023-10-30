using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PV_Player : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {


        other.CompareTag("Projectile");
        Destroy(other.gameObject);

        score++;
        Debug.Log(score + "player");

        if (score == 15)
        {
            Destroy(gameObject);
        }
    }
}
