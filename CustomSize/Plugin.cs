using System;
using Exiled;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.Features;
using Player = Exiled.Events.Handlers.Player;

namespace CustomSize
{
    public class Main : Plugin<Config>
    {
        public override string Name => "CustomSize";
        public override string Author => "Vacca (@vacca_suprema)";
        public override string Prefix => "CustomSize";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 11);


        public static Main Instance;
        public EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            this.eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Spawned += eventHandlers.OnPlayerSpawned;

            Log.Debug("CustomRandomSize Size Enabled");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= eventHandlers.OnPlayerSpawned;
            Instance = null;
            this.eventHandlers = null;

            Log.Debug("CustomSize disabled.");
            base.OnDisabled();
        }
    }
}
