using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace JoinMessageUnt
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string PlayerConnectedCl;
        public string PlayerDisconnectedCl;
        public bool ShowConnectedPlayer;
        public bool ShowDisconnectedPlayer;

        public void LoadDefaults()
        {
            PlayerConnectedCl = "white";
            PlayerDisconnectedCl = "white";
            ShowConnectedPlayer = true;
            ShowDisconnectedPlayer = true;
        }
    }
}
