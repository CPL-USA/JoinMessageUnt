using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace JoinMessageUnt
{
    public class JoinMessageUnt : RocketPlugin<Configuration>
    {
        public static JoinMessageUnt Instance;
        
        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += onPlayerConnected;
            U.Events.OnPlayerDisconnected += onPlayerDisconnected;
        }

        

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= onPlayerConnected;
            U.Events.OnPlayerDisconnected -= onPlayerDisconnected;
        }

        private void onPlayerConnected(UnturnedPlayer player)
        {
            
            if (Configuration.Instance.ShowConnectedPlayer)
            {
                UnturnedChat.Say(player.CharacterName + " подключился на сервер!", UnturnedChat.GetColorFromName(Configuration.Instance.PlayerConnectedCl, new Color(0, 0, 0)));
            }
        }

    

        private void onPlayerDisconnected(UnturnedPlayer player)
        {
            if (Configuration.Instance.ShowDisconnectedPlayer)
            {
                UnturnedChat.Say(player.CharacterName + " отключился от сервера!", UnturnedChat.GetColorFromName(Configuration.Instance.PlayerConnectedCl, new Color(0, 0, 0)));
            }
        }

    }
}
