using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor.Examples;
using Sirenix.Utilities.Editor;
using ObjectFieldAlignment = Sirenix.OdinInspector.ObjectFieldAlignment;

[System.Serializable, NodeMenuItem("Custom/MessageNode4")]
public class MessageNode4 : BaseNode
{
    [Input(name = "In")] public float input;

    [Output(name = "Out")] public float output;

    public override string name => "MessageNode4";

    [TableList(ShowIndexLabels = true)]
    public List<SomeCustomClass> TableListWithIndexLabels = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(DrawScrollView = true, MaxScrollViewHeight = 200, MinScrollViewHeight = 100)]
    public List<SomeCustomClass> MinMaxScrollViewTable = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(AlwaysExpanded = true, DrawScrollView = false)]
    public List<SomeCustomClass> AlwaysExpandedTable = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [TableList(ShowPaging = true)]
    public List<SomeCustomClass> TableWithPaging = new List<SomeCustomClass>()
    {
        new SomeCustomClass(),
        new SomeCustomClass(),
    };

    [Serializable]
    public class SomeCustomClass
    {
        [TableColumnWidth(57, Resizable = false)]
        [PreviewField(Alignment = ObjectFieldAlignment.Center)]
        public Texture Icon;

        [TextArea]
        public string Description;

        [VerticalGroup("Combined Column"), LabelWidth(22)]
        public string A, B, C;

        [TableColumnWidth(60)]
        [Button, VerticalGroup("Actions")]
        public void Test1() { }

        [TableColumnWidth(60)]
        [Button, VerticalGroup("Actions")]
        public void Test2() { }

        [OnInspectorInit]
        private void CreateData()
        {
            Description = ExampleHelper.GetString();
            Icon = ExampleHelper.GetTexture();
        }
    }

}