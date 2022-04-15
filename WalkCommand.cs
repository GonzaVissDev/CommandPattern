using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkCommand : ICommand
{
    //Stored Reciver
    Movement _mov;

   public WalkCommand(Movement mov)
    {
        _mov = mov;
    
       
    }

    public void Execute()
    {
        _mov.Walk();
    }

    public void Undo()
    {
        _mov.StepBack();
    }
}
