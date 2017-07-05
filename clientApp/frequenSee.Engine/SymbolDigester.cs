namespace frequenSee.Engine
{
    using System;
    using frequenSee.Models;

    public static class SymbolDigester
    {
        public unsafe static SymbolFrequencyResultSet DigestInput(string input)
        {
            SymbolFrequencyResultSet result = new SymbolFrequencyResultSet();

            int strLength = input.Length;
            fixed (char* pString = input)
            {
                char* pChar = pString;
                for (int i = 0; i < strLength; i++)
                {
                    var c = *pChar;

                    UpdateSymbolFrequency(result, c);
                    
                    pChar++;
                }
            }

            return result;
        }

        private static void UpdateSymbolFrequency(SymbolFrequencyResultSet result, char c)
        {
            if (!result.SymbolDictionary.ContainsKey(c))
            {
                result.SymbolDictionary.Add(c, new CategorySymbolFrequency() { Symbol = new FoundSymbol() { Symbol = c.ToString() }, Hits = 1 });
            }
            else
            {
                result.SymbolDictionary[c].Hits++;
            }
        }
    }
}
