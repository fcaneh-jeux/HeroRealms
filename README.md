# HeroRealms

Projet personnel de conception d'un moteur de jeu de cartes inspiré de Hero Realms, développé en C# et .NET.

## Objectifs du projet

Ce projet a été créé dans le but de travailler plusieurs compétences liées au développement logiciel :

* Conception orientée objet
* Modélisation métier
* Architecture logicielle
* Principes SOLID
* Gestion du code avec Git et GitHub
* Travail en branches et Pull Requests
* Réflexion autour des patterns de conception
* Construction progressive d'un moteur de jeu

L'objectif n'est pas de reproduire exactement les règles officielles du jeu, mais de concevoir une architecture suffisamment souple pour représenter différents héros, cartes, pouvoirs et mécanismes.

---

## Architecture

La solution est actuellement organisée en plusieurs projets :

### HeroRealms.Core

Contient les concepts métier principaux :

* Cartes
* Joueurs
* Pouvoirs
* Effets
* Synergies
* Énumérations

### HeroRealms.Data

Contient les données du jeu :

* Définitions des héros
* Cartes de départ
* Pouvoirs
* Contenu statique

### HeroRealms.Console

Projet de test permettant de valider rapidement les évolutions du moteur.

---

## Modélisation des cartes

Toutes les cartes héritent d'une classe abstraite commune :

* ActionCard
* ChampionCard
* ArtifactCard

Chaque carte possède :

* Un nom
* Un coût
* Une faction
* Une liste d'effets
* Une liste d'effets conditionnels

---

## Système d'effets

Les effets simples sont représentés par la classe `Effect`.

Exemples :

* Dégâts
* Pioche
* Soin
* Or

Les synergies sont représentées par `ConditionalEffect`.

Exemple :

* Si au moins deux cartes Action ont été jouées, piocher une carte supplémentaire.

---

## Choix d'effets

Certaines cartes permettent au joueur de choisir entre plusieurs effets.

Pour représenter ce comportement, le projet utilise une classe `EffectChoice`.

Exemple :

Familier Chat :

* Infliger 1 dégât
* OU gagner 1 or
* OU récupérer 1 point de vie

Cette approche permet au moteur de traiter les choix de manière uniforme tout en conservant un faible couplage.

---

## Héros

Chaque héros est représenté par une classe héritant de `HeroDefinition`.

Un héros possède :

* Un nom
* Une santé de départ
* Un deck initial
* Une liste de pouvoirs

Le premier héros implémenté est actuellement :

* Wizard

---

## Choix de conception importants

### Distinction Faction / Type de carte

Une faction représente l'appartenance d'une carte :

* Imperial
* Guild
* Necros
* Wild
* Hero

Un type de carte représente son comportement :

* Action
* Champion
* Artifact

Cette séparation permet d'éviter des combinaisons artificielles et simplifie la gestion des synergies.

### Suppression de HeroCard

Une première version du projet utilisait une classe HeroCard.

Cette approche a été abandonnée au profit d'une séparation plus claire entre :

* Les héros
* Les cartes du deck des héros
* Les cartes de la rivière

---

## Roadmap

### Domaine

* [x] Hiérarchie des cartes
* [x] Système d'effets
* [x] Synergies
* [x] Choix d'effets
* [x] Définition des héros
* [x] Premier héros (Wizard)

### Moteur de jeu

* [ ] Gestion des joueurs
* [ ] Gestion des tours
* [ ] Pioche
* [ ] Défausse
* [ ] Résolution des effets
* [ ] Gestion des cibles
* [ ] Gestion des champions
* [ ] Gestion des pouvoirs
* [ ] Gestion de la rivière

### Contenu

* [ ] Wizard complet
* [ ] Cleric
* [ ] Warrior
* [ ] Ranger
* [ ] Nécromancien

---

## Statut

Projet en cours de développement.

L'accent est actuellement mis sur la modélisation métier et la conception de l'architecture avant l'implémentation complète du moteur de jeu.
