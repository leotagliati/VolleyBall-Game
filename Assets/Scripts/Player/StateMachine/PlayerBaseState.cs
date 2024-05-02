using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : MonoBehaviour
{
    public PlayerStateMachine ctxMachine;
    public GameObject player;
    public virtual void Enter() { }
    public virtual void SubState(PlayerBaseState actualSubState) { }
    public virtual void Do() { }
    public virtual void FixedDo() { }
    public virtual void Exit(PlayerBaseState newState) { }

    public virtual void CheckSwitchState(PlayerBaseState actualState) { }


}