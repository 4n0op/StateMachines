using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachines : MonoBehaviour
{
    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }

    public State currentstate = State.idle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case State.idle: Idle();  break;
            case State.walking: Walking(); break;
            case State.swimming: Swimming(); break;
            case State.climbing: Climbing(); break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "Water")
        {
            Swimming();
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }
    void Swimming()
    {
        Debug.Log("I am Swimming");
    }
    void Climbing()
    {
        Debug.Log("I am Climbing");
    }

    void Idle()
    {
        Debug.Log("I am idle");
    }

    void Walking()
    {
        Debug.Log("I am walking");
    }
}

