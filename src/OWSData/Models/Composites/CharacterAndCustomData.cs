﻿using OWSData.Models.StoredProcs;
using OWSData.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWSData.Models.Composites
{
    public class CharacterAndCustomData
    {
        public GetCharByCharName CharacterData { get; set; }
        public List<CustomCharacterData> CustomCharacterDataRows { get; set; }
}
}
