﻿using AbpHelper.Models;
using AbpHelper.Steps;

namespace AbpHelper.Workflow.Abp
{
    public static class EntityUsingGenerationWorkflow
    {
        public static WorkflowBuilder AddEntityUsingGenerationWorkflow(this WorkflowBuilder builder)
        {
            return builder
                    .AddStep<TextGenerationStep>(
                        step => step.TemplateName = "UsingEntityNamespace",
                        step => step.Model = new {EntityInfo = step.GetParameter<EntityInfo>("EntityInfo")},
                        step => step.GeneratedTextKey = "EntityUsingText"
                    )
                    .AddStep<TextGenerationStep>(
                        step => step.TemplateName = "UsingEntityDtoNamespace",
                        step => step.Model = new {EntityInfo = step.GetParameter<EntityInfo>("EntityInfo")},
                        step => step.GeneratedTextKey = "EntityDtoUsingText"
                    )
                ;
        }
    }
}