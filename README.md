# 🌉 BridgeBreaker v1.0
[![Build and Release](https://github.com/Disturbed0Angel/BridgeBreakerGame/actions/workflows/build.yml/badge.svg)](https://github.com/Disturbed0Angel/BridgeBreakerGame/actions/workflows/build.yml)

**"Resonance is the key to structural liberation."**

BridgeBreaker is a tactical harmonic oscillator simulator built on **.NET 10 (LTS)**. It calculates the specific structural weak points of a bridge based on user-provided environmental data and challenges the Agent to find the terminal frequency.

## 🕹️ How to Play
1. **Initialize:** Input the Bridge Length and Height.
2. **Analyze:** The system generates a secret `targetFrequency` (0-99 Hz).
3. **Guessing:** Enter frequency guesses to find the harmonic match.
4. **Result:** Receive performance-based feedback from Command based on your efficiency.

## 🛠️ Technical Specs
* **Runtime:** .NET 10.0
* **Input Handling:** Defensive `int.TryParse` validation to prevent system crashes.
* **Logic:** Uses Modulo-based frequency clipping and custom escape-sequence formatting for the terminal.

## 🚀 Installation
1. Ensure you have the [.NET 10 SDK](https://dotnet.microsoft.com/download) installed.
2. Clone the repo: `git clone https://github.com/YOUR_USERNAME/BridgeBreaker.git`
3. Run the app: `dotnet run`
<!-- Wake up cloud runner -->
