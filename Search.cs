using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchString
{
    public interface ISearch
    {
        List<int> FindOccurencesOfString(string source, string input);
    }
    public class Search: ISearch
    {
        public List<int> FindOccurencesOfString(string source, string input)
        {
            List<int> patternResults = new List<int>();
            int sourceLength = source.Length;
            int inputLength = input.Length;

            if (sourceLength == 0 || inputLength == 0) return patternResults; 

            //Look only until string length - length of input. 
            for (int startPos = 0; startPos <= sourceLength - inputLength; startPos++)
            {
                if (string.Equals(source.Substring(startPos, inputLength) , input, StringComparison.OrdinalIgnoreCase))
                    patternResults.Add(startPos);
            }
            return patternResults;
        }
    }
}
