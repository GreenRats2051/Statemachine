using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private StateMachine stateMachine;
    public PlayerMovement player;
    public HUD hud;
    public GameObject highlightCirclePrefab;

    void Start()
    {
        stateMachine = new StateMachine();

        stateMachine.AddState("Attack", new AttackState(player, hud));
        stateMachine.AddState("Highlight", new HighlightState(player, hud, highlightCirclePrefab));
        stateMachine.AddState("Transparency", new TransparencyState(player, hud));

        stateMachine.ChangeState("Attack");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (stateMachine.CurrentStateKey == "Attack")
                stateMachine.ChangeState("Highlight");
            else if (stateMachine.CurrentStateKey == "Highlight")
                stateMachine.ChangeState("Transparency");
            else if (stateMachine.CurrentStateKey == "Transparency")
                stateMachine.ChangeState("Attack");
        }

        stateMachine.Update();
    }
}
