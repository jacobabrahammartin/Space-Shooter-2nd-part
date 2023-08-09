using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;

namespace TMPro
{
    [Serializable]
    public class TMP_TextElement
    {
        [SerializeField]
        protected TMPro.TextElementType m_ElementType;
        [SerializeField]
        internal uint m_Unicode;
        [SerializeField]
        internal uint m_GlyphIndex;
        [SerializeField]
        internal float m_Scale;
    }
}






