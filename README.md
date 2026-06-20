# App Flow

## Welcome Screen

The application starts on the Welcome Screen, where the user is prompted to enter their name.

* Users must enter a valid name (empty or whitespace-only input is not allowed).
* The entered name is saved using Unity's PlayerPrefs.
* If a username already exists from a previous session, the Welcome Screen is skipped automatically and the user is taken directly to the Counter Screen.

---

## Counter Screen

The Counter Screen displays a persistent counter value.

* The counter starts at 0 for new users.
* Users can increase the value using the +1 button.
* Users can decrease the value using the −1 button.
* The counter value is saved using `PlayerPrefs` and persists between application sessions.
* When the counter reaches 10, the application automatically navigates to the Congratulations Screen.
* If the application is reopened while the counter is already 10, the Congratulations Screen is shown automatically.

---

## Congratulations Screen

The Congratulations Screen is displayed when the counter reaches **10**.

* A personalized congratulations message is shown using the saved username.
* A Reset button is included for testing and debugging purposes.
* Pressing Reset clears all saved data and returns the user to the Welcome Screen.

# Features

* Persistent data storage using PlayerPrefs
* Username input validation
* Automatic Welcome Screen bypass for returning users
* Persistent counter system
* Automatic navigation to the Congratulations Screen at a counter value of 10
* Personalized congratulations message
* Reset functionality for testing and debugging
* Organized scene and folder structure
* Edge-case handling for saved progress and application restarts

# Tech Stack

* **Engine:** Unity
* **Language:** C#
* **UI Framework:** Unity UI
* **Text Rendering:** TextMeshPro

# Project Structure


Assets/
├── Scenes/
│   ├── WelcomeScene
│   ├── CounterScene
│   └── CongratulationsScene
│
├── Scripts/
│   ├── WelcomeSceneLoader.cs
│   ├── CounterSceneLoader.cs
│   └── CongratulationsSceneLoader.cs
│
└── AppLogo/
    └── Applogo.png

