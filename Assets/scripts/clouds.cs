using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2f;
    //public int HP = 0;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;


        temp.z = temp.z + speed * Time.deltaTime;


        this.transform.position = temp;
    }
}
