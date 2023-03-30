using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float giracion;
    public bool vertical = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vertical == true){
            transform.Rotate(new Vector3(0f, giracion, 0f) * Time.deltaTime);
        } else{
            transform.Rotate(new Vector3( giracion, 0f, 0f) * Time.deltaTime);
        }
    }
}
