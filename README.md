# Unity Endless Runner System

## Overview

This Unity project demonstrates a simple game where the player controls a character that can jump and avoid obstacles. The game features multiple design patterns such as Singleton, Factory, and Strategy to ensure the project follows SOLID principles and clean code practices.

## Design Patterns Used

- **Singleton Pattern**: Ensures that only one instance of the `GameManager` and `ObstacleFactory` exists during runtime. This allows global access to game state and obstacle creation.
- **Factory Pattern**: Handles the creation of obstacles through the `ObstacleFactory` class. This pattern decouples the instantiation logic from the `GameManager`.
- **Strategy Pattern**: The jumping behavior of the player is handled by different implementations of the `IJumpBehavior` interface, which allows for flexible jump logic (e.g., standard jump, double jump, etc.).

## Project Structure

- **GameManager.cs**: Manages the overall game state, including starting the game, spawning obstacles, and tracking the score.
- **PlayerController.cs**: Handles player input, including jumping behavior and detecting collisions with obstacles.
- **ObstacleFactory.cs**: Responsible for creating obstacles at specified locations.
- **Obstacle.cs**: Manages obstacle movement and destruction when they go off-screen.
- **IJumpBehavior.cs**: Interface defining the jump behavior for the player.
- **StandardJump.cs**: Implementation of the `IJumpBehavior` that allows the player to jump with a standard force.

