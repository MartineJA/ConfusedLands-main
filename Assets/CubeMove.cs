using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    #region VARIABLES

    float speed = 8f;
    int angle = 360;




    #endregion

    public GameObject mainCamera01;
    public GameObject mainCamera02;
    public GameObject mainCamera00;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Awake()
    {
        
    }

    private void FixedUpdate()
    {   // on peut pas mettre ci-dessous ailleurs:
        Rigidbody rb = GetComponent<Rigidbody>();
        

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        


        if (direction == Vector3.zero)
        {
            return;
        }

        Quaternion quaternion = Quaternion.LookRotation(direction);
        quaternion = Quaternion.RotateTowards(transform.rotation, quaternion, angle * speed * Time.fixedDeltaTime);

        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        rb.MoveRotation(quaternion);
        

        Debug.DrawRay(transform.position, direction * 10, Color.red);
    }


    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OpenDoor01"))
        {
            mainCamera01.SetActive(true);
            mainCamera00.SetActive(false);
        }
        if (other.CompareTag("OpenDoor02"))
        {
            mainCamera02.SetActive(true);
            mainCamera00.SetActive(false);
        }
    }
}
