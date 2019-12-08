# Behavioral Pattern

A way of notifying change to a number of classes

## Definition

Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.Publisher-Subscriber (издатель-подписчик)

## Participants

The classes and objects participating in this pattern are:

### Subject 

* Knows its observers. Any number of Observer objects may observe a subject
* Provides an interface for attaching and detaching Observer objects.


### ConcreteSubject

stores state of interest to ConcreteObserver
sends a notification to its observers when its state changes

### Observer

Defines an updating interface for objects that should be notified of changes in a subject.

### ConcreteObserver

* Maintains a reference to a ConcreteSubject object
* Stores state that should stay consistent with the subject's
* Implements the Observer updating interface to keep its state consistent with the subject's

![Observer](https://www.dofactory.com/images/diagrams/net/observer.gif)