using System.Collections.Generic;

public class StateMachine
{
    private Dictionary<string, State> states = new Dictionary<string, State>();
    private State currentState;

    public string CurrentStateKey { get; private set; }

    public void AddState(string key, State state)
    {
        states[key] = state;
    }

    public void ChangeState(string key)
    {
        currentState?.Exit();
        currentState = states[key];
        CurrentStateKey = key;
        currentState.Enter();
    }

    public void Update()
    {
        currentState?.Update();
    }
}
