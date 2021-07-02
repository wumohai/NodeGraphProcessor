using System;
using System.Collections;
using System.Collections.Generic;
using Examples.Editor._05_All;
using UnityEngine;
using UnityEditor;
using GraphProcessor;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

public class SkillGraphWindow : UniversalGraphWindow
{
    protected override void InitializeWindow(BaseGraph graph)
    {
        graphView = new UniversalGraphView(this);

        m_MiniMap = new MiniMap() {anchored = true};
        graphView.Add(m_MiniMap);
        
        m_ToolbarView = new SkillToolbarView(graphView, m_MiniMap, graph);
        graphView.Add(m_ToolbarView);
    }
}