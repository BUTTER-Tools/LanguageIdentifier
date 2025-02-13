﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvanAkcheurov.NClassify
{
    public interface IFeatureExtractor<TSource, TFeature>
    {
        IEnumerable<TFeature> GetFeatures(TSource obj);
    }
}
