using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof( Animator))]
public class GameController : MonoBehaviour
{
    enum GameState { Idle, Walk, Jump};
    GameState curState = GameState.Idle;
    Animator anim;
    // Start is called before the first frame update
    int jumpHash = Animator.StringToHash("Jump");
    int walkHash = Animator.StringToHash("Walk");
    int idleHash = Animator.StringToHash("Idle");

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            int statehash = GetCurState();
            SetTrigger(statehash);
        }
    }

    void SetTrigger(int hashvale)
    {
        anim.SetTrigger(hashvale);
    }

    int GetCurState()
    {
        switch (curState)
        {
            case GameState.Idle:
                curState = GameState.Walk;
                return walkHash;
               
            case GameState.Walk:
                curState = GameState.Jump;
                return jumpHash;
            case GameState.Jump:
                curState = GameState.Idle;
              
                return idleHash;
            default:
                return idleHash;

        }


    }
}
