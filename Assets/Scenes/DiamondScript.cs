using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    
    public SpriteRenderer rend;
    public Transform Other;
    public Color newColor;

    [Range(-720, 720)]
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //Other.position = new Vector3(3, 2, Other.position.z);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(5 * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-5 * Time.deltaTime, 0f, 0f);
        }
 
    }
}
