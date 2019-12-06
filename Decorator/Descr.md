# Structural Pattern

Add responsibilities to objects dynamically

## Definition

Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

## Participants

The classes and objects participating in this pattern are:

### Component

Defines the interface for objects that can have responsibilities added to them dynamically.

### ConcreteComponent

Defines an object to which additional responsibilities can be attached.

### Decorator

Maintains a reference to a Component object and defines an interface that conforms to Component's interface.

### ConcreteDecorator

Adds responsibilities to the component.

![Decorator](https://www.dofactory.com/images/diagrams/net/decorator.gif)