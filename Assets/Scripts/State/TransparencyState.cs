using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyState : State
{
    private PlayerMovement player;
    private HUD hud;
    private Renderer playerRenderer;

    public TransparencyState(PlayerMovement player, HUD hud)
    {
        this.player = player;
        this.hud = hud;
        this.playerRenderer = player.GetComponent<Renderer>();
    }

    public override void Enter()
    {
        hud.UpdateStatus("Changing Transparency");
    }

    public override void Exit()
    {
        playerRenderer.material.color = Color.white; // Вернуть непрозрачность
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color color = playerRenderer.material.color;
            color.a = color.a == 1f ? 0.5f : 1f; // Переключение прозрачности
            playerRenderer.material.color = color;
        }
    }
}
