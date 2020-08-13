using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadMovement : MonoBehaviour
{
    //Movement velocity 
    [Tooltip ("Velocity in unity units")] 
    [SerializeField] private float velocity = 5f; 
    private float xOff = 0f;
    [Header("Controls for game pad:")]
    [SerializeField] private KeyCode upControl = KeyCode.W;
    [SerializeField] private KeyCode downControl = KeyCode.S;
    private Rigidbody2D rigidbody2D; 
    [Header ("Separation of the sprite with the edge of the screen in Y below:")] 
    public float yoffsetinf;
    [Header (  "Separation of the sprite with the edge of the screen at Y at the top:")] 
    public float yoffsetSup; 
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
