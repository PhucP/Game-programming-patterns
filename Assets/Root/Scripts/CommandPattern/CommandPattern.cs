using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CommandPattern : MonoBehaviour
{
    private DoScale1 _scale1Command;
    private DoScale2 _scale2Command;
    
    private void OnEnable()
    {
        // Create command
        _scale1Command = new DoScale1();
        _scale2Command = new DoScale2();
    }

    private void Update()
    {
       HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetAxis("Fire1") != 0)
            _scale1Command.Execute(this.transform);
        
        if(Input.GetAxis("Fire2") != 0)
            _scale2Command.Execute(this.transform);
    }
}

/// <summary>
/// Create two class commands
/// </summary>
public class DoScale1 : ICommand
{
    public void Execute(Transform transform)
    {
        transform.localScale = Vector3.one * 0.5f;
    }

    public void Undo(Transform transform)
    {
        transform.localScale = Vector3.one; 
    }
}

public class DoScale2 : ICommand
{
    public void Execute(Transform transform)
    {
        transform.localScale = Vector3.one; 
    }

    public void Undo(Transform transform)
    {
        transform.localScale = Vector3.one * 0.5f;
    }
}

