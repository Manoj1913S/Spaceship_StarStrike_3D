# Spaceship_StarStrike_3D
A small 3D spaceship shooter game made with **Unity 6.3 LTS**.

## About the Game
The player controls a spaceship flying through a 3D environment. The spaceship follows a **Timeline-based flight path**, encounters enemy spaceships, attacks them, and continues the mission.
The game also includes **story dialogue, character portraits, score, explosions, audio, and environment elements**.

## Features
* 3D spaceship shooter
* Timeline-based spaceship movement
* Smooth movement and rotation
* Enemy spaceships
* Shooting and enemy destruction
* Collision-based destruction
* Score system
* Explosion effects and sounds
* Background music and gameplay audio
* Story dialogue
* Commander and soldier portrait cameras
* Timeline Signals for dialogue
* Crosshair / target point
* 3D terrain and terrain textures
* Trees, mountains, and environment objects
* Skybox
* Prefabs and nested prefabs
* Coroutine-based delayed actions
* Singleton-based shared systems

## Unity Concepts Used

### Movement & Animation
* Timeline
* Animation Curves
* Clamp
* Vector3 arithmetic
* Quaternion rotation
* Smooth movement and rotation

### Targeting & Input
* Screen To World Point
* Target positioning
* Crosshair / aiming

### Unity Workflow
* Prefabs
* Nested Prefabs
* Timeline Signals

### Story System
* Dialogue system
* Timeline-triggered dialogue
* Portrait cameras

### Programming
* Coroutines
* Singleton pattern
* Collision detection
* Score system

### Environment
* Unity Terrain
* Terrain texturing
* Trees and environment setup
* Mountains / raised terrain
* Skybox

### Audio & Effects
* Background music
* Gameplay sound effects
* Explosion sounds
* Explosion effects

## Project Structure Concepts
The project uses reusable prefabs for:
* Player spaceship
* Enemy spaceship
* Projectile
* Explosion
* Environment objects

It also uses shared managers such as:
* Game Manager
* Score Manager
* Dialogue Manager
* Audio Manager

## Story & Dialogue
Dialogue is triggered through **Timeline Signals**.

```text
Timeline Signal
      ↓
Dialogue Starts
      ↓
Text + Character Portrait
      ↓
Conversation
      ↓
Gameplay Continues
```

## Project Information
* **Unity:** 6.3 LTS
* **Version:** `6000.3.10f1`
* **Type:** 3D Space / Sci-Fi Shooter
* **Style:** Story-based, Timeline-driven gameplay
* **Environment:** Terrain-based 3D world

## Learning Goal
This project was created to practice **Unity 3D development** and learn how gameplay, movement, animation, environment, UI, audio, combat, and story systems work together.

It is a **learning project and a small complete gameplay demo**.

