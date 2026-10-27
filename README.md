# Médiateur – Maison intelligente

## Description

Ce projet a été réalisé dans le cadre de la présentation oral en projet intégrateur sur le patron de conception **Médiateur** en C#.

Il consiste à simuler une maison intelligente dans laquelle différents composants peuvent communiquer entre eux grâce à un médiateur, sans dépendre directement les uns des autres.

## Technologies utilisées

- **Langage :** C#
- **Framework :** .NET 10.0
- **Environnement de développement :** Visual Studio Community

## Patron de conception : Médiateur

Le patron Médiateur permet de centraliser la communication entre plusieurs objets dans un médiateur. Les composants communiquent avec celui-ci plutôt que de communiquer directement entre eux.

Dans ce projet, le médiateur coordonne les interactions entre les composants de la maison intelligente. Cette approche réduit le couplage entre les classes et facilite la maintenance du code.

## Structure du projet

- `Composants/` : contient les classes représentant les composants de la maison intelligente.
- `Mediateurs/` : contient les classes responsables de la communication entre les composants.
- `Program.cs` : point d'entrée du programme.
- `MediateurMaisonIntelligente.csproj` : fichier de configuration du projet C#.

## Exécution du projet

### Prérequis

- Visual Studio Community
- Le SDK .NET 10

### Avec Visual Studio

1. Ouvrir le fichier `MediateurMaisonIntelligente.csproj`.
2. Compiler le projet.
3. Exécuter le programme.
