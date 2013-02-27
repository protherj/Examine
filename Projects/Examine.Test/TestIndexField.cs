﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examine.Test
{
    public class TestIndexField : IIndexField
    {
        private string _indexName;
        public string Name { get; set; }

        
        public string IndexName
        {
            get { return _indexName ?? Name; }
            set { _indexName = value; }
        }

        public bool EnableSorting { get; set; }
        public string Type { get; set; }
    }
}