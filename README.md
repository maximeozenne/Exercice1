# Exercice 1 : L'Hotel

## Mise en situation

- Un client vient dans un hotel et réclame une chambre.
- Le réceptionniste lui propose une liste des chambres disponibles.
- Le client, têtu, va choisir aléatoirement une chambre, qu'elle soit libre ou non.
- Selon le choix du client et la disponibilité de la chambre, le réceptionniste va, ou non, lui réserver la chambre souhaitée.

## Énoncé de l'exercice

- Les classes ```Program``` et ```Chambre``` sont déjà écrites.
- La classe ```Hotel``` est déjà structurée, mais les méthodes sont vides (sauf son constructeur). Elles renvoient des erreurs de type ```NotImplementedException```.
- La classe ```Program``` va faire appel aux méthodes de la classe ```Hotel```. Le but de l'exercice est donc d'implémenter les méthodes de la classe ```Hotel```.

## Présentation de la structure de l'exercice

Lorsque vous pullez le contenu du repository git, vous aurez une solution Visual Studio appelée ```Exercice1```. <br/>
La solution contient un dossier ```src``` qui contient le code complet du projet. <br/>
Dans le dossier ```src```, vous trouverez un Projet ```Exercice```. C'est le projet dans lequel il faudra écrire le code. <br/>
Dans le dossier ```src```, vous trouverez aussi un Projet ```Solution```. Ce projet contient un exemple de solution fonctionnelle pour cet exercice en cas de besoin. <br/>
À côté du dossier ```src```, vous trouverez un dossier ```tests```. Ce dossier contient les tests unitaires automatisés. Vous n'avez pas à vous soucier du code et du contenu de ce dossier.

## Implémentation d'une classe Hotel

Toutes les méthodes de la classe ```Hotel``` ont actuellement pour code :

```
throw new NotImplementedException();
```

Il faut supprimer cette ligne et implémenter chaque méthode selon leur description (```<summary>```).

### Tests unitaires automatisés

Afin de vous aider à écrire votre code et vérifier votre travail, la classe ```Hotel``` est soumise à des Tests Unitaires (TU). <br/>

Un test unitaire est un code, servant à tester du code.  <br/>
Chaque méthode la classe ```Hotel``` doit éxecuter une action bien précise, selon ses paramètres, et selon les différentes conditions. <br/>
Chaque condition possible est testée par les tests unitaires.  <br/>
Vous pouvez donc savoir en temps réel si votre code rempli toutes les conditions nécessaires et renvoie les bonnes valeurs attendues grâce aux tests unitaires.

### Executer les Tests Unitaires

```Visual Studio``` propose une interface graphique avec un bouton pour éxecuter les tests unitaires. <br/>

Pour accéder à l'interface graphique et éxecuter les tests, veuillez vous référer à l'article suivant sur le site de ```Microsoft``` : [Exécuter des tests dans l’explorateur de tests](https://learn.microsoft.com/fr-fr/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022#run-tests-in-test-explorer). <br/>

Lorsque vous afficherez l'```Explorateur de tests``` et que vous éxecuterez les tests pour la première fois, tous les tests seront en erreur.  <br/>
Au fur et à mesure que vous implémenterez la classe ```Hotel```, vous pourrez relancer à volonté les tests unitaires afin de voir votre avancée quant à l'exercice. <br/>
Lorsque tous les tests unitaires sont verts (et donc validés) votre code devrait répondre aux éxigences de l'exercice, et votre travail sera donc terminé.

### Nota Bene

En condition réelle, commencer par écrire des tests avant d'écrire du code s'appelle du **TDD** (pour Test Driven Development, ou en français Développement piloté par les tests). <br/>
L'idée est d'écrire des tests qui répondent aux éxigences du business (le client) puis d'écrire du code petit à petit en lançant fréquemment les tests afin de tester si le code répond à toutes les exigences. <br/>
En général, on écrit d'abord un test, puis du code qui y répond. On ajoute ensuite un autre test, puis on modifie notre code pour qu'il réponde aux 2 tests. Etc.

## Aide et Solution

Le Projet ```Solution``` contient un exemple de solution possible et fonctionnelle qui répond à l'exercice. Vous pouvez vous en servir (avec modération...) pour vous aider quand vous êtes bloqués. <br/>
Avec la solution et les tests, vous devriez pouvoir vous en sortir seuls. Cependant, n'hésitez pas à me demander de l'aide si vous en avez besoin ou si vous ne comprenez pas quoi que ce soit.

#### Pour aller plus loin

Le code est volontairement non optimisé afin de rester accessible pour des débutants. Solution comprise. <br/>
N'hésitez pas à essayer d'optimiser le code (en utilisant des bibliothèques comme ```Linq```) et à me demander si un tel exercice d'optimisation vous intéresse. <br/> <br/>

**Bon courage !**
