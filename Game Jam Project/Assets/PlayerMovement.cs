using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public List<Vector3> v = new List<Vector3>();
    public float carSpeed = 1000000;
    private float time = 180f;
    private int indx;

    void Start()
    {
        indx = 0;
        transform.position = v[indx];
    }

    void Update()
    {
        MovePlayer();
        checkTime();
    }

    void checkTime()
    {
        time -= Time.deltaTime;
        if ( time <= 0 )
        {
            if ( indx < 3 )
            {
                indx++;
            } else
            {
                indx = 0;
            }

            transform.position = v[indx];
            time = 180f;
        }
    }

    void MovePlayer()
    {
        if (Input.GetKey("left"))
        {
            transform.position -= new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("right"))
        {
            transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey("down"))
        {
            transform.position -= new Vector3(0, carSpeed * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Vector3 currentPos = transform.position;
        if (col.gameObject.name == "Tilemap")
        {
            transform.position -= (transform.position - currentPos);
        }
    }
}