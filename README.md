<h1>TeleportTools – GTA V Coordinate Logger</h1>
    <p>
        <strong>TeleportTools</strong> is a simple GTA V ScriptHookVDotNet utility that allows you to quickly capture and save your player’s <strong>X, Y, Z position</strong> and <strong>heading</strong> directly in-game.
        It is useful for modders, developers, mission creators, or anyone needing precise world coordinates for custom scripts.
    </p>

  <h2>📌 Features</h2>
    <ul>
        <li>Logs <strong>X, Y, Z</strong> coordinates and <strong>rotation (heading)</strong> of the player.</li>
        <li>Displays a clean on-screen notification with the coordinates.</li>
        <li>Saves logged coordinates to <code>scripts/location.log</code>.</li>
        <li>Customizable hotkey via <code>coordinates.ini</code>.</li>
        <li>Lightweight, fast, and simple to use.</li>
    </ul>

  <h2>📂 File Output</h2>
  <p>Every time you press the hotkey, a new entry is added to:</p>
  <pre>scripts/location.log</pre>
  <p>Format:</p>
    <pre>
      Position 2025-11-14 22:30:15:
      X: -123.45
      Y: 456.78
      Z: 20.12
      Rotation: 270.0
    </pre>

  <h2>⌨️ Hotkey Configuration</h2>
  <p>You can set your own key in:</p>
  <pre>scripts/coordinates.ini</pre>
  <p>Example:</p>
  <pre>
[Options]
Button=T
    </pre>
    <p>If the key fails to parse, the script defaults to <strong>T</strong>.</p>

  <h2>📜 How It Works</h2>
  <ul>
      <li>Press the hotkey → captures the player’s current position and heading.</li>
      <li>Displays a notification:
          <pre class="notification">
X: &lt;value&gt;
Y: &lt;value&gt;
Z: &lt;value&gt;
Rotation: &lt;value&gt;
            </pre>
        </li>
        <li>Saves the same data to the log file.</li>
    </ul>

  <h2>🧠 Code Summary</h2>
  <ul>
      <li>Uses ScriptHookVDotNet.</li>
      <li>Listens for <code>KeyUp</code> events.</li>
      <li>Reads coordinates with:
          <ul>
              <li><code>Game.Player.Character.Position</code></li>
              <li><code>Game.Player.Character.Heading</code></li>
          </ul>
      </li>
      <li>Logs using a StreamWriter.</li>
  </ul>

  <h2>📦 Installation</h2>
  <ol>
      <li>Install ScriptHookV.</li>
      <li>Install ScriptHookVDotNet.</li>
      <li>Drop this script <code>.cs</code> file into: <code>/scripts/</code></li>
      <li>Run the game.</li>
  </ol>

  <h2>📝 Requirements</h2>
  <ul>
      <li>ScriptHookV</li>
      <li>ScriptHookVDotNet 3.x</li>
      <li>GTA V (PC)</li>
  </ul>

  <h2>📧 Credits</h2>
  <p>Created by <strong>prodbycasarm</strong> (TeleportTools v1.0). Feel free to modify and expand the tool for your own projects.</p>
