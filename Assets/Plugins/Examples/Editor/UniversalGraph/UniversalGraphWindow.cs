using System.Collections;
using System.Collections.Generic;
using Examples.Editor._05_All;
using UnityEngine;
using UnityEditor;
using GraphProcessor;

public class UniversalGraphWindow : BaseGraphWindow
{
    BaseGraph tmpGraph;
    private UniversalToolbarView m_ToolbarView;
    private MiniMapView m_MiniMapView;

    [MenuItem("Window/05 All Combined")]
    public static BaseGraphWindow OpenWithTmpGraph()
    {
        var graphWindow = CreateWindow<UniversalGraphWindow>();

        // When the graph is opened from the window, we don't save the graph to disk
        graphWindow.tmpGraph = ScriptableObject.CreateInstance<BaseGraph>();
        graphWindow.tmpGraph.hideFlags = HideFlags.HideAndDontSave;
        graphWindow.InitializeGraph(graphWindow.tmpGraph);

        graphWindow.Show();

        return graphWindow;
    }

    protected override void OnDestroy()
    {
        graphView?.Dispose();
        DestroyImmediate(tmpGraph);
    }

    protected override void InitializeWindow(BaseGraph graph)
    {
        titleContent = new GUIContent("Universal Graph", AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Plugins/NodeGraphProcessor/Editor/Icon_Dark.png"));

        if (graphView == null)
        {
            graphView = new AllGraphView(this);
            m_MiniMapView = new MiniMapView(graphView);
            graphView.Add(m_MiniMapView);

            m_ToolbarView = new UniversalToolbarView(graphView, m_MiniMapView);
            graphView.Add(m_ToolbarView);
        }

        rootView.Add(graphView);
    }

    protected override void InitializeGraphView(BaseGraphView view)
    {
        // graphView.OpenPinned< ExposedParameterView >();
        // toolbarView.UpdateButtonStatus();
    }
}