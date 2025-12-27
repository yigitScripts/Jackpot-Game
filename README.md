# 🎰 Console Jackpot Game

A lightweight C# console application that simulates a slot machine game. It generates random numbers and colors, awarding points based on specific combinations, sequences, and color matches.

## 🎮 How to Play

The game generates **3 Random Numbers** (1-6) and assigns a color to each (🔴 Red, 🔵 Blue, 🟢 Green).

Your goal is to get the best combination of numbers and colors!

### Scoring Rules

* **Jackpot (Same Numbers):** If all 3 numbers are the same (e.g., `5 5 5`).
    * Same Colors: **30 Points** (Highest Score!)
    * Different Colors: **28 Points**
    * Mixed: **26 Points**
* **Straight (Consecutive Numbers):** If numbers are in sequence (e.g., `1 2 3`).
    * Same Colors: **20 Points**
    * Different Colors: **18 Points**
    * Mixed: **16 Points**
* **Mixed Numbers:**
    * Same Colors: **10 Points**
    * Different Colors: **8 Points**
* **Pairs:** If 2 numbers match (e.g., `4 4 2`) and all colors match: **6 Points**.

### 🌟 Bonus Points
* **+3 Bonus Points:** If all numbers are **Even** (2, 4, 6) or all are **Odd** (1, 3, 5).

## 💻 Tech Stack

* **Language:** C#
* **Platform:** .NET Console Application
* **Features:**
    * `Random` class for number/color generation.
    * `Console.ForegroundColor` for visual feedback.
    * Mathematical logic for detecting sequences.

## 🚀 How to Run

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/yourusername/Console-Jackpot-Game.git](https://github.com/yourusername/Console-Jackpot-Game.git)
    ```
2.  **Open the project:**
    You can use Visual Studio, VS Code, or simply the terminal.
3.  **Run the game:**
    Navigate to the project folder in your terminal and type:
    ```bash
    dotnet run
    ```

## 📸 Sample Output

```text
( 🔴 3  🔵 3  🟢 3 )
Congratulations!
You win 26$.
You win 3$ bonus.

Do you want to play again? (Y or N)
