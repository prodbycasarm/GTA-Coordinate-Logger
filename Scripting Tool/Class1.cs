using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.UI;
using GTA.Math;

public class TeleportTools : Script
{
    ScriptSettings config;
    Keys saveLocationKey;
    private string logFilePath = "scripts/location.log";

    public TeleportTools()
    {
        config = ScriptSettings.Load("scripts\\coordinates.ini");
        string keyString = config.GetValue<string>("Options", "Button", "T");
        if (!Enum.TryParse(keyString, true, out saveLocationKey)) // <-- TRUE here
        {
            saveLocationKey = Keys.T;
            Notification.Show("Failed to parse key, using default 'T'");
        }

        Notification.Show("~b~TeleportTools~w~ v1.0 has loaded into the game!");

        Tick += OnTick;
        KeyUp += OnKeyUp;
    }


    private void OnTick(object sender, EventArgs e) { }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == saveLocationKey)
        {
            Vector3 playerPosition = Game.Player.Character.Position;
            float heading = Game.Player.Character.Heading;

            float x = playerPosition.X;
            float y = playerPosition.Y;
            float z = playerPosition.Z;

            //Notification.Show($"~g~X: {x} Y: {y} Z: {z} Rotation:{heading}");

            GTA.UI.Notification.Show(
                GTA.UI.NotificationIcon.Lester,
                "Directions",
                "Important",
                $"~g~X: {x}\nY: {y}\nZ: {z}\nRotation: {heading}",
                false,
                true
            );


            LogLocation(x, y, z, heading);
        }
    }

    private void LogLocation(float x, float y, float z, float heading)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                string logEntry = $"Position {DateTime.Now}:\nX: {x}\nY: {y}\nZ: {z}\nRotation: {heading}\n\n";
                writer.WriteLine(logEntry);
            }
        }
        catch (Exception ex)
        {
            Notification.Show("~r~Error: Unable to write to log file.");
        }
    }
}
