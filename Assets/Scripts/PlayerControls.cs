using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{

    //Rigidbody2D object that is stored 
    [Header("Rigidbody")]
    public Rigidbody rb;
    [Header("Defualt Down Speed")]
    //downward speed of the object
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("default Direction Movement Speed")]
    //movement direction of the object 
    public float movement = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //varible equals to coponment Rigidbody2D 
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
