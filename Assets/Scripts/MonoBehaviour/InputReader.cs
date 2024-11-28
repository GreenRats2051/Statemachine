using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public bool IsAttackPressed => Input.GetKeyDown(KeyCode.Mouse1);
    public bool IsEnterPressed => Input.GetKeyDown(KeyCode.Return);
}
