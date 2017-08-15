namespace frequenSee.Engine
{
    using System;
    using frequenSee.Models;

    public static class InputDigester
    {
        public unsafe static FrequencyResultSet DigestInput(string input, DigestType digestType)
        {
            FrequencyResultSet result = new FrequencyResultSet();

            int strLength = input.Length;
            fixed (char* pString = input)
            {
                char* pChar = pString;
                for (int i = 0; i < strLength; i++)
                {
                    var c = *pChar;

                    if (digestType == DigestType.Symbols)
                    {
                        UpdateSymbolFrequency(result.FoundSymbolFrequencyResultSet, c);
                    }

                    pChar++;

                    if (digestType == DigestType.Words)
                    {
                        UpdateWordFrequency(result.FoundWordFrequencyResultSet, c);
                    }
                }
            }

            return result;
        }

        private static void UpdateSymbolFrequency(SymbolFrequencyResultSet result, char c)
        {
            if (!result.SymbolDictionary.ContainsKey(c))
            {
                int symbolId = result.SymbolDictionary.Count + 1;

                result.SymbolDictionary.Add(c, new CategorySymbolFrequency(symbolId, new FoundSymbol(symbolId, c.ToString()), 1));
            }
            else
            {
                result.SymbolDictionary[c].Hits++;
            }
        }

        private static void UpdateWordFrequency(WordFrequencyResultSet result, char c)
        {
            if (Char.IsWhiteSpace(c))
            {
                PopCacheToWordDictionary(result);
            }
            else
            {
                result.AppendSymbolToCache(c);
            }
        }

        private static void PopCacheToWordDictionary(WordFrequencyResultSet result)
        {
            string word = result.CachOut().Trim();

            if (!string.IsNullOrEmpty(word))
            {
                if (!result.WordDictionary.ContainsKey(word))
                {
                    int wordId = result.WordDictionary.Count + 1;

                    result.WordDictionary.Add(word, new CategoryWordFrequency(wordId, new FoundWord(wordId, word), 1));
                }
                else
                {
                    result.WordDictionary[word].Hits++;
                }
            }

            result.ResetCache();
        }
    }
}
