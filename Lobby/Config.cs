﻿namespace Lobby
{
    using PlayerRoles;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Config
    {
        [Description("Main text ({seconds} - Either it shows how much is left until the start, or the server status is \"Server is suspended\", \"Round starting\")")]
        public string TitleText { get; set; } = "<size=50><color=#F0FF00><b>Waiting for players, {seconds}</b></color></size>";

        [Description("Text showing the number of players ({players} - Text with the number of players)")]
        public string PlayerCountText { get; set; } = "<size=40><color=#FFA600><i>{players}</i></color></size>";

        [Description("What will be written if the lobby is locked ?")]
        public string ServerPauseText { get; set; } = "Server is suspended";

        [Description("What will be written when there is a second left ?")]
        public string SecondLeftText { get; set; } = "{seconds} second left";

        [Description("What will be written when there is more than a second left ?")]
        public string SecondsLeftText { get; set; } = "{seconds} seconds left";

        [Description("What will be written when the round starts ?")]
        public string RoundStartText { get; set; } = "Round starting";

        [Description("What will be written when there is only one player on the server ?")]
        public string PlayerJoinText { get; set; } = "player joined";

        [Description("What will be written when there is more than one player on the server ?")]
        public string PlayersJoinText { get; set; } = "players joined";

        [Description("What is the movement boost intensity ?")]
        public byte MovementBoostIntensity { get; set; } = 50;

        [Description("What role will people play in the lobby? ?")]
        public RoleTypeId LobbyPlayerRole { get; set; } = RoleTypeId.Tutorial;
    }
}
