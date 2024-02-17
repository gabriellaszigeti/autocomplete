using System.Collections.Generic;
using System.Linq;

namespace AutoComplete
{
    public class TrieNode
    {

        public char Value;

        public List<TrieNode> Children; 
        public bool IsWord { get; set; }
        public TrieNode(char value)
        {
            Value = value;
            Children = new List<TrieNode>();
            IsWord = false;

        }

        public bool FindChild(char key) => (Children.Any(x => x.Value.Equals(key)) ? true : false);
        public TrieNode GetChild(char key) => Children.FirstOrDefault(x => x.Value.Equals(key));


    }
}