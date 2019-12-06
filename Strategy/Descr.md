# Behavioral Pattern

Creates an instance of several families of classes

## Definition

Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Participants

The classes and objects participating in this pattern are:

### Strategy 

declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy

### ConcreteStrategy

implements the algorithm using the Strategy interface

### Context

* is configured with a ConcreteStrategy object
* maintains a reference to a Strategy object
* may define an interface that lets Strategy access its data.

Maintains a reference to a Component object and defines an interface that conforms to Component's interface.

### ConcreteDecorator

Adds responsibilities to the component.

![Strategy](https://www.dofactory.com/images/diagrams/net/strategy.gif)