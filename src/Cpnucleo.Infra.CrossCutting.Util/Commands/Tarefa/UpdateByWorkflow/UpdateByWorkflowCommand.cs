﻿using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using System;
using System.Runtime.Serialization;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Tarefa.UpdateByWorkflow
{
    [DataContract]
    public class UpdateByWorkflowCommand
    {
        [DataMember(Order = 1)]
        public Guid IdTarefa { get; set; }

        [DataMember(Order = 2)]
        public WorkflowViewModel Workflow { get; set; }
    }
}
