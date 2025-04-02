# Mercenary Guild Management System

## About This Project
This is my fifth project for the Advanced Programming class. I created a console application that demonstrates the use of delegates and events in C#. The project implements a fantasy mercenary guild management system where users can hire mercenaries, create quests, and send mercenaries on quests to fight monsters.

## What I Made
I implemented several classes and features to showcase delegates and event handling in C#:

### Core Classes
- `Guild`
  - The main class that manages mercenaries and quests
  - Uses events to notify when mercenaries are hired, quests are added, and quests are completed
  - Includes methods to find and filter mercenaries and quests

- `Mercenary`
  - Represents a mercenary with properties like name, level, health points, damage, etc.
  - Can gain experience and level up after successful quests

- `Monster`
  - Represents a monster with properties like name, health points, and damage
  - Serves as an opponent for mercenaries during quests

- `Quest`
  - Represents a quest with properties like name, description, location, difficulty, rewards, etc.
  - Contains a monster that mercenaries must defeat

- `Difficulty`
  - An enumeration that represents different quest difficulty levels

### Delegates and Events
- `MercenaryHandler`
  - A delegate for methods that take a mercenary as a parameter
  - Used for operations on individual mercenaries

- `QuestHandler`
  - A delegate for methods that take a quest as a parameter
  - Used for operations on individual quests

- `MercenaryQuestHandler`
  - A delegate for methods that take both a mercenary and a quest as parameters
  - Used for operations that involve both entities

- Guild Events
  - `OnMercenaryHired`: Triggered when a new mercenary is hired
  - `OnQuestAdded`: Triggered when a new quest is added
  - `OnQuestCompleting`: Triggered before a quest begins
  - `OnQuestCompleted`: Triggered after a quest is completed

### Additional Features
- Custom exceptions for error handling
- Colorful console output with dramatic pauses
- Lambda expressions for event handling
- Method overloading and reuse
- Functional programming concepts

## What This Program Does
1. Creates a guild to manage mercenaries and quests
2. Allows hiring of mercenaries with unique names
3. Enables adding quests with various difficulties and rewards
4. Permits searching for mercenaries and quests based on different criteria
5. Simulates sending mercenaries on quests with combat against monsters
6. Handles rewards (experience, gold) and leveling up mechanics
7. Demonstrates events that trigger during key moments in the guild's operations