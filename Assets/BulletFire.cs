using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{

    //le gameobject utilisé pour le projectile
    public GameObject bulletPrefab;
    //un transform utilisé pour localiser l'endroit d'apparition du projectile
    public Transform newBulletPositionTransform;
    //un transform pour regrouper les projectiles ensemble
    public Transform newBulletGroupTransform;
    
    float timeBetweenShots = 0.5f;
    float nextShot = 0.0f;
  

    public GameObject bomb;
    public Transform bombOrigin;
    public Transform bombTrash;


    private void Awake()
    {
        
    }


    void Update()
    {
        if (Time.time > nextShot && Input.GetKeyDown(KeyCode.Space)) 
        
        {
            nextShot = Time.time + timeBetweenShots;
            FireBullet();         
        }


        
        if(Time.time > nextShot && Input.GetKeyDown(KeyCode.E))
        {
            nextShot = Time.time + timeBetweenShots;
            FireBomb();

        }

    }

    void FireBullet()
    {
        
            #region COURS
            //Debug.Log("Shoot !");

            //1 création du clone
            GameObject newBulletRef = Object.Instantiate(bulletPrefab);

            //2 le parent est un transform qui sera utilisé pour la position
            newBulletRef.transform.parent = newBulletPositionTransform;

            //3 la position est mise à 0 0 0, par rapport à son parent
            //localPosition est la position relative au parent
            newBulletRef.transform.localPosition = Vector3.zero;

            //3.5  on s'aligne par rapport au parent
            newBulletRef.transform.rotation = transform.rotation;

            //4 on enlève le parent pour ne plus dans le "player"
            //(sinon le projectile bouge en même temps que le parent)
            //newBulletRef.transform.parent = newBulletGroupTransform;
            #endregion
        

    }
    void FireBomb()
    {      
            #region PERSO
            //Debug.Log("Explosion");

            GameObject bombClone = Object.Instantiate(bomb);

            bombClone.transform.parent = bombOrigin;
            bombClone.transform.localPosition = Vector3.zero;
            bombClone.transform.rotation = transform.rotation;

            //bombClone.transform.parent = bombTrash;
            #endregion
    }


}