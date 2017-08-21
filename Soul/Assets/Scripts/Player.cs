using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Vector3 newPosition;
    float MoveSpeed = 10;


    void Start () {
        newPosition = transform.position;
    }
	
	
	void Update () {
        Mouse_Controller();
        transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime*MoveSpeed);
    }



    void KeyBoard_Controller()
    {
        if(Input.GetKey(KeyCode.W))
        {
            
        }

        if (Input.GetKey(KeyCode.S))
        {

        }

        if (Input.GetKey(KeyCode.A))
        {

        }

        if (Input.GetKey(KeyCode.D))
        {

        }


    }


    void Mouse_Controller()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition = hit.point;
                newPosition.y = transform.position.y;
            }
        }
    }


}
