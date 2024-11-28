using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    private PlayerMovement player;
    private HUD hud;

    public AttackState(PlayerMovement player, HUD hud)
    {
        this.player = player;
        this.hud = hud;
    }

    public override void Enter()
    {
        hud.UpdateStatus("Attacking");
        Debug.Log("Player Enter");
    }

    public override void Exit()
    {
        Debug.Log("Player Exit");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Player Shoot!");
        }
    }
}
