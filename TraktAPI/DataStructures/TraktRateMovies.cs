﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TraktRater.TraktAPI.DataStructures
{
    [DataContract]
    public class TraktRateMovies : TraktAuthentication
    {
        [DataMember(Name = "movies")]
        public List<TraktMovie> Movies { get; set; }
    }
}
