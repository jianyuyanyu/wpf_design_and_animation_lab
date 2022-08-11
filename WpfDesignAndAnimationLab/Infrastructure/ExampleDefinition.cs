﻿using System;
using System.Collections.Generic;

namespace WpfDesignAndAnimationLab.Infrastructure
{
    public class ExampleDefinition
    {
        public ExampleDefinition(string name, Uri sourceCodeUri, params ExampleDefinitionItem[] items)
        {
            Name = name;
            ShourceCodeUri = sourceCodeUri;
            Items = items;
        }

        public ExampleDefinition(string name, Uri sourceCodeUri, Type control) : this(name, sourceCodeUri, new ExampleDefinitionItem(name, control))
        {
        }

        public IEnumerable<ExampleDefinitionItem> Items { get; }
        public string Name { get; private set; }

        public Uri ShourceCodeUri { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ExampleDefinitionItem
    {
        public ExampleDefinitionItem(string name, Type control)
        {
            Name = name;
            Control = control;
        }

        public Type Control { get; private set; }
        public string Name { get; private set; }
    }
}