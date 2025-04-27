using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsTier2 : MonoBehaviour
{
    // Remove /* and */ to start the task
    /*
    
    public GameObject enemyObject;  // Must have a Rigidbody
    public GameObject textPanel;    // Optional: UI object to toggle on keypress

    private Rigidbody enemyRb;

    void Start()
    {
        // 1. Component access
        enemyRb = enemyObject.GetComponent<Rigidbody>();
        enemyRb.useGravity = false; // 👈 Will throw if Rigidbody not present

        // 2. Destroyed GameObject
        Destroy(enemyObject);
        Debug.Log(enemyObject.name); // 👈 Still referenced, but destroyed

        // 3. Optional reference with logic bug
        if (Input.GetKeyDown(KeyCode.E))
        {
            textPanel.SetActive(true); // 👈 Could be null
        }
    }

    void Update()
    {
        // 4. Misunderstood input logic
        if (!Input.GetKey(KeyCode.Space)) // 👈 Won’t run as expected
        {
            Debug.Log("Player jumps!");
            // Also... why is the player not jumping? Check the basic player controller!
        }
    }
    */
    
}
