#Demo 1


https://github.com/user-attachments/assets/2d54e308-b901-48cd-8b9f-28b876205b9f

#Demo 2 (Caméra téléphone) 



https://github.com/user-attachments/assets/deaeaf5c-3abc-4afb-ab75-a9fed00b36d6


# 🌌 Projet AR — Système Solaire (Unity + Vuforia)

Ce projet est une application de **Réalité Augmentée (AR)** développée avec **Unity** et **Vuforia**, permettant d’afficher des planètes du système solaire en 3D lorsqu’une image cible est détectée.

---

## 📱 Fonctionnalités

- Affichage en AR de plusieurs objets 3D représentant :
  - ☀️ Soleil  
  - 🌍 Terre  
  - 🔴 Mars  
  - 🔵 Neptune  
  - 🟤 Jupiter  
- Description détaillée de chaque planète via **TextMeshPro (TMP)**.
- Activation/désactivation automatique des modèles 3D grâce à un script personnalisé.
- Interface simple : chaque bouton affiche une planète et masque les autres.

---

## 🛠️ Technologies utilisées

- **Unity** (version recommandée : 2021+)
- **Vuforia Engine**
- **TextMeshPro**
- **C# (scripts Unity)**

---


---

## 📌 Script principal : `Planets.cs`

Ce script gère :

- l’activation du modèle 3D d'une planète,
- la désactivation des autres,
- la mise à jour du texte descriptif.

Il contient les méthodes suivantes :

- `showSoleil()`
- `showTerre()`
- `showMars()`
- `showNeptune()`
- `showJupiter()`

Chacune modifie :

- l’objet 3D affiché dans la scène,
- le texte explicatif.

---

## ▶️ Comment utiliser le projet

1. Importer **Vuforia Engine** dans Unity via le Package Manager.
2. Ajouter une **ARCamera** dans la scène.
3. Configurer votre **clé Vuforia** dans *Vuforia Behaviour*.
4. Ajouter une **Image Target** pour la détection.
5. Glisser les modèles 3D des planètes comme enfants de l’Image Target.
6. Assigner le script **Planets.cs** à un GameObject.
7. Relier :
   - tous les GameObjects des planètes dans l’Inspecteur,
   - le champ `description` au TextMeshPro.
8. Créer des UI Buttons et appeler les méthodes :
   - `Planets.showSoleil()`
   - `Planets.showTerre()`
   - etc.

---

## 📸 Résultat attendu

Lorsque l’utilisateur scanne l’image cible :

- La planète choisie s’affiche en 3D.
- Une description claire apparaît sur l’écran.
- Les autres planètes deviennent invisibles.

---

## 📦 Build

- Plateforme recommandée : **Android**
- Architecture : ARM64
- Autorisations : Camera (gérée automatiquement par Vuforia)

---

## 👨‍💻 Auteur

Projet réalisé par **Mahdi BEN MEKKI**.

