﻿namespace frequenSee.Models
{
    public class AnalyzationRequest
    {
        public string InputText { get; set; }

        public DigestType AnalyzationType { get; set; }

        public CategoryEnum CategoryType { get; set; }

        public ContentSource ContentSource { get; set; }
    }
}
