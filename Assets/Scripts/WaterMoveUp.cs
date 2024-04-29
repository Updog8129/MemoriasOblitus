using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMoveUp : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject floor1;
    public GameObject disabler;

    public float moveSpeed = 0.6f;

    public bool Time1 = false;

    // Update is called once per frame
    void Update()
    {
        if(Time1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, floor1.transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);
            if(transform.position == new Vector3(transform.position.x, floor1.transform.position.y, transform.position.z))
            {
                Time1 = false;
            }

            if (transform.position == new Vector3(transform.position.x, disabler.transform.position.y, transform.position.z))
            {
                gameObject.SetActive(false);
            }
        }
    }
    
    public void MoveUp(GameObject floor)
    {
        Time1 = true;
        floor1 = floor;
    }
}
