using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightState : State
{
    private PlayerMovement player;
    private HUD hud;
    private GameObject highlightCircle;

    public HighlightState(PlayerMovement player, HUD hud, GameObject highlightCirclePrefab)
    {
        this.player = player;
        this.hud = hud;
        this.highlightCircle = GameObject.Instantiate(highlightCirclePrefab);
        this.highlightCircle.SetActive(false);
    }

    public override void Enter()
    {
        hud.UpdateStatus("Highlighting");
    }

    public override void Exit()
    {
        highlightCircle.SetActive(false);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            highlightCircle.SetActive(!highlightCircle.activeSelf);
        }
    }
}
