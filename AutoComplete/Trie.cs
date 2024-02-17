using System;
using System.Linq;

namespace AutoComplete
{
    public class Trie
    {
        public TrieNode Root;

        public Trie()
        {
            Root = new TrieNode('\0'); 
        }

        public void Insert(string word)
        {
            var curr = Root;
            for (var i = 0; i < word.Length; i++)
            {
                if (!curr.FindChild(word[i]))
                {
                    if (i != word.Length - 1)
                        curr.Children.Add(new TrieNode(word[i]));
                    else
                    {
                        curr.Children.Add(new TrieNode(word[i]));
                        curr = curr.GetChild(word[i]);
                    }
                }
                else if (i == word.Length - 1)
                {
                    curr = curr.GetChild(word[i]);
                    curr.Value = '\0';
                    curr.IsWord = true;
                    break;
                }
                curr = curr.GetChild(word[i]);
            }
    
        }
        
        public bool Remove(string word)
        {
            var curr = Root;
            foreach (var c in word)
            {
                if (curr.FindChild(c) == false)
                {
                    return false;
                }
                curr = curr.GetChild(c);
            }
            curr.IsWord = false;
            curr.Value = '\0';
            return true;
        }
    }
}