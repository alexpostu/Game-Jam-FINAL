using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForFinish : MonoBehaviour
{
    public List<Vector3> end = new List<Vector3>();

    private bool ended;

    public GameObject myGrid;
    public GameObject myCharacter;
    public GameObject myCanvas;
    public GameObject myHUDCanvas;

    
    // Start is called before the first frame update
    void Start()
    {
        ChangeObjects(true, true, true, false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckEnd();
    }

    void CheckEnd()
    {
        if ((transform.position.x >= end[0].x && transform.position.x <= end[1].x) && (transform.position.y >= end[0].y && transform.position.y <= end[1].y))
        {
            ChangeObjects(false, false, false, true);
        }
    }

    void ChangeObjects(bool a, bool b, bool c, bool d)
    {
        myGrid.SetActive(a);
        myCharacter.SetActive(b);
        myCanvas.SetActive(c);
        myHUDCanvas.SetActive(d);
    }
}
