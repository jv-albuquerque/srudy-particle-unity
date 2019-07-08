using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Transform[] targets;
    public bool updown = false;
    public bool move = false;

    private bool up = true;
    private Vector3 vUpDown;

    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
            Move();
        if(updown)
            UpDown();
    }

    private void Move()
    {
        if (Vector3.Distance(targets[index].position, transform.position) <= 0.2f)
        {
            index++;

            if (index >= targets.Length)
                index = 0;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targets[index].position, .1f);
        }
    }

    private void UpDown()
    {

        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time*10)/6 + 1, transform.position.z);
    }
}
