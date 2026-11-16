# Prototype 1 – Player Control

## Overview

A Unity 3D vehicle prototype developed as part of the **Create with Code Live – Spring 2020** course. The project focuses on learning fundamental player control and movement by programming a vehicle that drives along a floating road while navigating obstacles.

The prototype introduces Unity's development workflow, C# scripting, physics, object interactions, and camera controls. It was revisited toward the end of the course to improve performance, vehicle physics, and code optimization.

## Features

- **Vehicle Movement:** Implemented vehicle movement, rotation, and steering using Unity's Transform and physics systems.
- **Third-Person Camera:** Developed a camera controller that follows the vehicle, providing a third-person perspective.
- **Physics-Based Driving:** Used Rigidbody forces, relative forces, and Wheel Colliders to improve vehicle movement and handling.
- **Vehicle Stability:** Adjusted the vehicle's center of mass to improve stability and handling.
- **Speedometer:** Implemented a speedometer using the vehicle's Rigidbody velocity to calculate and display speed in miles per hour.
- **Gear Display:** Used the modulus (remainder) operator to implement a gear display.
- **Ground Detection:** Implemented wheel-ground detection to prevent the vehicle from accelerating while airborne.
- **Object Pooling:** Implemented object pooling for projectiles, reusing inactive objects instead of repeatedly destroying and instantiating them.

## What I Learned & Implemented

### Unity and C# Fundamentals
- Imported packages and assets into Unity.
- Created and managed C# scripts using Visual Studio.
- Worked with variables, vectors, functions, and Unity's Input System.
- Used `Transform`, `Vector3`, and `Time.deltaTime` for movement and rotation.
- Applied `[SerializeField]` to keep variables private while allowing them to be configured through the Unity Inspector.

### Physics and Vehicle Mechanics
- Used `Rigidbody` and `AddRelativeForce()` for physics-based vehicle movement.
- Replaced wheel Mesh Colliders with Wheel Colliders.
- Adjusted the Rigidbody's center of mass using an empty child GameObject as a reference.
- Implemented wheel-ground detection using a list of wheels and a `foreach` loop to determine whether at least two wheels were grounded before allowing movement.

### Camera and Performance Optimization
- Used Unity's event functions appropriately, including `FixedUpdate()` for physics-related movement and `LateUpdate()` for camera tracking.
- Implemented object pooling to reuse projectiles by activating and deactivating objects instead of repeatedly instantiating and destroying them.
- Learned the fundamentals of Data-Oriented Technology Stack (DOTS) and Entity Component System (ECS), including how to recognize their implementation in Unity projects.

## Technologies & Tools

- **Game Engine:** Unity
- **Programming Language:** C#
- **IDE:** Visual Studio
- **Concepts:** Player Control, Transformations, Vector Mathematics, Rigidbody Physics, Wheel Colliders, Object Pooling, Unity Event Functions, DOTS, ECS

## Course

**Create with Code Live – Spring 2020**

A remote Unity course taught by professionals working at Unity, focused on learning game development and programming through hands-on projects.
