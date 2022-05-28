using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotateSpeed * Time.deltaTime,0,0,Space.Self);
    }
}
