using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;

[System.Serializable, NodeMenuItem("Custom/VerticalNode")]
public class VerticalNode : BaseNode
{
	[Input(name = "In", allowMultiple = true, horizontal = false)]
    public float                input;

	[Output(name = "Out", horizontal = false)]
	public float				output;

	public override string		name => "VerticalNode";

	protected override void Process()
	{
	    output = input * 42;
	}
}
