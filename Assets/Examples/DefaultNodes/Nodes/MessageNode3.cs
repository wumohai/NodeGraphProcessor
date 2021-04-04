using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using Sirenix.Utilities.Editor;

[System.Serializable, NodeMenuItem("Custom/MessageNode3")]
public class MessageNode3 : BaseNode
{
    [Input(name = "In")] public float input;

    [Output(name = "Out")] public float output;

    public override string name => "MessageNode3";

[TableMatrix(HorizontalTitle = "Square Celled Matrix", SquareCells = true)]
public Texture2D[,] SquareCelledMatrix;

[TableMatrix(SquareCells = true)]
public Mesh[,] PrefabMatrix;

[OnInspectorInit]
private void CreateData()
{
    SquareCelledMatrix = new Texture2D[8, 4]
    {
        { ExampleHelper.GetTexture(), null, null, null },
        { null, ExampleHelper.GetTexture(), null, null },
        { null, null, ExampleHelper.GetTexture(), null },
        { null, null, null, ExampleHelper.GetTexture() },
        { ExampleHelper.GetTexture(), null, null, null },
        { null, ExampleHelper.GetTexture(), null, null },
        { null, null, ExampleHelper.GetTexture(), null },
        { null, null, null, ExampleHelper.GetTexture() },
    };

    PrefabMatrix = new Mesh[8, 4]
    {
        { ExampleHelper.GetMesh(), null, null, null },
        { null, ExampleHelper.GetMesh(), null, null },
        { null, null, ExampleHelper.GetMesh(), null },
        { null, null, null, ExampleHelper.GetMesh() },
        { null, null, null, ExampleHelper.GetMesh() },
        { null, null, ExampleHelper.GetMesh(), null },
        { null, ExampleHelper.GetMesh(), null, null },
        { ExampleHelper.GetMesh(), null, null, null },
    };
}


    protected override void Process()
    {
        output = input * 42;
    }
}