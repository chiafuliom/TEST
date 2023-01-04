using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{

    private Transform player;

    //public float minX, maxX;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player !=null && GameObject.Find("Player").GetComponent<PlayerScript22>().isAlive)
        {
            Vector3 temp = transform.position;
            temp.x = player.position.x;
            transform.position = temp;
        }
    }
}
//CameraFollow

/*
if (GameObject.Find("Player").GetComponent<PlayerScript22>().facingRight)
{
    rb.AddForce(trasform.right * speed);
}
else
{
    rb.AddForce(-trasform.right * speed);
}
*/