using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsTier3 : MonoBehaviour
{
    // Remove /* and */ to start the task
    
    /*
    public GameObject messagePanel;  // UI object
    public GameObject levelManager;  // Has a custom script

    private Enemy enemy;

    void Start()
    {
        // 1. Uninitialized custom class
        Debug.Log("Enemy health: " + enemy.health); // 👈 Crashes unless new’d

        // 2. Logic error: index out of bounds
        int[] scores = new int[2];
        for (int i = 0; i <= scores.Length; i++)
        {
            scores[i] = i * 100;
        }

        // 3. Coroutine timing — object might be null or inactive
        StartCoroutine(ShowMessage());

        // 4. Inheritance trap: 'new' vs 'override'
        GameCharacter c = new Knight();
        c.Attack(); // 👈 Doesn’t call Knight's Attack!
    }

    System.Collections.IEnumerator ShowMessage()
    {
        yield return new WaitForSeconds(0.1f);
        messagePanel.SetActive(true); // 👈 Could be null or inactive in scene
    }

    public class Enemy
    {
        public int health = 50;
    }

    public class GameCharacter
    {
        public virtual void Attack()
        {
            Debug.Log("Base character attacks.");
        }
    }

    public class Knight : GameCharacter
    {
        public new void Attack() // 👈 Not polymorphic — bad override
        {
            Debug.Log("Knight swings sword!");
        }
    }
    */
}
