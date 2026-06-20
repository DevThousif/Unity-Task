App Flow

Screen 1 — Welcome Screen


User enters their name and presses Continue
Name is validated (cannot be empty or whitespace)
Name is saved using PlayerPrefs
If a name already exists from a previous session, this screen is skipped automatically


Screen 2 — Counter Screen


Displays the current counter value (starts at 0)
+1 and −1 buttons to increment or decrement
Counter value persists between sessions
Automatically navigates to the Congratulations Screen when the counter reaches 10


Screen 3 — Congratulations Screen


Displays a congratulations message with the saved username
Includes a Reset button (for debugging) that clears all saved data and returns to the Welcome Screen



Features


Persistent data storage using PlayerPrefs
Input validation on name field
Auto-skip Welcome Screen if user data already exists
Auto-navigate to Congratulations Screen when counter hits 10
Clean scene and folder structure
Edge case handling (e.g. app reopened with counter already at 10)



Tech Stack


Engine: Unity
Language: C#
UI: Unity UI + TextMeshPro



Project Structure

Assets/
├── Scenes/
│   ├── WelcomeScene
│   ├── CounterScene
│   └── CongratulationsScene
├── Scripts/
│   ├── WelcomeSceneLoader.cs
│   ├── CounterSceneLoader.cs
│   └── CongratulationsSceneLoader.cs
├── AppLogo/
│   ├── Applogo.png

