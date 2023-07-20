# Lab 06: Building a Zoo

## Introduction
In this lab, we will be building a zoo application that models different animals and their behaviors using object-oriented programming principles. The goal is to create a zoo with a variety of animals, implement inheritance, and showcase the four object-oriented principles (OOPs).


## Object-Oriented Principles (OOPs)

### Inheritance
Inheritance is the principle that allows classes to inherit properties and behaviors from parent classes. In our zoo application, we have implemented multiple levels of inheritance. For example, the `Mammal` class inherits from the `Animal` class, and the `Dog` class inherits from the `Mammal` class. This allows us to create a hierarchy of classes and share common characteristics among related animals.

### Polymorphism
Polymorphism is the principle that allows objects of different types to be treated as objects of a common base class. In our zoo application, we utilize polymorphism to interact with animals generically. We can create a list of `Animal` objects and add instances of different concrete animal classes to it. This enables us to call common methods or properties defined in the base class on these objects, regardless of their specific derived class.

### Abstraction
Abstraction is the principle of simplifying complex systems by breaking them down into smaller, more manageable units. In our zoo application, we have abstract classes that provide a common structure and behavior for a group of related animals. For example, the `Animal` class is an abstract class that defines common properties and methods for all animals in the zoo. Abstract classes allow us to define a contract or blueprint that derived classes must implement while hiding the specific implementation details.

### Encapsulation
Encapsulation is the principle of bundling data and methods together within a class, hiding the internal implementation from the outside world. In our zoo application, each class encapsulates its own properties and methods. For example, the `Animal` class encapsulates the `Name` and `Age` properties, as well as the `Eat()` and `Sleep()` methods. This encapsulation ensures that the internal state and behavior of the class are accessed and modified through well-defined interfaces.

## Examples of OOP Application in the Zoo

1. Inheritance: The `Dog` class inherits the properties and methods of its parent classes, `Mammal` and `Animal`. It gains the ability to access and modify properties such as `Name` and `Age`, as well as call methods like `Eat()` and `Sleep()`. This inheritance simplifies code reuse and promotes a hierarchical structure.

2. Polymorphism: We can store instances of different concrete animal classes, such as `Dog`, `Cat`, and `Elephant`, in a collection of `Animal` objects. By treating them as `Animal` objects, we can iterate through the collection and call common methods like `Eat()` and `Sleep()` without knowing the specific derived class.

3. Abstraction: The `Animal` class provides a common blueprint for all animals in the zoo. It defines abstract methods that must be implemented by derived classes, such as `MakeSound()`. This abstraction allows us to interact with animals generically, focusing on their shared characteristics rather than their specific implementations.

These are just a few examples of how the principles of inheritance, polymorphism, abstraction, and encapsulation are applied in our zoo application.

For detailed technical documentation and implementation details, please refer to the code and comments in the solution.


