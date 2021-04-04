using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;

[System.Serializable, NodeMenuItem("Primitives/Color")]
public class ColorNode : BaseNode
{
    [Output(name = "Color"), SerializeField]
    new public Color color;

    [SerializeReference]
    public Dictionary<int, int> Test = new Dictionary<int, int>();

    public override string name => "Color";
}