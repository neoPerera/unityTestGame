using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySightContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("SIGHT WORKING?");
    }
}
