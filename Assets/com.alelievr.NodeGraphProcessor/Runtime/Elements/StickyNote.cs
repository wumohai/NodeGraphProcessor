using UnityEngine.UIElements;
using UnityEngine;
using System;

namespace GraphProcessor
{
    public class StickyNote
    {
        public string title = "New Sticky Note";
        public string contents = "";
        public Vector2 position;

        public StickyNote(Vector2 position) => this.position = position;
    }
}