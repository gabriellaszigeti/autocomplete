using System;
using System.Collections.Generic;

namespace AutoComplete
{
    public class Autocomplete : Trie
    {
        public List<string> GetMatches(string prefix)
        {
            var words = new List<string>();
            var node = GetNode(prefix);
            GetMatchingWords(words, node, prefix);
            return words;
        }

        public void GetMatchingWords(List<string> words,TrieNode node, string word)
        {
            if (node == null)
            {
                return;
            }

            if (node.IsWord)
            {
                words.Add(word);
            }
        }

        private TrieNode GetNode(string word)
        {
            TrieNode curr = Root;
            foreach(var c in word)
            {
                if(curr.GetChild(c) == null)
                {
                    return null;
                }
                curr = curr.GetChild(c);
            }
            return curr;
        }
    }
}