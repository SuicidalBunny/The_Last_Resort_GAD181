using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolRandom : MonoBehaviour
{
    // Enemy Guard 1 Types
    public GameObject enemyGuard1_V1;
    public GameObject enemyGuard1_V2;

    // Enemy Guard 2 Types
    public GameObject enemyGuard2_V1;
    public GameObject enemyGuard2_V2;

    // Enemy Guard 3 Types
    public GameObject enemyGuard3_V1;
    public GameObject enemyGuard3_V2;

    // Enemy Guard 4 Types
    public GameObject enemyGuard4_V1;
    public GameObject enemyGuard4_V2;

    // Enemy Guard 5 Types
    public GameObject enemyGuard5_V1;
    public GameObject enemyGuard5_V2;

    // Enemy Guard 6 Types
    public GameObject enemyGuard6_V1;
    public GameObject enemyGuard6_V2;

    // Enemy Guard 7 Types
    public GameObject enemyGuard7_V1;
    public GameObject enemyGuard7_V2;

    // Enemy Guard 8 Types
    public GameObject enemyGuard8_V1;
    public GameObject enemyGuard8_V2;


    // Start is called before the first frame update
    void Start()
    {
        //Sets Version 1 Guards off
        enemyGuard1_V1.SetActive(false);
        enemyGuard2_V1.SetActive(false);
        enemyGuard3_V1.SetActive(false);
        enemyGuard4_V1.SetActive(false);
        enemyGuard5_V1.SetActive(false);
        enemyGuard6_V1.SetActive(false);
        enemyGuard7_V1.SetActive(false);
        enemyGuard8_V1.SetActive(false);

        //Sets Version 2 Guards off
        enemyGuard1_V2.SetActive(false);
        enemyGuard2_V2.SetActive(false);
        enemyGuard3_V2.SetActive(false);
        enemyGuard4_V2.SetActive(false);
        enemyGuard5_V2.SetActive(false);
        enemyGuard6_V2.SetActive(false);
        enemyGuard7_V2.SetActive(false);
        enemyGuard8_V2.SetActive(false);

        GuardSelect();

    }



    // Update is called once per frame
    void Update()
    {
        
    }


    public void GuardSelect()
    {
        int guard1 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard1);
        if (guard1 == 1)
        {
            enemyGuard1_V1.SetActive(true);
            Debug.Log(enemyGuard1_V1);
        }
        else if (guard1 == 2)
        {
            enemyGuard1_V2.SetActive(true);
            Debug.Log(enemyGuard1_V1);
        }

        int guard2 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard2);
        if (guard2 == 1)
        {
            enemyGuard2_V1.SetActive(true);
            Debug.Log(enemyGuard2_V1);
        }
        else if (guard2 == 2)
        {
            enemyGuard2_V2.SetActive(true);
            Debug.Log(enemyGuard2_V1);
        }

        int guard3 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard3);
        if (guard3 == 1)
        {
            enemyGuard3_V1.SetActive(true);
            Debug.Log(enemyGuard3_V1);
        }
        else if (guard3 == 2)
        {
            enemyGuard3_V2.SetActive(true);
            Debug.Log(enemyGuard3_V1);
        }

        int guard4 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard4);
        if (guard4 == 1)
        {
            enemyGuard4_V1.SetActive(true);
            Debug.Log(enemyGuard4_V1);
        }
        else if (guard4 == 2)
        {
            enemyGuard4_V2.SetActive(true);
            Debug.Log(enemyGuard4_V1);
        }

        int guard5 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard5);
        if (guard5 == 1)
        {
            enemyGuard5_V1.SetActive(true);
            Debug.Log(enemyGuard5_V1);
        }
        else if (guard5 == 2)
        {
            enemyGuard5_V2.SetActive(true);
            Debug.Log(enemyGuard5_V1);
        }

        int guard6 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard6);
        if (guard6 == 1)
        {
            enemyGuard6_V1.SetActive(true);
            Debug.Log(enemyGuard6_V1);
        }
        else if (guard6 == 2)
        {
            enemyGuard6_V2.SetActive(true);
            Debug.Log(enemyGuard6_V1);
        }

        int guard7 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard7);
        if (guard7 == 1)
        {
            enemyGuard7_V1.SetActive(true);
            Debug.Log(enemyGuard7_V1);
        }
        else if (guard7 == 2)
        {
            enemyGuard7_V2.SetActive(true);
            Debug.Log(enemyGuard7_V1);
        }

        int guard8 = Random.Range(1, 3); // 3 will never get picket. Only options are 1 and 2
        Debug.Log(guard8);
        if (guard8 == 1)
        {
            enemyGuard8_V1.SetActive(true);
            Debug.Log(enemyGuard8_V1);
        }
        else if (guard8 == 2)
        {
            enemyGuard8_V2.SetActive(true);
            Debug.Log(enemyGuard8_V1);
        }

    }
}
