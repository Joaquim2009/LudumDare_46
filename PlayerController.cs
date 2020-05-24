using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * horInput * Time.deltaTime);
        transform.Translate(transform.right * speed * -verInput * Time.deltaTime);
    }
}
