/**
 * 1455
 * Check If a Word Occurs As a Prefix of Any Word in a Sentence
 **
 * Given a sentence that consists of some words separated by a single space, and a searchWord,
 * check if searchWord is a prefix of any word in sentence.
 *
 * Return the index of the word in sentence (1-indexed) where searchWord is a prefix of this word.
 * If searchWord is a prefix of more than one word, return the index of the first word (minimum index).
 * If there is no such word return -1.
 *
 * A prefix of a string s is any leading contiguous substring of s.
 *
 * Example 1:
 *   Input: sentence = "i love eating burger", searchWord = "burg"
 *   Output: 4
 *   Explanation: "burg" is prefix of "burger" which is the 4th word in the sentence.
 * 
 * Example 2:
 *   Input: sentence = "this problem is an easy problem", searchWord = "pro"
 *   Output: 2
 *   Explanation:
 *     "pro" is prefix of "problem" which is the 2nd and the 6th word in the sentence,
 *     but we return 2 as it's the minimal index.
 * 
 * Example 3:
 *   Input: sentence = "i am tired", searchWord = "you"
 *   Output: -1
 *   Explanation: "you" is not a prefix of any word in the sentence.
 *
 * Constraints:
 *   • 1 <= sentence.length <= 100
 *   • 1 <= searchWord.length <= 10
 *   • sentence consists of lowercase English letters and spaces.
 *   • searchWord consists of lowercase English letters.
 *
 * Hint 1:
 *   First extract the words of the sentence.
 *
 * Hint 2:
 *   Check for each word if searchWord occurs at index 0, if so return the index of this word (1-indexed)
 *
 * Hint 3:
 *   If searchWord doesn't exist as a prefix of any word return the default value (-1).
 **
 * https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
***/

namespace Problems;

public class CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    public int IsPrefixOfWord( string sentence, string searchWord )
    {
        int wordIndex = 0;

        for ( int i = 0; i < sentence.Length; i++ )
        {
            if ( sentence[i] == ' ' || i == 0 )
            {
                wordIndex++;

                if ( i != 0 )
                {
                    i++;
                }

                if ( sentence[i] == searchWord[0] )
                {
                    int j = 1;

                    while ( i + j < sentence.Length && j < searchWord.Length )
                    {
                        if ( sentence[i + j] != searchWord[j] )
                        {
                            break;
                        }

                        j++;
                    }

                    if ( j == searchWord.Length )
                    {
                        return wordIndex;
                    }
                    else
                    {
                        i += j - 1;
                    }
                }
            }
        }

        return -1;
    }

    public int IsPrefixOfWordSplit( string sentence, string searchWord )
    {
        string[] words = sentence.Split( ' ' );

        for ( int i = 0; i < words.Length; i++ )
        {
            if ( words[i].StartsWith( searchWord ) )
            {
                return i + 1;
            }
        }

        return -1;
    }
}
