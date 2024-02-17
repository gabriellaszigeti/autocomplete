# autocomplete
C# school homework
# Autocomplete

## Story

Autocomplete can be a huge help or a major setback, depending on your personal opinion.
Nonetheless, when it comes to software, it's considered one of the most requested features.

Your task is to create an `Autocomplete app` using the `Trie` data structure.

## What are you going to learn?

- implement `Trie` data structure
- build an `autocomplete` system using `Trie`

## Tasks

1. Install the dependencies required by the project.
    - Wait for NuGet to restore all packages.

2. Implement the `Insert()` method of the `Trie` class, which inserts the given word into the trie.
    - The `Insert()` method of the `Trie` class inserts the given word into the trie
    - The method doesn't return anything (is a void)
    - Every character of the given word is inserted as an instance of the `TrieNode` class

3. Implement the `GetMatches()` method of the `Autocomplete` class, which returns the possible complete words starting with the given prefix.
    - The method returns a list of strings
    - Every item in the returned list is a valid word
    - Every item in the returned list is starting with the given prefix
    - The method searches with case sensitivity

4. [OPTIONAL] Implement the `Remove()` method of the `Trie` class, which deletes the given word from the trie.
    - The `Remove()` method of the `Trie` class deletes the given word from the trie
    - The method returns a boolean value; `true` if deletion happened, `false` otherwise

## General requirements

None

## Hints



## Background materials

- <i class="far fa-exclamation"></i> [Trees](project/curriculum/materials/competencies/data-structures-graphs/trees.md.html)
- <i class="far fa-video"></i> [Applied CS Skills - Trees](https://youtu.be/rP6wjhNqwMc)
- <i class="far fa-exclamation"></i> [Trie](https://en.wikipedia.org/wiki/Trie)
- <i class="far fa-video"></i> [Applied CS Skills - Tries](https://youtu.be/kMt9Y5fv4Ug)