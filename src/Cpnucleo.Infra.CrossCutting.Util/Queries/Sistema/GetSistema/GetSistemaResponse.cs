﻿using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using System.Runtime.Serialization;

namespace Cpnucleo.Infra.CrossCutting.Util.Queries.Sistema.GetSistema
{
    [DataContract]
    public class GetSistemaResponse
    {
        [DataMember(Order = 1)]
        public OperationResult Status { get; set; }

        [DataMember(Order = 2)]
        public SistemaViewModel Sistema { get; set; }
    }
}
