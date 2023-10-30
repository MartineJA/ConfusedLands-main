using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject projectile;
    public Transform projectileOrigin;

    float fireRate = 0.8f;
    float nextFire = 0f;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        


        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject projectileClone = Object.Instantiate(projectile);

            projectileClone.transform.parent = projectileOrigin;
            projectileClone.transform.localPosition = Vector3.zero;
            projectileClone.transform.rotation = transform.rotation;

        }

    }
}
    