# Structural Pattern

Match interfaces of different classes

## Definition

Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

## Participants

The classes and objects participating in this pattern are:

### Target   (ChemicalCompound) 

Defines the domain-specific interface that Client uses.

### Adapter  (Compound) 

Adapts the interface Adaptee to the Target interface.

### Adaptee  (ChemicalDatabank) 

Defines an existing interface that needs adapting.

### Client  (AdapterApp) 

Collaborates with objects conforming to the Target interface.

![Facade](https://www.dofactory.com/images/diagrams/net/adapter.gif)