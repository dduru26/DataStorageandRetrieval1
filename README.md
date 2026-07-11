This is a class activity that challenges our knowledge about Scriptable Objects and PlayerPerfs in Unity. 
Created in Unity Version 6.4


**How it works**

- GameData.cs - is a scriptable object that holds all threee (level (int), health (float), and name (string)) data types

- GameDataDisplay.cs - Reads the GameData Values and show them on the screen

- PlayerPerfsManager - Saves values with SetInt, SetFloat, and SetString. Loads them back with the matching Get calls and updates the screen. A counter makes the values grow on each save so you can see them change. A UI button is also included for reset the loded data.


**Setup**

1. Open the project in unity 6.
2. Load the SampleScene and Press Play
3. Click Load Score to increase the values. They update per click. 
4. Stop to exit the game scene and enter again. You will notice that the values stay persistent until you reset them using the reset button.
