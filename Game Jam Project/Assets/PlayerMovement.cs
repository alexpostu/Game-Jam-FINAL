using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public List<Vector3> v = new List<Vector3>();
    public float carSpeed = 1000000;
    private float time = 180f;

    void Start()
    {
        int indx = randomise();
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
            int indx = randomise();
            transform.position = v[indx];

            time = 180f;
        }
    }

    int randomise()
    {
        System.Random rnd = new System.Random();
        int indx = rnd.Next(0, 3);

        return indx;
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