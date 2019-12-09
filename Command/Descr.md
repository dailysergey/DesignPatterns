# Behavioral Pattern

Encapsulate a command request as an object

## Definition

Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

## Participants

The classes and objects participating in this pattern are:

### Command 

Declares an interface for executing an operation

### ConcreteCommand

Defines a binding between a Receiver object and an action
Implements Execute by invoking the corresponding operation(s) on Receiver

### Client

Creates a ConcreteCommand object and sets its receiver

### Invoker

Asks the command to carry out the request

### Receiver

Knows how to perform the operations associated with carrying out the request.

![Command](https://www.dofactory.com/images/diagrams/net/command.gif)