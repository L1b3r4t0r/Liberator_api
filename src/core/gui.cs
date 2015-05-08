using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Liberator;
using UnityEngine;

namespace Liberator
{
    public class window
    {
        private Rect windowObject;
        // Not used yet{
        private int idCounter = 0;

        public int GetCounter(){
            return this.idCounter;
        }
        //}

        public Rect BuildRect(float a, float b, float c, float d)
        {
            return new Rect(a, b, c, d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientRect"></param>
        /// <param name="winFunc"></param>
        /// <param name="content"></param>
        /// <param name="style"></param>
        /// <param name="options"></param>
        public void WindowSpawn(int id, Rect clientRect, GUI.WindowFunction winFunc, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            windowObject = GUILayout.Window(id, clientRect, winFunc, content, options);
        }
    }
    public class controll
    {
        public void ButtonSpawn(int id)
        {

        }
    }
}
