﻿using System;
using System.Collections.Generic;

namespace frequenSee.Models
{
    public class SymbolFrequencyResultSet
    {
        public SortedDictionary<char, CategorySymbolFrequency> SymbolDictionary { get; set; } = new SortedDictionary<char, CategorySymbolFrequency>();

        public ContentSource Source { get; set; } = new ContentSource();

        public DateTime ProcessDate { get; private set; } = DateTime.Now;
    }
}
