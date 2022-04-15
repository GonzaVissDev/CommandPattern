using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand
{
    Movement _mov;

    public JumpCommand(Movement mov)
    {
        _mov = mov;
    }

    public void Execute()
    {
        _mov.Jump();
    }

    public void Undo()
    {
        _mov.Jump();
    }
}
