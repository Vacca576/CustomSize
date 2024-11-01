using Exiled.Events.EventArgs.Player;
using UnityEngine;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace CustomSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            // Ignore SCPs If set in config.
            if (Main.Instance.Config.IgnoreSCP)
            {
                if (ev.Player.Role.Side == Side.Scp) return;
            }

            // Gets the list of configurable dimensions
            var sizes = Main.Instance.Config.Size;
            if (sizes == null || sizes.Count == 0)
            {
                Log.Warn("The list of dimensions is empty or null. Be sure to configure at least one dimension.");
                return;
            }

            // Select a random size from the list
            float selectedSize = sizes[Random.Range(0, sizes.Count)];
            ev.Player.Scale = new Vector3(selectedSize, selectedSize, selectedSize);

            // Log for Debug
            if (Main.Instance.Config.Debug)
                Log.Debug($"{ev.Player.Nickname} He got the size : {selectedSize}");
        }
    }
}
