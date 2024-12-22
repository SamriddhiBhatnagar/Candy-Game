using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public AudioSource touchsound;
    public float keyinput;


    // Start is called before the first frame update
    void Start()
    {
        touchsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*10, ForceMode.VelocityChange);
        }


        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(keyinput, GetComponent<Rigidbody>().velocity.y, 0);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
            touchsound.Play();
    }
}
