using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Namespace definition
/// </summary>
namespace Liberator
{
    /// <summary>
    /// Core class definition
    /// </summary>
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
	public class Core : MonoBehaviour
    {
        /// <summary>
        /// Init the API
        /// </summary>
        public void Awake() { }
        public void Start()
        {
            window winObj;
            winObj.WindowSpawn(0, winObj.BuildRect(50, 50, 100, 80), buildHelloWindow, "Liberator's core is online, wellcome.", GUILayout.Width(300));
        }

        private void buildHelloWindow(int id)
        {
            
        }
        
    }
}