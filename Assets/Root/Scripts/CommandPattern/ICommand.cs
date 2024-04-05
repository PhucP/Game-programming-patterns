using UnityEngine;

public interface ICommand
{
    public void Execute(Transform transform);
    public void Undo(Transform transform);
}
