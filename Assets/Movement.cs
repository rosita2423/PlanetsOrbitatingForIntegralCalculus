using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float r;
    public float velocity;
    public bool vertical = false;

    private float x;
    private float y;
    private float z;
    private int nx = 10;
    private int ny = 5;
    private int nz = 0;
    private int nxDirection = 1;
    private int nyDirection = 1;
    private int nzDirection = 1;

    private float counter = 0f;

    private float mainPotitionX;
    private float mainPotitionY;
    void Start()
    {
        mainPotitionX = transform.position.x;
        mainPotitionY = transform.position.y;
        Debug.Log("xd");
        StartCoroutine(wait());
    }
    IEnumerator wait(){
        
      yield return new WaitForSeconds(velocity);
      positionChanger();
    }
    void Update()
    {
        
    }

    void positionChanger(){

/*
        if(nx >= 10){
            nxDirection = -1;
        }else if(nx <= 0){
            nxDirection = 1;
        }

        if(ny >= 10){
            nyDirection = -1;
        }else if (ny <= 0){
            nyDirection = 1;
        }
*/

        
        nx = nx + nxDirection;
        x = x + (r*(Mathf.Sin(counter)) * nxDirection);

        ny = ny + nyDirection;
        y = y + (r*(Mathf.Cos(counter)) * nyDirection);

        counter = counter + 0.1f;
        if (vertical == false){
            transform.position = new Vector3(x + mainPotitionX,z,y + mainPotitionY);
        } else {
            transform.position = new Vector3(x + mainPotitionX,y + mainPotitionY,z);
        }
        StartCoroutine(wait());
    }
}
